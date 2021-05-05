using JsonParser;
using System.Collections.Generic;

public class Operation
{
	public List<string> COOLANTSTYLE { get; set; } = new List<string> { "INT", "EXT", "DRY" }; //Coolant style
	public List<string> COOLANTTYPE { get; set; } = new List<string> { "EM5", "EM10", "AIR", "OIL", "MQL" }; //Type of the coolant, il y a aussi "DRY" sur la doc de l'API mais ça semble être une erreur
	public bool? UseDefaultValues { get; set; } //Use the defaults written in this document. C'est UseDefaults sur la doc mais apparemment c'est UseDefaultsValues qu'il faut utiliser
	public string UserName { get; set; } = "TestUser02";
	public bool? UseFirstResult { get; set; } //Use First Result
	public List<CuttingTools> CuttingTools { get; set; } = new List<CuttingTools>() { new CuttingTools() };//Array of tools specifying assembly to calculate
	public string AssemblyName { get; set; } = null; //User defined name of assembly
	public List<string> Assemblies { get; set; } = null; //Assemblies for calculations
	public int? LongProcessingFilterId { get; set; } //Long Processing Filter Id
	public bool? CalculateWithAssembliesPrices { get; set; } //Calculate with Assemblies Prices
	public bool RecommendAdditionalAssemblyItems { get; set; } = true; //Recommend Additional Assembly Items
	public string LANGUAGE { get; set; } = "fr-FR"; //Language, set to fr-FR for french
	public string CountryCode { get; set; } = "DE"; //Country Code
	public string UNITSYSTEM { get; set; } = "Metric"; //Metric or Imperial unit system of API
	public string UnitSystemOnAlternativeFlow { get; set; } //Metric or Imperial unit system for user.
	public string MachineID { get; set; } = "machine_cc_DefaultallCoolants";//MachineID
	public string UseMachineJSON { get; set; } //Machine JSON specification
	public MaterialID MaterialID { get; set; } = new MaterialID();//Walter GPS Material ID with optional Hardness Scale and Hardness value.
	public MaterialData MaterialData { get; set; } = new MaterialData(); //Material Data (Hardness, Scale, Name and Hardness value)
	public bool? AlternativeFlowShowResultsDirectly { get; set; } //Show Results Directly
	public bool? AlternativeFlowDisableMaterialTab { get; set; } //Disable Material Tab
	public bool? DisableMachineTab { get; set; } //Disable Machine Tab
	public bool? DisableProperties { get; set; } //Disable Properties Tab
	public bool EnableSendToButton { get; set; } = true;
	public int PreselectedItemMaximumRank { get; set; } = 3; //Preselected Item Maximum Rank
	public int AssembledItemMaximumRank { get; set; } = 1; //Assembled item Maximum Rank
	public string Filters { get; set; } //Filters
	public bool? SpecialToolsAllowed { get; set; } //Special Tools Allowed

	public int? PHDR { get; set; }
	public int? PHDNTOL { get; set; }
	public int? PHDXTOL { get; set; }
}