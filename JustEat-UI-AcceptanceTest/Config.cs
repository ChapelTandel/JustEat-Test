using System.Configuration;

namespace JustEat_UI_AcceptanceTest
{
    public class Config
    {
        public static string GetUrl(string url)
        {
            var environment = GetEnvironment();
            url = string.Format("{0}.{1}", environment, url);
            return ConfigurationManager.AppSettings[url];
        }

        private static string GetEnvironment()
        {
            return ConfigurationManager.AppSettings["environment"];
        }

        public static string GetConfigValue(string value)
        {
            return ConfigurationManager.AppSettings[value];
        }
    }
}