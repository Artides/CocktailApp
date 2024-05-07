using System.Globalization;
using System.Net.NetworkInformation;

namespace CocktailApp.Core.Utils;

public class InternetHelper
{
    private const string GOOGLE = "8.8.8.8";
    private const string APARAT = "aparat.com";
    private const string BAIDU = "baidu.com";
    public static bool IsInternetReachable()
    {
        if (DeviceInfo.Current.Platform == DevicePlatform.iOS)
        {
            return Connectivity.NetworkAccess == NetworkAccess.Internet;
        }

        try
        {
            Ping myPing = new Ping();
            String host
            = CultureInfo.InstalledUICulture switch
            {
                { Name: var n } when n.StartsWith("fa") => // Iran
                    APARAT,
                { Name: var n } when n.StartsWith("zh") => // China
                    BAIDU,
                _ =>
                    GOOGLE,
            };
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            return (reply.Status == IPStatus.Success);
        }
        catch (Exception)
        {
            return Connectivity.NetworkAccess == NetworkAccess.Internet;
        }
    }
}
