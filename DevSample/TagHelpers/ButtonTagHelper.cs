﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace DevSample.TagHelpers
{
    /// <summary>
    ///     A tag helper for creating a Bootstrap button.
    /// </summary>
    [HtmlTargetElement("bs-button")]
    public class ButtonTagHelper : TagHelper
    {
        /// <summary>
        ///     What style of button to create.
        /// </summary>
        [HtmlAttributeName("bs-color")]
        public BootstrapColor Color { get; set; } = BootstrapColor.Info;

        /// <summary>
        ///     The type of button this will be
        /// </summary>
        public ButtonType Type { get; set; } = ButtonType.Button;

        /// <summary>
        ///     If set to true the element will not be shown
        /// </summary>
        public bool HideDisplay { get; set; }

        /// <summary>
        ///     The value of this button
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        ///     Is this button disabled
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        ///     Is this a block level button
        /// </summary>
        public bool Block { get; set; }

        [HtmlAttributeName("bs-fa-icon")]
        public string? Icon { get; set; }

        /// <summary>
        ///     The size of this button
        /// </summary>
        public ButtonSize Size { get; set; } = ButtonSize.Normal;

        /// <inheritdoc/>
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (HideDisplay)
            {
                output.SuppressOutput();
                return;
            }
            output.TagName = "button";
            output.Attributes.Add("type", Type.ToString().ToLowerInvariant());
            output.AddClass("btn", HtmlEncoder.Default);
            output.AddClass($"btn-{Color.ToString().ToLowerInvariant()}", HtmlEncoder.Default);
            output.Attributes.Add("role", "button");

            if (!string.IsNullOrEmpty(Value))
            {
                output.Attributes.Add("value", Value);
            }

            if (Disabled)
            {
                output.Attributes.Add(new TagHelperAttribute("disabled"));
            }

            if (Size != ButtonSize.Normal)
            {
                output.AddClass(Size switch
                {
                    ButtonSize.Large => "btn-lg",
                    ButtonSize.Small => "btn-sm",
                    ButtonSize.Normal => "",
                    _ => throw new ArgumentOutOfRangeException(nameof(Size))
                }, HtmlEncoder.Default);
            }

            if (Block)
            {
                output.AddClass("btn-block", HtmlEncoder.Default);
            }

            var content = await output.GetChildContentAsync();

            if (!string.IsNullOrEmpty(Icon))
            {
                var currentStringContent = content.GetContent();
                content.Clear();
                content.AppendFormat($"<em class='me-2 {Icon}'></em>");
                content.Append(currentStringContent);
            }

            if (content.IsEmptyOrWhiteSpace)
            {
                output.TagMode = TagMode.StartTagAndEndTag;
            }
            else
            {
                output.TagMode = TagMode.StartTagAndEndTag;
                output.Content = content;

            }
            return;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            ProcessAsync(context, output).GetAwaiter().GetResult();
        }
    }
}
