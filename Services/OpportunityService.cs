using System.Text;
using System.Text.Json;
using talentlink.Models;

namespace talentlink.Services
{
    public class OpportunityService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiService _apiService;
        private readonly ILogger<OpportunityService> _logger;

        public OpportunityService(HttpClient httpClient, ApiService apiService, ILogger<OpportunityService> logger)
        {
            _httpClient = httpClient;
            _apiService = apiService;
            _logger = logger;
        }

        /// <summary>
        /// Lista todas as oportunidades ativas
        /// </summary>
        public async Task<List<Opportunity>> GetAllOpportunitiesAsync(string token)
        {
            try
            {
                var baseUrl = _apiService.GetBaseUrl();
                var url = $"{baseUrl}/opportunities";

                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                _logger.LogInformation($"🔍 Buscando oportunidades em: {url}");

                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation($"✅ Oportunidades recebidas: {json.Length} caracteres");

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    var opportunities = JsonSerializer.Deserialize<List<Opportunity>>(json, options) ?? new List<Opportunity>();
                    _logger.LogInformation($"✅ {opportunities.Count} oportunidades deserializadas");

                    return opportunities;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    _logger.LogWarning("❌ Token inválido ou expirado");
                    throw new UnauthorizedAccessException("Token inválido ou expirado");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"❌ Erro na API: {response.StatusCode} - {errorContent}");
                    throw new HttpRequestException($"Erro na API: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "❌ Erro ao buscar oportunidades");
                throw;
            }
        }

        /// <summary>
        /// Busca oportunidades por critérios específicos
        /// </summary>
        public async Task<List<Opportunity>> SearchOpportunitiesAsync(string token, SearchRequest searchRequest)
        {
            try
            {
                var baseUrl = _apiService.GetBaseUrl();
                var url = $"{baseUrl}/opportunities/search";

                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var json = JsonSerializer.Serialize(searchRequest, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                _logger.LogInformation($"🔍 Buscando oportunidades com filtros: {json}");

                var response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation($"✅ Resultados da busca: {responseJson.Length} caracteres");

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    var opportunities = JsonSerializer.Deserialize<List<Opportunity>>(responseJson, options) ?? new List<Opportunity>();
                    _logger.LogInformation($"✅ {opportunities.Count} oportunidades encontradas");

                    return opportunities;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    _logger.LogWarning("❌ Token inválido ou expirado");
                    throw new UnauthorizedAccessException("Token inválido ou expirado");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"❌ Erro na busca: {response.StatusCode} - {errorContent}");
                    throw new HttpRequestException($"Erro na busca: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "❌ Erro ao buscar oportunidades");
                throw;
            }
        }
    }
}
