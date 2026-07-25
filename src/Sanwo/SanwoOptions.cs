namespace Sanwo;

public class SanwoOptions
{
    public string Provider { get; set; } = "paystack";
    public string PublicKey { get; set; } = "";
    public string Currency { get; set; } = "NGN";
    public bool Debug { get; set; } = false;
    public string ScriptUrl { get; set; } = "https://cdn.jsdelivr.net/npm/@sanwohq/embed/dist/sanwo.global.js";
}
