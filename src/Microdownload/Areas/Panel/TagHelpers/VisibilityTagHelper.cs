﻿using System.Threading.Tasks;
using Microdownload.Common.GuardToolkit;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Microdownload.Areas.Panel.TagHelpers
{
    /// <summary>
    /// More info: http://WWW/post/2527
    /// And http://WWW/post/2581
    /// </summary>
    [HtmlTargetElement("div")]
    public class VisibilityTagHelper : TagHelper
    {
        /// <summary>
        /// default to true otherwise all existing target elements will not be shown, because bool's default to false
        /// </summary>
        [HtmlAttributeName("asp-is-visible")]
        public bool IsVisible { get; set; } = true;

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            context.CheckArgumentIsNull(nameof(context));
            output.CheckArgumentIsNull(nameof(output));

            if (!IsVisible)
            {
                // suppress the output and generate nothing.
                output.SuppressOutput();
            }

            return base.ProcessAsync(context, output);
        }
    }
}