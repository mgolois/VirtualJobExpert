using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VirtualJobExpert.DataModels;

namespace VirtualJobExpert.Pages
{
    public class IndexModel : PageModel
    {
        private readonly JobDbContext dbContext;
        public List<JobCategory> JobCategories { get; set; }
        public List<Job> ActiveJobs { get; set; }
        public IndexModel(JobDbContext jobDbContext)
        {
            dbContext = jobDbContext;
            var d = dbContext.Database.GetDbConnection();
        }
        public void OnGet()
        {
            ActiveJobs = dbContext.Jobs.Include(j=> j.Category).Where(c => c.StatusId == 1).ToList();
            JobCategories = ActiveJobs.GroupBy(j => j.Category).OrderByDescending(c => c.Count()).Take(8).Select(c=> c.Key).ToList();
        }
    }
}
