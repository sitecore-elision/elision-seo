using Elision.Feature.Library.Seo.Areas.ElisionFeature.Models;
using Elision.Foundation.Kernel;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Elision.Feature.Library.Seo
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPageMetadataModelBuilder, PageMetadataModelBuilder>();
            serviceCollection.AddMvcControllers("Elision.Feature.Library.Seo.*");
        }
    }
}