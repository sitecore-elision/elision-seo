namespace Elision.Feature.Library.Seo.SC.Integration.Pipelines.GetCanonicalUrl
{
    public interface IGetCanonicalUrlProcessor
    {
        void Process(Elision.Seo.Pipelines.GetCanonicalUrl.GetCanonicalUrlArgs args);
    }
}