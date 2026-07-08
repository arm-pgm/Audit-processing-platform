namespace Audit.Api.Repositories;

using Audit.Api.Models;
public interface IJobRepository
{
    Task<Job> CreateAsync(Job job);
    Task<Job?> GetByIdAsync(Guid jobId);
    Task UpdateAsync(Job job);
}