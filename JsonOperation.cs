using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonParser
{
    // Classe Principale utilisée pour créer les requêtes json
    public class JsonOperation
    {
        public string AlternativeFlowMode { get; set; } = "OnNeed";
        public Drilling TaskInput { get; set; } = new Drilling();
    }
}



