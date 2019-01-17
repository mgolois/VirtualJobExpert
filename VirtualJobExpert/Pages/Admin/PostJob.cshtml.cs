using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using VirtualJobExpert.DataModels;

namespace VirtualJobExpert.Pages.Admin
{
    public class PostJobModel : PageModel
    {
        public List<JobCategory> Categories { get; set; }
        public List<JobStatus> Status { get; set; }
        public List<JobType> Types { get; set; }
        public List<Job> RecentJobs { get; set; }

        private readonly IJobDbContext dbContext;
        private IMemoryCache memoryCache;
        public PostJobModel(IJobDbContext ctx, IMemoryCache mCache)
        {
            dbContext = ctx;
            memoryCache = mCache;
        }
        public async Task OnGetAsync()
        {
            var cTask = dbContext.JobCategories.Where(c => c.Active).ToListAsync();
            var sTask = dbContext.JobStatus.Where(c => c.Active).ToListAsync();
            var tTask = dbContext.JobTypes.Where(c => c.Active).ToListAsync();
            var rjTask = dbContext.Jobs.OrderByDescending(j => j.UpdatedOn).Take(10).ToListAsync();
            await Task.WhenAll(cTask, sTask, tTask, rjTask);
            Categories = cTask.Result;
            Status = sTask.Result;
            Types = tTask.Result;
            RecentJobs = rjTask.Result;
        }

        public async Task<IActionResult> OnPostAsync(Job job)
        {
            job.UpdatedOn = DateTime.Now;
            dbContext.Jobs.Add(job);
            await dbContext.SaveChangesAsync();
            return RedirectToPage("/Admin/PostJob");
        }

        private void GetData()
        {
        }


    }

    public class Repository<T>
    {
        public Repository()
        {

        }
    }
}