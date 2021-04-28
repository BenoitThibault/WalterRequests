using JsonParser;
using System.Collections.Generic;

class Operation
{
	public List<string> COOLANTSTYLE { get; set; } = new List<string> { "INT", "EXT", "DRY" }; //Coolant style
	public List<string> COOLANTTYPE { get; set; } = new List<string> { "EM5", "EM10", "AIR", "OIL", "MQL" }; //Type of the coolant, il y a aussi "DRY" sur la doc de l'API mais ça semble être une erreur
	public bool? UseDefaultValues { get; set; } //Use the defaults written in this document. C'est UseDefaults sur la doc mais apparemment c'est UseDefaultsValues qu'il faut utiliser
	public string UserName { get; set; } = "TestUser02";
	public bool? UseFirstResult { get; set; } //Use First Result
	public List<CuttingTools> CuttingTools { get; set; } = new List<CuttingTools>() { new CuttingTools() };//Array of tools specifying assembly to calculate
	public string? AssemblyName { get; set; } //User defined name of assembly
	public List<string>? Assemblies { get; set; } //Assemblies for calculations
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

	private string url = "http://ip-api.com/json";
	/*private string url = "https://waltergpsconnecttest.azurewebsites.net/sts/connect/token";
	private string client_id = "JanusFrance";
	private string client_secret = "i0JFfwoef2l7fwekf2498yfOnMi1";
	private string scope = "WalterGPSConnectScope";
	private string grant_type = "act-as";
	private string user_id = "Janususer";
	private string instance_id = "JanusInstance";
	private string token = getToken();

	public string getToken()
	{
		static HttpClient client = new HttpClient();
	}*/


	/** Renvoie la réponse de l'API grâce au json rentré en paramètre,
	* Si le site renvoie une erreur, on lance une exception.
	* @params json Json à évaluer
	* @returns jsonResponse json récupéré de Walter
	*/
	/*public string getResultFromAPI(string json)
	{

		if(json_issues_data.status_code == 404) //Repris du python
			throw new HttpException(404, "Page you requested is not found");
			jsonResponse = json.GetResponse();
		HttpWebResponse errorResponse = we.Response as HttpWebResponse;
		if (errorResponse.StatusCode == HttpStatusCode.NotFound) {

		}

		//Si la syntaxe du json n'est pas bonne, on renvoie une exception.
		if(jsonResponse != "good")
			throw new SyntaxErrorException("json or json parameters unauthorized!");

		return jsonResponse;



		}
	}*/
}