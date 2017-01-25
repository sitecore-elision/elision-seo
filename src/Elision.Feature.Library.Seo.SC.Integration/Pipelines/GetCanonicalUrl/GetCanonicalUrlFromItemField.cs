using Elision.Foundation.Kernel;
using Elision.Seo.Pipelines.GetCanonicalUrl;

namespace Elision.Feature.Library.Seo.SC.Integration.Pipelines.GetCanonicalUrl
{
    public class GetCanonicalUrlFromItemField : IGetCanonicalUrlProcessor
    {
        public void Process(Elision.Seo.Pipelines.GetCanonicalUrl.GetCanonicalUrlArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.CanonicalUrl))
                return;

            var itemCanonical = args.PageItem?.Fields.GetValue(Templates._PageMetaFields.FieldIds.CanonicalUrl);
            if (!string.IsNullOrWhiteSpace(itemCanonical))
                args.CanonicalUrl = itemCanonical;
        }
    }
}