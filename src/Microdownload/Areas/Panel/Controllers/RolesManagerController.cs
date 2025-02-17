﻿using Microdownload.Common.GuardToolkit;
using Microdownload.Common.IdentityToolkit;
using Microdownload.Entities.Identity;
using Microdownload.Services.Contracts.Identity;
using Microdownload.ViewModels.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microdownload.Services.Identity;
using DNTBreadCrumb.Core;
using DNTCommon.Web.Core;
using Microdownload.Areas.Panel;

namespace Microdownload.Areas.Panel.Controllers
{
    [Authorize(Roles = ConstantRoles.Admin)]
    [Area(AreaConstants.PanelArea)]
    [BreadCrumb(Title = "مدیریت نقش‌ها", UseDefaultRouteUrl = true, Order = 0)]
    public class RolesManagerController : Controller
    {
        private const string RoleNotFound = "نقش درخواستی یافت نشد.";
        private const int DefaultPageSize = 7;

        private readonly IApplicationRoleManager _roleManager;

        public RolesManagerController(IApplicationRoleManager roleManager)
        {
            _roleManager = roleManager;
            _roleManager.CheckArgumentIsNull(nameof(_roleManager));
        }

        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public IActionResult Index()
        {
            var roles = _roleManager.GetAllCustomRolesAndUsersCountList();
            return View(roles);
        }

        [AjaxOnly]
        public async Task<IActionResult> RenderRole([FromBody]ModelIdViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView("_Create");
            }

            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ModelState.AddModelError("", RoleNotFound);
                return PartialView("_Create");
            }
            return PartialView("_Create", model: new RoleViewModel { Id = role.Id.ToString(), Name = role.Name });
        }

        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(model.Id);
                if (role == null)
                {
                    ModelState.AddModelError("", RoleNotFound);
                }
                else
                {
                    role.Name = model.Name;
                    role.Degree = model.Degree;
                    var result = await _roleManager.UpdateAsync(role);
                    if (result.Succeeded)
                    {
                        return Json(new { success = true });
                    }
                    ModelState.AddErrorsFromResult(result);
                }
            }
            return PartialView("_Create", model: model);
        }

        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new Role( name:model.Name,degree:model.Degree));
                if (result.Succeeded)
                {
                    return Json(new { success = true });
                }
                ModelState.AddErrorsFromResult(result);
            }
            return PartialView("_Create", model: model);
        }

        [AjaxOnly]
        public async Task<IActionResult> RenderDeleteRole([FromBody]ModelIdViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView("_Delete");
            }

            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ModelState.AddModelError("", RoleNotFound);
                return PartialView("_Delete");
            }
            return PartialView("_Delete", model: new RoleViewModel { Id = role.Id.ToString(), Name = role.Name });
        }

        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(RoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ModelState.AddModelError("", RoleNotFound);
            }
            else
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return Json(new { success = true });
                }
                ModelState.AddErrorsFromResult(result);
            }
            return PartialView("_Delete", model: model);
        }

        [BreadCrumb(Title = "لیست نمایندگان دارای نقش", Order = 1)]
        public async Task<IActionResult> UsersInRole(int? id, int? page = 1, string field = "Id", SortOrder order = SortOrder.Ascending)
        {
            if (id == null)
            {
                return View("Error");
            }

            var model = await _roleManager.GetPagedApplicationUsersInRoleListAsync(
                roleId: id.Value,
                pageNumber: page.Value - 1,
                recordsPerPage: DefaultPageSize,
                sortByField: field,
                sortOrder: order,
                showAllUsers: true);
            var cuRole = _roleManager.GetRolesForCurrentUser();
             
            var d = 0;
            foreach (var item in cuRole)
            {
                if (item.Degree > d)
                {
                    d = item.Degree;
                }
            }
            if (User.IsInRole(ConstantRoles.Admin))
            {
                d = 0;
            }
            ViewData["d"] = d;
            model.Paging.CurrentPage = page.Value;
            model.Paging.ItemsPerPage = DefaultPageSize;
            model.Paging.ShowFirstLast = true;

            if (HttpContext.Request.IsAjaxRequest())
            {
                return PartialView("~/Areas/Panel/Views/UsersManager/_UsersList.cshtml", model);
            }
            return View(model);
        }
    }
}