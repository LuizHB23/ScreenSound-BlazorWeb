using System.Net.Http.Json;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Service;

public class ArtistaAPI
{
    private readonly HttpClient _httpClient;

    public ArtistaAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<ArtistaResponse>?> GetArtistaResponsesAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<ArtistaResponse>>("http://localhost:5241/Artistas");
    }
}