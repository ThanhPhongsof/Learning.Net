using FluentValidation.Mvc;
using FluentValidation.Validator;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FluentValidation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            ValidationConfiguration();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ValidationConfiguration()
        {
            FluentValidationModelValidatorProvider.Configure(p =>
            {
                p.ValidatorFactory = new ValidatorFactory();
            });
        }
    }
}
