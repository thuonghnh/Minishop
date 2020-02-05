﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace WebApp
{
    public class PaginationTagHelper : TagHelper
    {
        public string Url { get; set; }
        public int Total { get; set; }
        public int Size { get; set; }
        public int Page { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.Attributes.Add("class", "pagination");
            int n = (Total - 1) / Size + 1;
            
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                string uri = string.Format(Url, i);
                if (Page == i)
                {
                    sb.AppendFormat("<li class=\"active\">{0}</li>", i);
                }
                else
                {
                    sb.AppendFormat("<li><a href=\"{0}\">{1}</a></li>", uri, i);
                }
            }
            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
