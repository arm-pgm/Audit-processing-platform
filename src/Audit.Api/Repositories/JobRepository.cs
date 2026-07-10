namespace Audit.Api.Repositories;

using System.Data.Common;
using Audit.Api.Data;
using Audit.Api.Models;
using Microsoft.EntityFrameworkCore;

public class JobRepository : IJobRepository
{
    private readonly ILogger<JobRepository> _logger;
    private readonly AuditDbContext _db;

    public JobRepository(ILogger<JobRepository> logger, AuditDbContext auditDb)
    {
        _logger = logger;    
        _db = auditDb;
    }

    public async Task<Job> CreateAsync(Job job)
    {
        job.JobID = Guid.NewGuid();
        job.CorrelationID = Guid.NewGuid();
        job.CreatedUtc = DateTime.UtcNow;
        job.UpdatedUtc = DateTime.UtcNow;
        job.Status = JobStatus.NotStarted;

        await _db.Jobs.AddAsync(job);
        await _db.SaveChangesAsync();
        
        _logger.LogInformation("Creating job {JobId} from {Source}", job.JobID,job.Source);
        
        return job;
        
    }

    public async Task<Job?> GetByIdAsync(Guid jobId)
    {
        return await _db.Jobs.FindAsync(jobId);
        // technically both of these work but if the create or update happens in the context we can skip the roundtrip to sqlite to find job, track, and add to context.
        //return await _db.Jobs.FirstOrDefaultAsync(job => job.JobID == jobId);
    }

    public async Task UpdateAsync(Job job)
    {
        job.UpdatedUtc = DateTime.UtcNow;
        await _db.SaveChangesAsync();
    }

}