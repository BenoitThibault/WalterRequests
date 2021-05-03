using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonParser
{
    public class JsonOperation
    {
        public string AlternativeFlowMode { get; set; } = "OnNeed";
        public Drilling TaskInput { get; set; } = new Drilling();
    }
}



