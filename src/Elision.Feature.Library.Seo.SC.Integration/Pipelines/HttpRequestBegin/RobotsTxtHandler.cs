using System;
using System.Web;
using Elision.Foundation.Kernel;
using Sitecore.Pipelines.HttpRequest;

namespace Elision.Feature.Library.Seo.SC.Integration.Pipelines.HttpRequestBegin
{
    public class RobotsTxtHandler : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            var url = HttpContext.Current.Request.Url;
            if (!url.PathAndQuery.EndsWith("/robots.txt", StringComparison.OrdinalIgnoreCase))
                return;

            if (Sitecore.Context.Site != null && Sitecore.Context.Database != null)
            {
                var homeNode = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.RootPath + Sitecore.Context.Site.StartItem);
                if (homeNode == null || !homeNode.InheritsFrom(Templates._RobotsContent.TemplateId))
                    return;

                var robotsTxtContent = homeNode[Templates._RobotsContent.FieldIds.RobotsContent];
                HttpContext.Current.Response.ContentType = "text/plain";
                HttpContext.Current.Response.Write(robotsTxtContent);
                HttpContext.Current.Response.End();
                args.AbortPipeline();
            }
        }
    }
}
