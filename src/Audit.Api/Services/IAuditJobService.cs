namespace Audit.Api.Services;

public interface IAuditJobService
{
    string CreateJob(string source);
}