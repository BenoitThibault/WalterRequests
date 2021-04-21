using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonParser
{
    public class Utilisateur
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Age { get; set; }

        public DateTime DateCreation { get; set; }

        public string Role { get; set; }

        public List<string> ListeDeStrings { get; set; }

        public Utilisateur()
        {

        }
    }
}