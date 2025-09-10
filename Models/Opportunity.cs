namespace talentlink.Models
{
    public class Opportunity
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public string Benefits { get; set; } = string.Empty;
        public string SalaryRange { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string CompanyId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class SearchRequest
    {
        public string? Query { get; set; }
        public string? Location { get; set; }
        public string? SalaryRange { get; set; }
    }

    public class ApiError
    {
        public string Message { get; set; } = string.Empty;
        public int StatusCode { get; set; }
    }
}
