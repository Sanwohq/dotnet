using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;

namespace SanwoHQ.TagHelpers;

[HtmlTargetElement("sanwo-checkout")]
public class SanwoCheckoutTagHelper : TagHelper
{
    private readonly SanwoOptions _options;

    public SanwoCheckoutTagHelper(IOptions<SanwoOptions> options)
    {
        _options = options.Value;
    }

    [HtmlAttributeName("amount")]
    public int Amount { get; set; }

    [HtmlAttributeName("email")]
    public string Email { get; set; } = "";

    [HtmlAttributeName("button-text")]
    public string ButtonText { get; set; } = "Pay Now";

    [HtmlAttributeName("button-class")]
    public string ButtonClass { get; set; } = "sanwo-button";

    [HtmlAttributeName("provider")]
    public string? Provider { get; set; }

    [HtmlAttributeName("public-key")]
    public string? PublicKey { get; set; }

    [HtmlAttributeName("currency")]
    public string? Currency { get; set; }

    [HtmlAttributeName("description")]
    public string? Description { get; set; }

    [HtmlAttributeName("reference")]
    public string? Reference { get; set; }

    [HtmlAttributeName("first-name")]
    public string? FirstName { get; set; }

    [HtmlAttributeName("last-name")]
    public string? LastName { get; set; }

    [HtmlAttributeName("phone")]
    public string? Phone { get; set; }

    [HtmlAttributeName("callback")]
    public string? Callback { get; set; }

    [HtmlAttributeName("template-url")]
    public string? TemplateUrl { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "button";
        output.Attributes.SetAttribute("class", ButtonClass);
        output.Attributes.SetAttribute("data-sanwo-provider", Provider ?? _options.Provider);
        output.Attributes.SetAttribute("data-sanwo-key", PublicKey ?? _options.PublicKey);
        output.Attributes.SetAttribute("data-sanwo-amount", Amount.ToString());
        output.Attributes.SetAttribute("data-sanwo-currency", Currency ?? _options.Currency);
        output.Attributes.SetAttribute("data-sanwo-email", Email);

        if (_options.Debug)
            output.Attributes.SetAttribute("data-sanwo-debug", "true");
        if (!string.IsNullOrEmpty(Description))
            output.Attributes.SetAttribute("data-sanwo-description", Description);
        if (!string.IsNullOrEmpty(Reference))
            output.Attributes.SetAttribute("data-sanwo-reference", Reference);
        if (!string.IsNullOrEmpty(FirstName))
            output.Attributes.SetAttribute("data-sanwo-first-name", FirstName);
        if (!string.IsNullOrEmpty(LastName))
            output.Attributes.SetAttribute("data-sanwo-last-name", LastName);
        if (!string.IsNullOrEmpty(Phone))
            output.Attributes.SetAttribute("data-sanwo-phone", Phone);
        if (!string.IsNullOrEmpty(Callback))
            output.Attributes.SetAttribute("data-sanwo-callback", Callback);
        if (!string.IsNullOrEmpty(TemplateUrl))
            output.Attributes.SetAttribute("data-sanwo-template-url", TemplateUrl);

        output.Content.SetContent(ButtonText);
    }
}
