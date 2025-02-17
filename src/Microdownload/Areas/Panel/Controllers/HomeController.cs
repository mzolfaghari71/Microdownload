﻿using DNTBreadCrumb.Core;
using Microdownload.Areas.Panel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Areas.Panel.Controllers
{
    [Area(AreaConstants.PanelArea)]
    [Authorize]
    [BreadCrumb(Title = "خانه", UseDefaultRouteUrl = true, Order = 0)]
    public class HomeController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public IActionResult Index() => View();
    }
}