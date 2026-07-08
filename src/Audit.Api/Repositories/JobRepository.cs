namespace Audit.Api.Repositories;

using System.Data.Common;
using Audit.Api.Models;

public class JobRepository : IJobRepository
{
    private readonly ILogger<JobRepository> _logger;

    public JobRepository(ILogger<JobRepository> logger)
    {
        _logger = logger;    
    }

    public async Task<Job> CreateAsync(Job job)
    {
        _logger.LogInformation("Creating job from {Source}", job.Source);
        return job;
        
    }

    public async Task<Job?> GetByIdAsync(Guid jobId)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Job job)
    {
        throw new NotImplementedException();
    }

}