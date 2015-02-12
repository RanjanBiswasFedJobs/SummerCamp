using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace SummerCamp.Web
{
    public static class GlobalConfig
    {
        public static void CustomizeConfig(HttpConfiguration config)
        {
           
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();

            // Add model validation, globally
            config.Filters.Add(new ValidationActionFilter());
        }
    }
}