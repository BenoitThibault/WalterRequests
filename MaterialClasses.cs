using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonParser
{
    class MaterialData
    {
        public string MaterialName { get; set; }
        public string MaterialStandard { get; set; }
        public string HardnessScale { get; set; }
        public double Hardness { get; set; }
    }

    class MaterialID
    {
        public string MaterialId { get; set; }
        public string HardnessScale { get; set; }
        public double Hardness { get; set; }
    }

    class CuttingTools
    {
        public string Brand { get; set; } = "TIX";
        public string OrderCode { get; set; } = "DC170-03-10.000A1-WJ30EJ";
    }
}