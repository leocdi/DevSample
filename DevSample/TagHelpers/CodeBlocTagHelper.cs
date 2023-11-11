using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DevSample.TagHelpers
{
    /// <summary>
    ///     A tag helper for creating a Bootstrap button.
    /// </summary>
    [HtmlTargetElement("code-bloc")]
    public class CodeBlocTagHelper : TagHelper
    {
        /// <summary>
        ///     What style of button to create.
        /// </summary>
        [HtmlAttributeName("bs-color")]
        public BootstrapColor Color { get; set; } = BootstrapColor.Info;

        ///// <summary>
        /////     The type of button this will be
        ///// </summary>
        //public ButtonType Type { get; set; } = ButtonType.Button;

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
       
            return;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            ProcessAsync(context, output).GetAwaiter().GetResult();
        }
    }
}
