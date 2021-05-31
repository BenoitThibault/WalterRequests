using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonParser
{
    // Paramètres uniques à la Classe Drilling
    public class Drilling : Operation
    {
        [JsonIgnore]
        public string operationTypeName = "GetCuttingDataForHoleOnSolidMaterial"; //Nom pour Drilling
        public bool BHFP { get; set; } = true; //Blind hole
        public bool? CHFP { get; set; } //Cross hole
        public double DEPTHMF { get; set; } = 10.0; //Depth
        public double DM { get; set; } = 10.0; //Diameter
        public double? DTOLU { get; set; } //Upper tolerance
        public double? DTOLL { get; set; } //Lower tolerance
        public string FIX { get; set; } = "ExcellentStability"; //Fixturing
        public bool? IENFP { get; set; } //inclined entry angle
        public bool? IEXFP { get; set; } //inclined exit function
        public string TCHA { get; set; } //Tolérance class
        public bool? THFP { get; set; } //Through hole
        public bool? SMFP { get; set; } //Stacked?
        public int? PHDN { get; set; } //Pre hole min diameter
        public int? PHDX { get; set; } //Pre hole max diamater
    }
}