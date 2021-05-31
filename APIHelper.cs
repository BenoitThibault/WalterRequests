using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Walter
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        // Retourne la réponse json de l'url passée en paramètre à partir de la requête json jsonString envoyée.
        public static IRestResponse GetResponse(string jsonString, string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string token = Walter.WalterProcessor.GetToken();
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddHeader("Cookie", "ARRAffinity=cf57495a1a1dc230ff7d212117a025a8b9beb004de9b646834c684f875c47d2b");
            request.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //HttpStatusCode statusCode = response.StatusCode;
            //int numericStatusCode = (int)statusCode;

            JObject jObject = JObject.Parse(response.Content);

            if (jObject.GetValue("Url") != null) {
                string target = jObject.GetValue("Url").ToString();
                System.Diagnostics.Process.Start(@target); //Ouverture de la page web dans le navigateur
            }
    
            return response;
        }

        //Converti le json passé en paramètre sous forme de string indenté et simplé
        public static string convertToJson(JsonParser.JsonOperation jsonOperation)
        {
            return JsonConvert.SerializeObject(jsonOperation, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }


    }
}