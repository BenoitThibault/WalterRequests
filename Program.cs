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
            JsonOperation jsonOperationTest = new JsonOperation();
            string jsonString = JsonConvert.SerializeObject(jsonOperationTest, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Console.WriteLine(jsonString);

            JsonOperation jsonOperation = new JsonOperation()
            {
                AlternativeFlowMode = "OnNeed",
                TaskInput = new Drilling()
                {
                    UseDefaultValues = true,
                    // Try to get a succeed request with all the parameters if possible.


                    PHDR = 5,
                    // PHDN = 5, se trouve en bas dans la liste
                    // PHDX = 5, pareil
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
            Console.WriteLine(jsonString);

            var response = Walter.ApiHelper.GetResponse(jsonOperation);
            // Parsing JSON content into element-node JObject
            var jObject = JObject.Parse(response.Content);
            Console.WriteLine(response);

            //Extracting Node element using Getvalue method
            JsonParser.TaskOutput taskOutput = jObject.GetValue("TaskOutput").ToObject<JsonParser.TaskOutput>;

            Console.WriteLine(taskOutput.COOLANTSTYLE);
            
            /*
            try
            {
                Task<string> request = Walter.WalterProcessor.DisplayRequest();
                jsonString = request.Result; //convertToJson(request);
                Console.WriteLine(jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            } */
        }        
    }
 }
