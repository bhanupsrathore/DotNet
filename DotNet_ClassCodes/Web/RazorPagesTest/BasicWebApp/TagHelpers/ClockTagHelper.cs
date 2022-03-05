using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BasicWebApp.TagHelpers;

[HtmlTargetElement("span", Attributes = "clock-time-format")]
public class ClockTagHelper : TagHelper
{
    public string ClockTimeFormat { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        string time = DateTime.Now.ToString(ClockTimeFormat);
        output.Content.SetContent(time);
    }

}
