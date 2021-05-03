using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Walter
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static IRestResponse GetResponse(JsonParser.JsonOperation json)
        {
            string operationTypeName = "GetCuttingDataForHoleOnSolidMaterial"; //Par la suite: faire en sorte que ça soit adapatable en fonction du bon type de classe
            var client = new RestClient("http://WalterGPSConnectTest.azurewebsites.net/WGCApi/V1.0/" + operationTypeName);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string token = Walter.WalterProcessor.GetToken();
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddHeader("Cookie", "ARRAffinity=cf57495a1a1dc230ff7d212117a025a8b9beb004de9b646834c684f875c47d2b");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}