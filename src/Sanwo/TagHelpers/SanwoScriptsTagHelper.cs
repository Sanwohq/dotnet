using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;

namespace Sanwo.TagHelpers;

[HtmlTargetElement("sanwo-scripts")]
public class SanwoScriptsTagHelper : TagHelper
{
    private readonly SanwoOptions _options;

    public SanwoScriptsTagHelper(IOptions<SanwoOptions> options)
    {
        _options = options.Value;
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "script";
        output.Attributes.SetAttribute("src", _options.ScriptUrl);
        output.TagMode = TagMode.StartTagAndEndTag;
    }
}
