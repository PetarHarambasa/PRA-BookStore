using Microsoft.AspNetCore.Mvc;
using PayPal.Api;

namespace PRA_Knjizara.Models.PayPalHelper
{
    public static class PaypalConfiguration
    {
        public readonly static string ClientId;
        public readonly static string ClientSecret;

        static PaypalConfiguration()
        {
            var config = GetConfig();
            ClientId = config["ClientId"];
            ClientSecret = config["ClientSecret"];
        }
        // getting properties from the web.config
        public static Dictionary<string, string> GetConfig()
        {
            return new Dictionary<string, string>()
            {
                { "ClientId", "AXFtdRtYXzwMEy7e91UVOUpIl6FFNRk7kRg3EJ6XeeypHlojDFiv92AN4kHkZzbFaMsAwLijrgq5z4Od" },
                { "ClientSecret", "EFC-UqfWrubdxI-Ww-mbrNgeKfVayaerJFEwcjYs0TJiWrosKlPdowvKzEUHuis4rjIa7rr5ohkbMxDj" }
            };
        }
        private static string GetAccessToken()
        {
            // getting accesstocken from paypal               
            //string accessToken = new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
            string accessToken = "A21AAK03BWUnRINpKJs05YW0NBwehWRbZi3nkxGxAGrwmXEfAKxBSqqCCYZAKCMGWQ0tcQ_0WBuheXzWXWftWuTQH4WlP-7RA";
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            // return apicontext object by invoking it with the accesstoken
            APIContext apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();
            return apiContext;
        }
    }
}
