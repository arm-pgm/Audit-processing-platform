namespace Audit.Api.Services;

public class AuditJobService : IAuditJobService
{
    public string CreateJob(string source)
    {
        return $"Created job from {source}";
    }
}