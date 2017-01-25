using Elision.Seo.Pipelines.GetCanonicalUrl;

namespace Elision.Feature.Library.Seo.SC.Integration.Pipelines.GetCanonicalUrl
{
    public class GetLowercaseCanonical : IGetCanonicalUrlProcessor
    {
        public void Process(Elision.Seo.Pipelines.GetCanonicalUrl.GetCanonicalUrlArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.CanonicalUrl))
                args.CanonicalUrl = args.CanonicalUrl.ToLowerInvariant();
            else if (!string.IsNullOrWhiteSpace(args.RawUrl) && args.RawUrl != args.RawUrl.ToLowerInvariant())
                args.CanonicalUrl = args.RawUrl.ToLowerInvariant();
        }
    }
}