using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonParser
{
    public class MaterialData
    {
        public string MaterialName { get; set; } = "";
        public string MaterialStandard { get; set; } = "";
        public string HardnessScale { get; set; } = "";
        public double? Hardness { get; set; }
    }

    public class MaterialID
    {
        public string MaterialId { get; set; } = "1.2826#Werkstoffnummer DIN#401#P2.3.Z.AN#HRDHB#240";
        public string HardnessScale { get; set; }
        public double? Hardness { get; set; }
    }

    public class CuttingTools
    {
        public string Brand { get; set; } = "TIX";
        public string OrderCode { get; set; } = "DC170-03-10.000A1-WJ30EJ";
    }

    public class TaskOutput
    {
        public string COOLANTSTYLE { get; set; }
    }
}