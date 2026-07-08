namespace Audit.Api.Models;

public class Job
{
        public Guid JobID {get; set;}
        public Guid CorrelationID {get; set;}
        public JobStatus Status {get; set;}
        public string? Source {get; set;}
        public DateTime CreatedUtc {get; set;}
        public DateTime UpdatedUtc {get; set;}
}