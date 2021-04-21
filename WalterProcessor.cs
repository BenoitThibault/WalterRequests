using JsonParser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walter
{
    class WalterProcessor
    {
        public static async Task<string> displayRequest()
        {
            string url = "http://ip-api.com/json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    usefulData usefulData = await response.Content.ReadAsAsync<usefulData>();
                    string jsonString = JsonConvert.SerializeObject(usefulData, Formatting.Indented);
                    return jsonString;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase); //Renvoie la raison de l'erreur.
                }
            }
        }


        /*public static async Task<Walter> LoadResponse()
        {
            string url = "https://waltergpsconnecttest.azurewebsites.net/STS/connect/token"; //Remettre l'url de l'API plus tard

            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(url))

                if (response.IsSuccessStatusCode)
                {
                    Walter result = await response.Content.ReadAsAsync<Walter>();
                    return result; //Si la réponse de l'API est positive, on renvoie directectement le json récupéré
                }

                else
                    throw new HttpException("An error occured while loading the web page");
        }*/
        
    }
}