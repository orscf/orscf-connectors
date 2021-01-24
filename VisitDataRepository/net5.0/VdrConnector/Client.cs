using System.Net.Http;

namespace ORSCF.VisitData.RepositoryClient {

  public partial class Client {

    public Client(string baseUrl, string apiKey) {
      this.BaseUrl = baseUrl;
      _httpClient = new HttpClient();
      _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(this.CreateSerializerSettings);
      this.SetApiKey(apiKey);
    }

    public Client(string baseUrl, System.Net.Http.HttpClient httpClient, string apiKey) {
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
