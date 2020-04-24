using Microsoft.Win32;

namespace fluentApps.Utils
{
    public class AppRegistry
    {
        public static string GetCommonAppRegistry(string strKeyName, string strDefault)
        {
            string userRoot = "HKEY_CURRENT_USER";
            string subkey = "SOFTWARE\\fluentDataWorks\\fluentApps";
            string keyName = userRoot + "\\" + subkey;

            string strReturn = (string)Registry.GetValue(keyName, strKeyName, strDefault);

            if (strReturn == null)
                strReturn = strDefault;

            return strReturn;
        }

        public static void SetCommonAppRegistry(string strKeyName, string strValue)
        {
            string userRoot = "HKEY_CURRENT_USER";
            string subkey = "SOFTWARE\\fluentDataWorks\\fluentApps";
            string keyName = userRoot + "\\" + subkey;

            Registry.SetValue(keyName, strKeyName, strValue);
        }
    }
}

