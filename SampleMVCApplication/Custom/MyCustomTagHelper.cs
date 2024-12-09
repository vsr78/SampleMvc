using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace SampleMVCApplication.Custom
{
    [HtmlTargetElement("custom")]
    public class MyCustomTagHelper : TagHelper
    {
        public string Message { get; set; }

        public ModelExpression AspFor { get; set; }
       
        //public override void Process(TagHelperContext context, TagHelperOutput output)
        //{
        //    output.TagName = "ui";
        //    output.Content.AppendHtml($"<li>{Message}</li>");
        //}

        public override async Task  ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ui";
            var tagHelperContent = await output.GetChildContentAsync();
            var content = tagHelperContent.GetContent();
            var listItems = content.Split(",", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in listItems)
            {
                output.Content.AppendHtml($"<li>{item}</li>");
            } 
        }
    }
}
