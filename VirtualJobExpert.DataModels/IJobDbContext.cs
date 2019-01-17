using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace VirtualJobExpert.DataModels
{
    public interface IJobDbContext
    {
        DbSet<Job> Jobs { get; set; }
        DbSet<JobCategory> JobCategories { get; set; }
        DbSet<JobStatus> JobStatus { get; set; }
        DbSet<JobType> JobTypes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        int SaveChanges();
    }
}
