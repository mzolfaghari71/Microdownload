﻿using DNTBreadCrumb.Core;
using DNTCommon.Web.Core;
using DNTPersianUtils.Core;
using Microdownload.Common.GuardToolkit;
using Microdownload.Common.IdentityToolkit;
using Microdownload.Entities.Identity;
using Microdownload.Services.Contracts.Identity;
using Microdownload.Services.Identity;
using Microdownload.ViewModels.Identity;
using Microdownload.ViewModels.Identity.Emails;
using Microdownload.ViewModels.Identity.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace Microdownload.Areas.Panel.Controllers
{
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [Area(AreaConstants.PanelArea)]
    [BreadCrumb(Title = "مشخصات کاربری", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("مشخصات کاربری")]

    public class UserProfileController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly IProtectionProviderService _protectionProviderService;
        private readonly IApplicationRoleManager _roleManager;
        private readonly IApplicationSignInManager _signInManager;
        private readonly IOptionsSnapshot<SiteSettings> _siteOptions;
        private readonly IUsedPasswordsService _usedPasswordsService;
        private readonly IApplicationUserManager _userManager;
        private readonly IUsersPhotoService _usersPhotoService;
        private readonly IUserValidator<User> _userValidator;
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(
            IApplicationUserManager userManager,
            IApplicationRoleManager roleManager,
            IApplicationSignInManager signInManager,
            IProtectionProviderService protectionProviderService,
            IUserValidator<User> userValidator,
            IUsedPasswordsService usedPasswordsService,
            IUsersPhotoService usersPhotoService,
            IOptionsSnapshot<SiteSettings> siteOptions,
            IEmailSender emailSender,
            ILogger<UserProfileController> logger)
        {
            _userManager = userManager;
            _userManager.CheckArgumentIsNull(nameof(_userManager));

            _roleManager = roleManager;
            _roleManager.CheckArgumentIsNull(nameof(_roleManager));

            _signInManager = signInManager;
            _signInManager.CheckArgumentIsNull(nameof(_signInManager));

            _protectionProviderService = protectionProviderService;
            _protectionProviderService.CheckArgumentIsNull(nameof(_protectionProviderService));

            _userValidator = userValidator;
            _userValidator.CheckArgumentIsNull(nameof(_userValidator));

            _usedPasswordsService = usedPasswordsService;
            _usedPasswordsService.CheckArgumentIsNull(nameof(_usedPasswordsService));

            _usersPhotoService = usersPhotoService;
            _usersPhotoService.CheckArgumentIsNull(nameof(_usersPhotoService));

            _siteOptions = siteOptions;
            _siteOptions.CheckArgumentIsNull(nameof(_siteOptions));

            _emailSender = emailSender;
            _emailSender.CheckArgumentIsNull(nameof(_emailSender));

            _logger = logger;
            _logger.CheckArgumentIsNull(nameof(_logger));
        }

        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        [BreadCrumb(Title = "ایندکس", Order = 1)]
        [DisplayName("ایندکس")]

        public async Task<IActionResult> AdminEdit(int? id)
        {
            if (!id.HasValue)
            {
                return View("Error");
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            return await renderForm(user, isAdminEdit: true);
        }

        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetCurrentUserAsync();
            return await renderForm(user, isAdminEdit: false);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(UserProfileViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var pid = _protectionProviderService.Decrypt(model.Pid);
                if (string.IsNullOrWhiteSpace(pid))
                {
                    return View("Error");
                }
                var cuserId = int.Parse(_userManager.GetCurrentUserId());
                if (pid != _userManager.GetCurrentUserId() && !_roleManager.IsCurrentUserInRole(ConstantRoles.Admin))
                {
                    if (pid != _userManager.GetCurrentUserId() && cuserId != model.RegistrarId)
                    {
                        _logger.LogWarning($"سعی در دسترسی غیرمجاز به ویرایش اطلاعات کاربر {pid}");
                        return View("Error");
                    }

                }


                var user = await _userManager.FindByIdAsync(pid);
                if (user == null)
                {
                    return View("NotFound");
                }

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.IsEmailPublic = model.IsEmailPublic;
                user.TwoFactorEnabled = model.TwoFactorEnabled;
                user.Location = model.Location;
                user.PhoneNumber = model.PhoneNumber;

                if (_roleManager.IsCurrentUserInRole(ConstantRoles.Admin))
                {
                    user.Referrer = model.Referrer;
                    user.RegistrarId = model.RegistrarId;

                    if (!await updateUserName(model, user))
                    {
                        return View(viewName: nameof(Index), model: model);
                    }
                    if (!await updateUserEmail(model, user))
                    {
                        return View(viewName: nameof(Index), model: model);
                    }
                }
                else if (pid != _userManager.GetCurrentUserId())
                {
                    user.Referrer = model.Referrer;
                    user.RegistrarId = model.RegistrarId;

                    if (!await updateUserName(model, user))
                    {
                        return View(viewName: nameof(Index), model: model);
                    }
                    if (!await updateUserEmail(model, user))
                    {
                        return View(viewName: nameof(Index), model: model);
                    }

                }
                user.BankCardNumber = model.BankCardNumber;
                user.ShabaNumber = model.ShabaNumber;
                user.BankAccountNumber = model.BankAccountNumber;
                user.PostalCode = model.PostalCode;
                updateUserBirthDate(model, user);


                if (!await updateUserAvatarImage(model, user))
                {
                    return View(viewName: nameof(Index), model: model);
                }



                var updateResult = await _userManager.UpdateAsync(user);
                if (updateResult.Succeeded)
                {
                    if (!model.IsAdminEdit)
                    {
                        // reflect the changes in the current user's Identity cookie
                        await _signInManager.RefreshSignInAsync(user);
                    }

                    await _emailSender.SendEmailAsync(
                           email: user.Email,
                           subject: "اطلاع رسانی به روز رسانی مشخصات کاربری",
                           viewNameOrPath: "~/Areas/Panel/Views/EmailTemplates/_UserProfileUpdateNotification.cshtml",
                           model: new UserProfileUpdateNotificationViewModel
                           {
                               User = user,
                               EmailSignature = _siteOptions.Value.Smtp.FromName,
                               MessageDateTime = DateTime.UtcNow.ToLongPersianDateTimeString()
                           });

                    return RedirectToAction(nameof(Index), "UserCard", routeValues: new { id = user.Id });
                }

                ModelState.AddModelError("", updateResult.DumpErrors(useHtmlNewLine: true));
            }
            return View(viewName: nameof(Index), model: model);
        }

        /// <summary>
        /// For [Remote] validation
        /// </summary>
        [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> ValidateUsername(string username, string email, string pid)
        {
            pid = _protectionProviderService.Decrypt(pid);
            if (string.IsNullOrWhiteSpace(pid))
            {
                return Json("اطلاعات وارد شده معتبر نیست.");
            }

            var user = await _userManager.FindByIdAsync(pid);
            user.UserName = username;
            user.Email = email;

            var result = await _userValidator.ValidateAsync((UserManager<User>)_userManager, user);
            return Json(result.Succeeded ? "true" : result.DumpErrors(useHtmlNewLine: true));
        }

        private static void updateUserBirthDate(UserProfileViewModel model, User user)
        {
            if (model.DateOfBirthYear.HasValue &&
                model.DateOfBirthMonth.HasValue &&
                model.DateOfBirthDay.HasValue)
            {
                var date =
                    $"{model.DateOfBirthYear.Value.ToString()}/{model.DateOfBirthMonth.Value.ToString("00")}/{model.DateOfBirthDay.Value.ToString("00")}";
                user.BirthDate = date.ToGregorianDateTimeOffset();
            }
            else
            {
                user.BirthDate = null;
            }
        }

        private async Task<IActionResult> renderForm(User user, bool isAdminEdit)
        {
            var cuserId = int.Parse(_userManager.GetCurrentUserId());

            if (!_roleManager.IsCurrentUserInRole(ConstantRoles.Admin))
            {
                if (user.RegistrarId != cuserId && (user.Id != cuserId))
                {
                    _logger.LogWarning($"سعی در دسترسی غیرمجاز به ویرایش اطلاعات کاربر {user.UserName}");
                    return View("AccessDenied");

                }

            }

            _usersPhotoService.SetUserDefaultPhoto(user);

            var userProfile = new UserProfileViewModel
            {
                IsAdminEdit = isAdminEdit,
                Email = user.Email,
                PhotoFileName = user.PhotoFileName,
                Location = user.Location,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Referrer = user.Referrer,
                PhoneNumber = user.PhoneNumber,
                BankAccountNumber = user.BankAccountNumber,
                ShabaNumber = user.ShabaNumber,
                BankCardNumber = user.BankCardNumber,
                PostalCode = user.PostalCode,
                Pid = _protectionProviderService.Encrypt(user.Id.ToString()),
                RegistrarId = user.RegistrarId,
                IsEmailPublic = user.IsEmailPublic,
                TwoFactorEnabled = user.TwoFactorEnabled,
                IsPasswordTooOld = await _usedPasswordsService.IsLastUserPasswordTooOldAsync(user.Id),

            };

            if (user.BirthDate.HasValue)
            {
                var pDateParts = user.BirthDate.Value.ToPersianYearMonthDay(DateTimeOffsetPart.DateTime);
                userProfile.DateOfBirthYear = pDateParts.Item1;
                userProfile.DateOfBirthMonth = pDateParts.Item2;
                userProfile.DateOfBirthDay = pDateParts.Item3;
            }

            return View(viewName: nameof(Index), model: userProfile);
        }

        private async Task<bool> updateUserAvatarImage(UserProfileViewModel model, User user)
        {
            _usersPhotoService.SetUserDefaultPhoto(user);

            var photoFile = model.Photo;
            if (photoFile != null && photoFile.Length > 0)
            {
                var imageOptions = _siteOptions.Value.UserAvatarImageOptions;
                if (!photoFile.IsValidImageFile(maxWidth: imageOptions.MaxWidth, maxHeight: imageOptions.MaxHeight))
                {
                    this.ModelState.AddModelError("",
                        $"حداکثر اندازه تصویر قابل ارسال {imageOptions.MaxHeight} در {imageOptions.MaxWidth} پیکسل است");
                    model.PhotoFileName = user.PhotoFileName;
                    return false;
                }

                var uploadsRootFolder = _usersPhotoService.GetUsersAvatarsFolderPath();
                var photoFileName = $"{user.Id}{Path.GetExtension(photoFile.FileName)}";
                var filePath = Path.Combine(uploadsRootFolder, photoFileName);

                using (Image img = Image.FromStream(photoFile.OpenReadStream(), true, true))
                {
                    Stream ms = new MemoryStream(img.Resize(150, 150).ToByteArray());

                    Image newImage = Image.FromStream(ms);
                    newImage.Save(filePath, ImageFormat.Jpeg);

                }





                user.PhotoFileName = photoFileName;
            }
            return true;
        }

        private async Task<bool> updateUserEmail(UserProfileViewModel model, User user)
        {
            if (user.Email != model.Email)
            {
                user.Email = model.Email;
                var userValidator =
                    await _userValidator.ValidateAsync((UserManager<User>)_userManager, user);
                if (!userValidator.Succeeded)
                {
                    ModelState.AddModelError("", userValidator.DumpErrors(useHtmlNewLine: true));
                    return false;
                }

                user.EmailConfirmed = false;

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                await _emailSender.SendEmailAsync(
                    email: user.Email,
                    subject: "لطفا اکانت خود را تائید کنید",
                    viewNameOrPath: "~/Areas/Panel/Views/EmailTemplates/_RegisterEmailConfirmation.cshtml",
                    model: new RegisterEmailConfirmationViewModel
                    {
                        User = user,
                        EmailConfirmationToken = code,
                        EmailSignature = _siteOptions.Value.Smtp.FromName,
                        MessageDateTime = DateTime.UtcNow.ToLongPersianDateTimeString()
                    });
            }

            return true;
        }

        private async Task<bool> updateUserName(UserProfileViewModel model, User user)
        {
            if (user.UserName != model.UserName)
            {
                user.UserName = model.UserName;
                var userValidator =
                    await _userValidator.ValidateAsync((UserManager<User>)_userManager, user);
                if (!userValidator.Succeeded)
                {
                    ModelState.AddModelError("", userValidator.DumpErrors(useHtmlNewLine: true));
                    return false;
                }
            }
            return true;
        }
    }
}