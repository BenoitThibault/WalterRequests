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

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("https://waltergpsconnecttest.azurewebsites.net/STS");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //This header tells that we want to be given json
        }


        /*HttpResponse<string> response = Unirest.get("https://microsoft-azure-translation-v1.p.rapidapi.com/translate?from=en&to=es&text=Hello%2C+world!")
              .header("X-RapidAPI-Host", "microsoft-azure-translation-v1.p.rapidapi.com")
              .header("X-RapidAPI-Key", "<YOUR_RAPID_API_KEY>")
              .header("Accept", "application/json")
              .asJson<string>();
          Console.WriteLine(response.Body.ToString()); */
    }
}