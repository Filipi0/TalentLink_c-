namespace talentlink.Services
{
    public class ApiConfiguration
    {
        public string BaseUrl { get; set; } = string.Empty;
    }

    public class ApiService
    {
        private readonly ApiConfiguration _config;

        public ApiService(IConfiguration configuration)
        {
            _config = configuration.GetSection("TalentLinkApi").Get<ApiConfiguration>() ?? new ApiConfiguration();
        }

        public string GetBaseUrl()
        {
            return _config.BaseUrl;
        }

        public string GetAuthUrl(string userType)
        {
            return $"{_config.BaseUrl}/auth/google/{userType}";
        }

        public string GetLogoutUrl()
        {
            return $"{_config.BaseUrl}/auth/logout";
        }
    }
}
