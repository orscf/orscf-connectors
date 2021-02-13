using System.Net.Http;

namespace MedicalResearch.IdentityManagement {

  public partial class IdentityManagementApiClient {

    public IdentityManagementApiClient(string baseUrl, string apiKey) {
      this.BaseUrl = baseUrl;
      _httpClient = new HttpClient();
      _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(this.CreateSerializerSettings);
      this.SetApiKey(apiKey);
    }

    public IdentityManagementApiClient(string baseUrl, System.Net.Http.HttpClient httpClient, string apiKey) {
      this.BaseUrl = baseUrl;
      _httpClient = httpClient;
      _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(this.CreateSerializerSettings);
      this.SetApiKey(apiKey);
    }

    public void SetApiKey(string apiKey) {
      _httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
    }

  }

}
