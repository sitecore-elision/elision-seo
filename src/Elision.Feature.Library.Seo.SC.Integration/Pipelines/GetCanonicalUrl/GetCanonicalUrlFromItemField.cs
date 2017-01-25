using Elision.Foundation.Kernel;

namespace Elision.Feature.Library.Seo.SC.Integration.Pipelines.GetCanonicalUrl
{
    public class GetCanonicalUrlFromItemField : IGetCanonicalUrlProcessor
    {
        public void Process(GetCanonicalUrlArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.CanonicalUrl))
                return;

            var itemCanonical = args.PageItem?.Fields.GetValue(Templates._PageMetaFields.FieldIds.CanonicalUrl);
            if (!string.IsNullOrWhiteSpace(itemCanonical))
                args.CanonicalUrl = itemCanonical;
        }
    }
}