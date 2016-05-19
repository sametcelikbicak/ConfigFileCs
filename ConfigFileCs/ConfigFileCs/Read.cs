using System;
using System.Configuration;

namespace ConfigFileCs
{
    static public class Read
    {
        static public string FromConfig(String key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }
    }
}
