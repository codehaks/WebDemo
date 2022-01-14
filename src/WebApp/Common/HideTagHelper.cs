using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApp.Common
{
    [HtmlTargetElement(Attributes ="hide")]
    public class HideTagHelper:TagHelper
    {
        [HtmlAttributeName("hide")]
        public bool IsHidden { get; set; }=false;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (IsHidden)
            {
                output.TagName = null;
                output.SuppressOutput();
            }
        }

        public override int Order => int.MinValue;
    }
}
