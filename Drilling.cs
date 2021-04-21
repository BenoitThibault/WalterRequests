using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonParser
{
    class Drilling : Operation
    {
        public bool BHFP { get; set; } = true; //Blind hole
        public bool CHFP { get; set; } = false; //Cross hole
        public double DEPTHMF { get; set; } = 0.0; //Depth
        public double DM { get; set; } = 0.0; //Diameter
        public double DTOLU { get; set; } //Upper tolerance
        public double DTOLL { get; set; } //Lower tolerance
        public string FIX { get; set; } = "GoodStability"; //Fixturing
        public bool IENFP { get; set; } = false; //inclined entry angle
        public bool IEXFP { get; set; } = false; //inclined exit function
        public string TCHA { get; set; } //Tolérance class
        public bool THFP { get; set; } = false; //Through hole
        public bool SMFP { get; set; } = false; //Stacked?
        public int PHDN { get; set; } //Pre hole min diameter
        public int PHDX { get; set; } //Pre hole max diamater



        /** Crée un json tel que dans Walter à partir des informations de l'instance */
        /*   public string convertToJson()
           {
               string json = @"{
               'UseDefaults': UseDefaults,
               'AlternativeFlowMode': "OnNeed",
               'TaskInput' = new List<
               if (PHDR != null) "PHDR" + ':' + PHDR,
                   if (PHDN != null) "PHDN:" + ':' + PHDN,
               if (PHDX != null) "PHDX:" + ':' + PHDX,
               if (PHDNTOL != null) "PHDNTOL:" + ':' + PHDNTOL,
               if (PHDXTOL != null) "PHDXTOL:" + ':' + PHDXTOL,
               if (MaterialID != null)
               {
                   'MaterialID:' MaterialID
                   foreach (item in MaterialID)
                   {
                       nameof(item) + ':' item,
                   }
               }

               if (MaterialData != null)
               {
                   'MaterialID:' MaterialData
                   foreach (item in MaterialData)
                   {
                       nameof(item) + ':' item,
                   }
               }
               if (MachineID != null) 'MachineID:' MachineID,
               if (CuttingTools != null)
               {
                   'CuttingTools:' CuttingTools
               foreach (item in CuttingTools)
                   {
                       nameof(item) + ':' + item
               }
               }

               'COOLANTSTYLE' : '['
                   foreach (item in COOLANTSTYLE)
               {
                   nameof(item) + ':' + item
           }
               ']'


               'COOLANTTYPE' : '['
                   foreach (item in COOLANTTYPE)
               {
                   nameof(item) + ':' + item
           }
               ']'


               'FIX:' FIX,
               'UseFirstResult:' UseFirstResult,
               if (SpecialToolsAllowed != null) 'SpecialToolsAllowed:' SpecialToolsAllowed,
               if (RecommendAdditionalAssemblyItem != null) 'RecommendAdditionalAssemblyItem:' RecommendAdditionalAssemblyItem,
               'EnableSendToButton:' EnableSendToButton
               if (PreselectedItemMaximumRank != null) 'PreselectedItemMaximumRank:' PreselectedItemMaximumRank,
               if (AssembledItemMaximumRank != null) 'AssembledItemMaximumRank:' AssembledItemMaximumRank,
               'UNITSYSTEM:' { UnitSystem },
               'LANGUAGE:' { Language },
               'UserName:' { UserName }, //variable non initialisées, "TestUser02" sur Walter
               'UseDefaultValues:' { UseDefaultValues} //variable non initialisée, "true" sur Walter
               if (CountryCode != null) 'CountryCode:' { CountryCode },
               'BHFP:' { BHFP },
               'CHFP:' { CHFP },
               'DEPTHMF:' { DEPTHMF },
               'DM:' { DM },
               if (DTOLU != null) 'DTOLU:' DTOLU,
               if (DTOLL != null) 'DTOLL:' DTOLL,
               'IENFP:' IENFP,
               if (TCHA != null) 'TCHA:' TCHA,
               'SMFP:' SMFP

               ']'


       }";

           jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
           return jsonString;


           Drilling drilling = new Drilling()
               {
                   UseDefaults = true,
                   AlternativeFlowMode = true,
                   // Try to get a succeed request with all the parameters if possible.
                   TaskInput = new List<object>
                   {
                       PHDR = 5,
                       // PHDN = 5, se trouve en bas dans la liste
                       // PHDX = 5, pareil
                       PHDNTOL = 5,
                       PHDXTOL = 5,
                       MaterialID = new List<object>
                       {
                           MaterialId = "Werkstoffnummer DIN#401#P2.3.Z.AN#HRDHB#240",
                           HardnessScale = "HRDHRC",
                           Hardness = 5.0
                       },

                       MaterialData = new List<object>
                       {
                           MaterialName = "",
                           MaterialStandard = "5",
                           HardnessScale = "",
                           Hardness = 5.0
                       },

                       MachineId = "machine_cc_DefaultallCoolants",
                       CuttingTools = new List<string>
                       {
                           Brand = "TIX",
                           OrderCode = "DC170-03-10.000A1-WJ30EJ"
                       },
                       CoolantStyle = new List<bool>
                       {
                           INT = true,
                           EXT = true,
                           DRY = true
                       },

                       CoolantType = new List<bool>
                       {
                           AIR = true,
                           OIL = true,
                           EM5 = true,
                           EM10 = true,
                           MQL = true
                       },


                       RecommendAdditionalAssemblyItems = true,
                       EnableSendToButton = true,
                       PreselectedItemMaximumRank = 3,
                       AssembledItemMaximumRank = 1,
                       UNITSYSTEM = "Metric",
                       LANGUAGE = "en-US",
                       UserName = "TestUser02",
                       UseDefaultValues = true,
                       CountryCode = 5,

                       BHFP = true, //Hope type: Blind hole
                       CHFP = true; // Cross hole
                       DEPTHMF = 4.0, //Profondeur
                       DM = 10.0, //Diamètre
                       DTOLU = 3.0, //Upper tolerance
                       DTOLL = 2.0, //Lower tolerance
                       FIX = "ExcellentStability",
                       IENFP = true, //Inclined entry angle
                       IEXFP = true, //Inclined exit function
                       TCHA = "5", //Tolérance class
                       THFP = true; //Hole type: Through hole
                       SMFP = true, //Stacked
                       PHDN = 5, //Pre hole min diameter
                       PHDX = 5, //Pre hole max diameter

                   },  
               };

               var dictionary = JsonConvert.DesializeObject<IDictionary>(json)
               foreach(DictionaryEntry entry in dictionary)
               {
                   Console.WriteLine(entry.Key + ": " + entry.Value);
               }

               Console.WriteLine(drilling.convertToJson());*/
    }
}