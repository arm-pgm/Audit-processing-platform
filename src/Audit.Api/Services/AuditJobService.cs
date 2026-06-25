namespace Audit.Api.Services;

public class AuditJobService : IAuditJobService
{ 
    private readonly ILogger<AuditJobService> _logger;
    public AuditJobService(ILogger<AuditJobService> logger)
    {
        _logger = logger;    
    }

    public string CreateJob(string source)
    {
        _logger.LogInformation("Creating job from {Source}", source);
        return $"Created job from {source}";
    }
}