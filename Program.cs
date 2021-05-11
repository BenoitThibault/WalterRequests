using JsonParser;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Test de création d'un json avec les paramètres par défaut et de récupération des données grâce à l'API et utiliser ces données  //
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            JsonOperation jsonOperationTest = new JsonOperation();
            string jsonString = JsonConvert.SerializeObject(jsonOperationTest, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Console.WriteLine(jsonString); //Affiche le json qu'on souhaite envoyé à l'API

            string operationTypeName = "GetCuttingDataForHoleOnSolidMaterial"; //Pour Drilling
            string url = "http://WalterGPSConnectTest.azurewebsites.net/WGCApi/V1.0/" + operationTypeName;
            var response = Walter.ApiHelper.GetResponse(jsonString, url); //Envoie le json construit et retourne le json.
            Console.WriteLine(response.Content); //Affiche le json retourné

            var jsonTruc = JsonConvert.DeserializeObject<JToken>(response.Content);
            string jsonDeTest = JsonConvert.SerializeObject(jsonTruc, Formatting.Indented);
            Console.WriteLine(jsonDeTest); //Affiche le json retourné après l'indentation

            Console.WriteLine("");

            var jObject = JObject.Parse(response.Content);
            Console.WriteLine(jObject["TaskOutput"]["Results"][0]["Vc"]); //On récupère la vitesse de coupe à partir des données du json retourné

            Console.WriteLine("");

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Test du renvoie de l'url pour ouvrir la page en cas du renvoie d'une erreur par l'API //
            ///////////////////////////////////////////////////////////////////////////////////////////
            //SelectMaterialInGPS materialInGPS = new SelectMaterialInGPS();
            //jsonString = JsonConvert.SerializeObject(materialInGPS, Formatting.Indented);

            url = "https://WalterGPSConnectTest.azurewebsites.net/WGCApi/V1.0/SelectMaterialInGPS";
            response = Walter.ApiHelper.GetResponse(jsonString, url);
            Console.WriteLine(response.Content);

            jObject = JObject.Parse(response.Content);
            //string target = "https://waltergpsconnecttest.azurewebsites.net/touchtime/Walter?UserID=TestUser02&TibpID=" + jsonOperation.TaskInput.UserName + "&Language=" + jsonOperation.TaskInput.LANGUAGE + "&UnitSystem=" + jsonOperation.TaskInput.UNITSYSTEM + "&Origin=*&EnableSolutionDetailOnly=false&SiteCountryCode=DE&WgaSendToButtonSetting=#/ars/parameters?isInitialReview=false";
            string correlationId = jObject.GetValue("CorrelationId").ToString();
            
            string target = "https://waltergpsconnecttest.azurewebsites.net/touchtime/Walter?CorrelationId=" + correlationId + "&Origin=*";
            Console.WriteLine(target);
            System.Diagnostics.Process.Start(@target);

            Console.WriteLine("");


            /////////////////////////////////////////////////////////////////
            // Test de création du json avec tous les paramètres possibles //
            /////////////////////////////////////////////////////////////////
            JsonOperation jsonOperation = new JsonOperation()
            {
                AlternativeFlowMode = "OnNeed",
                TaskInput = new Drilling()
                {
                    UseDefaultValues = true,
                    // Try to get a succeed request with all the parameters if possible.


                    PHDR = 5,
                    PHDNTOL = 5,
                    PHDXTOL = 5,
                    MachineID = "machine_cc_DefaultallCoolants",

                    RecommendAdditionalAssemblyItems = true,
                    EnableSendToButton = true,
                    PreselectedItemMaximumRank = 3,
                    AssembledItemMaximumRank = 1,
                    UNITSYSTEM = "Metric",
                    LANGUAGE = "en-US",
                    UserName = "TestUser02",
                    CountryCode = "fr",

                    BHFP = true, //Hope type: Blind hole
                    CHFP = true, // Cross hole
                    DEPTHMF = 4.0, //Profondeur
                    DM = 10.0, //Diamètre
                    DTOLU = 3.0, //Upper tolerance
                    DTOLL = 2.0, //Lower tolerance
                    FIX = "ExcellentStability",
                    IENFP = true, //Inclined entry angle
                    IEXFP = true, //Inclined exit function
                    TCHA = "5", //Tolérance class
                    THFP = true, //Hole type: Through hole
                    SMFP = true, //Stacked
                    PHDN = 5, //Pre hole min diameter
                    PHDX = 5, //Pre hole max diameter

                    MaterialID = new MaterialID()
                    {
                        MaterialId = "Werkstoffnummer DIN#401#P2.3.Z.AN#HRDHB#240",
                        HardnessScale = "HRDHRC",
                        Hardness = 5.0
                    },

                    MaterialData = new MaterialData()
                    {
                        MaterialName = "",
                        MaterialStandard = "5",
                        HardnessScale = "",
                        Hardness = 5.0
                    },

                    CuttingTools = new List<CuttingTools>
                    {
                        new CuttingTools
                        {
                            Brand = "TIX",
                            OrderCode = "DC170-03-10.000A1-WJ30EJ"
                        }
                    },

                    COOLANTSTYLE = new List<string>
                    {
                        "INT",
                        "EXT",
                        "DRY"
                    },

                    COOLANTTYPE = new List<string>
                    {
                        "AIR",
                        "OIL",
                        "EM5",
                        "EM10",
                        "MQL"
                    }
                }
            };

            jsonString = JsonConvert.SerializeObject(jsonOperation, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Console.WriteLine(jsonString); //Affiche le json construit sous forme indentée.

            Console.ReadLine();
        }
    }
 }
