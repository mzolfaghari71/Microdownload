#pragma checksum "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d48527be16e0cda94823e6ca2e91fdf437519004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_Courses_Index), @"mvc.1.0.view", @"/Areas/Panel/Views/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Panel/Views/Courses/Index.cshtml", typeof(AspNetCore.Areas_Panel_Views_Courses_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 13 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Areas.Panel;

#line default
#line hidden
#line 2 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Entities.Identity;

#line default
#line hidden
#line 5 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Services.Contracts.Identity;

#line default
#line hidden
#line 6 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Services.Identity;

#line default
#line hidden
#line 7 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity;

#line default
#line hidden
#line 8 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity.Emails;

#line default
#line hidden
#line 9 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity.Settings;

#line default
#line hidden
#line 10 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 11 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 12 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 14 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 15 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 16 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.DataLayer.Context;

#line default
#line hidden
#line 17 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Entities.AuditableEntity;

#line default
#line hidden
#line 18 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#line 19 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels;

#line default
#line hidden
#line 20 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Common.WebToolkit;

#line default
#line hidden
#line 21 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48527be16e0cda94823e6ca2e91fdf437519004", @"/Areas/Panel/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbc03c310595be153c47e0111723af51088497e6", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-heading"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel panel-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/server/assets/js/core/MvcGrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
  
    ViewData["Title"] = "دوره ها";

#line default
#line hidden
            BeginContext(82, 3064, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbcc5f92232546ac9073853706dd994f", async() => {
                BeginContext(115, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(121, 459, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f6b00fd906f4a59b306015c94c1b8b5", async() => {
                    BeginContext(148, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(158, 410, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721d802393df4131a1e9245a94cecadf", async() => {
                        BeginContext(175, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(189, 107, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "886a3c3324ee4b1aab7b88c7a7259a33", async() => {
                            BeginContext(211, 42, true);
                            WriteLiteral("\r\n                <h3 class=\"panel-title\">");
                            EndContext();
                            BeginContext(254, 17, false);
#line 10 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                                   Write(ViewData["Title"]);

#line default
#line hidden
                            EndContext();
                            BeginContext(271, 19, true);
                            WriteLiteral("</h3>\r\n            ");
                            EndContext();
                        }
                        );
                        __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                        __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(296, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(310, 242, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2aa2ada9f46451f9844797b09b17fec", async() => {
                            BeginContext(332, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(350, 182, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7406f3961d3f4c0a9f3c2f156dd0fda6", async() => {
                                BeginContext(384, 142, true);
                                WriteLiteral("\r\n                    <a class=\"btn btn-success\" href=\"#\" id=\"btnCreateNew\"><i class=\"fa fa-plus\"> </i> افزودن دوره جدید</a>\r\n                ");
                                EndContext();
                            }
                            );
                            __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                            __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(532, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                        __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(552, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(568, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(580, 12, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(592, 2449, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9568055a2a94988a4d7efdb6ad9e0a9", async() => {
                    BeginContext(616, 14, true);
                    WriteLiteral("\r\n\r\n\r\n        ");
                    EndContext();
                    BeginContext(632, 2392, false);
#line 25 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
    Write(Html
                                                              .Grid(Model)
                                                              .Build(columns =>
                                                              {
                                                                  columns.Add(model => model.CourseName).Titled("نام دوره");
                                                                  columns.Add(model => model.CourseStatus).Titled("نوع دوره");
                                                                  columns.Add(model => model.CreatedDate.ToFriendlyPersianDateTextify()).Titled("تاریخ ایجاد");
                                                                  columns.Add(model => model.Price.ToString("N0").ToPersianNumbers()).Titled("قیمت دوره(ریال)");
                                                                  columns.Add(model => model.StartDate.ToFriendlyPersianDateTextify()).Titled("تاریخ شروع دوره");



                                                                  columns.Add(model => $"<a  asp-controller=\"Corses\" asp-action=\"EditCourse\"   href =\"Courses/EditCourse/{model.Id}\" class=\"btn btn-sm btn-info\" style=\"margin-left:10px\">نمایش</a>").Encoded(false);
                                                                  columns.Add(model => $"<a  href=\"#\"  id=\"btnEdit-{model.Id}\" data-edit-id=\"{model.Id}\" class=\"btn btn-sm btn-danger\" style=\"margin-left:10px\">ویرایش</a>").Encoded(false);


                                                              })
                                                                    .Empty("دوره ای یافت نشد")
                                                                    .Filterable()
                                                                    .Sortable()
                                                                    .Pageable(pager =>
                                                                    {
                                                                        pager.ProcessorType = GridProcessorType.Manual;
                                                                        pager.TotalRows = ViewBag.TotalRows;
                                                                        pager.RowsPerPage = 10;
                                                                    })
        );

#line default
#line hidden
                    EndContext();
                    BeginContext(3025, 10, true);
                    WriteLiteral("\r\n\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3041, 12, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(3053, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea3f2cda4c5e47b19e2dd23e7bdf126b", async() => {
                    BeginContext(3079, 29, true);
                    WriteLiteral("\r\n        تعداد کل دوره ها : ");
                    EndContext();
                    BeginContext(3109, 13, false);
#line 59 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                      Write(Model.Count());

#line default
#line hidden
                    EndContext();
                    BeginContext(3122, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3134, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3146, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3177, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3183, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471cbed651094896b9fd348ba15439b7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3241, 232, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\'#btnCreateNew\').click(function (e) {\r\n                e.preventDefault();\r\n\r\n                $.bootstrapModalAjaxForm({\r\n\r\n                    postUrl: \'");
                EndContext();
                BeginContext(3474, 34, false);
#line 77 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                         Write(Url.Action("AddCourse", "Courses"));

#line default
#line hidden
                EndContext();
                BeginContext(3508, 52, true);
                WriteLiteral("\',\r\n                    renderModalPartialViewUrl: \'");
                EndContext();
                BeginContext(3561, 37, false);
#line 78 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                                           Write(Url.Action("RenderCourse", "Courses"));

#line default
#line hidden
                EndContext();
                BeginContext(3598, 639, true);
                WriteLiteral(@"',
                    renderModalPartialViewData: {},
                    loginUrl: '/Panel/login',
                    beforePostHandler: function () {
                    },
                    completeHandler: function () {
                        location.reload();
                    },
                    errorHandler: function () {
                    }
                });
            });

            $(""a[id^='btnEdit']"").click(function (e) {
                e.preventDefault();
                var slideId = $(this).data(""edit-id"");

                $.bootstrapModalAjaxForm({
                    postUrl: '");
                EndContext();
                BeginContext(4238, 34, false);
#line 96 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                         Write(Url.Action("AddCourse", "Courses"));

#line default
#line hidden
                EndContext();
                BeginContext(4272, 52, true);
                WriteLiteral("\',\r\n                    renderModalPartialViewUrl: \'");
                EndContext();
                BeginContext(4325, 37, false);
#line 97 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                                           Write(Url.Action("RenderCourse", "Courses"));

#line default
#line hidden
                EndContext();
                BeginContext(4362, 674, true);
                WriteLiteral(@"',
                    renderModalPartialViewData: JSON.stringify({ ""id"": slideId }),
                    loginUrl: '/Panel/login',
                    beforePostHandler: function () {
                    },
                    completeHandler: function () {
                        location.reload();
                    },
                    errorHandler: function () {
                    }
                });
            });

            $(""a[id^='btnDelete']"").click(function (e) {
                e.preventDefault();
                var slideId = $(this).data(""delete-id"");

                $.bootstrapModalAjaxForm({
                    postUrl: '");
                EndContext();
                BeginContext(5037, 42, false);
#line 115 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                         Write(Url.Action("DeleteInsurance", "Insurance"));

#line default
#line hidden
                EndContext();
                BeginContext(5079, 52, true);
                WriteLiteral("\',\r\n                    renderModalPartialViewUrl: \'");
                EndContext();
                BeginContext(5132, 48, false);
#line 116 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\Courses\Index.cshtml"
                                           Write(Url.Action("RenderDeleteInsurance", "Insurance"));

#line default
#line hidden
                EndContext();
                BeginContext(5180, 477, true);
                WriteLiteral(@"',
                    renderModalPartialViewData: JSON.stringify({ ""id"": slideId }),
                    loginUrl: '/Panel/login',
                    beforePostHandler: function () {
                    },
                    completeHandler: function () {
                        location.reload();
                    },
                    errorHandler: function () {
                    }
                });
            });
        });


    </script>

");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
