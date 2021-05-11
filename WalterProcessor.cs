using RestSharp;
using Newtonsoft.Json.Linq;

namespace Walter
{
    class WalterProcessor
    {

        // retourne le token 
        public static string GetToken()
        {
            var client = new RestClient("https://waltergpsconnecttest.azurewebsites.net/sts/connect/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Bearer {{WGAToken}}");
            request.AddHeader("Cookie", "ARRAffinity=cf57495a1a1dc230ff7d212117a025a8b9beb004de9b646834c684f875c47d2b");
            request.AddParameter("client_id", "JanusFrance");
            request.AddParameter("client_secret", "i0JFfwoef2l7fwekf2498yfOnMi1.");
            request.AddParameter("scope", "WalterGPSConnectScope");
            request.AddParameter("grant_type", "act-as");
            request.AddParameter("user_id", "Janususer");
            request.AddParameter("instance_id", "Janusinstance");
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            // Parsing JSON content into element-node JObject
            var jObject = JObject.Parse(response.Content);

            //Extracting Node element using Getvalue method
            string token = jObject.GetValue("access_token").ToString();
            // Let us print the city variable to see what we got
            //Console.WriteLine("Access token is: " + token);

            return token;
        }
    }
}