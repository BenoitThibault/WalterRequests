using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonParser
{
    class JsonOperation
    {
        public string AlternativeFlowMode { get; set; } = "OnNeed";
        public Drilling TaskInput { get; set; } = new Drilling();
    }
}



