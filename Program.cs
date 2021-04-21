﻿using JsonParser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var utilisateur = new Utilisateur
            {
                Nom = "Thibault",
                Prenom = "Benoit",
                Age = 19,
                DateCreation = DateTime.Now,
                Role = "Developpeur",
                ListeDeStrings = new List<string>
                {
                    "test numéro 2",
                    "test numéro 4"
                }
            };
            string jsonString = JsonConvert.SerializeObject(utilisateur, Formatting.Indented);
            Console.WriteLine(jsonString);

            Drilling drillingTest = new Drilling();
            jsonString = JsonConvert.SerializeObject(drillingTest, Formatting.Indented);
            Console.WriteLine(jsonString);

            Drilling drilling = new Drilling()
            {
                UseDefaults = true,
                AlternativeFlowMode = "OnNeed",
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
                UnitSystem = "Metric",
                Language = "en-US",
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
                    Hardness = 5.0,
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
               
                CoolantStyle = new List<string>
                {
                    "INT",
                    "EXT",
                    "DRY"
                },

                CoolantType = new List<string>
                {
                    "AIR",
                    "OIL",
                    "EM5",
                    "EM10",
                    "MQL"
                }
            };

            jsonString = JsonConvert.SerializeObject(drilling, Formatting.Indented);
            Console.WriteLine(jsonString);

            Walter.ApiHelper.InitializeClient();
            try
            {
                Task<string> request = Walter.WalterProcessor.displayRequest();
                jsonString = request.Result; //convertToJson(request);
                Console.WriteLine(jsonString);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}