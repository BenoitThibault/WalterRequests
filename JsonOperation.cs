using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonParser
{
    // Classe Principale utilis�e pour cr�er les requ�tes json
    public class JsonOperation
    {
        public string AlternativeFlowMode { get; set; } = "OnNeed";
        public Drilling TaskInput { get; set; } = new Drilling();
    }
}



