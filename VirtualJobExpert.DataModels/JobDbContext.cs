using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualJobExpert.DataModels
{
    public class JobDbContext: DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobStatus> JobStatus { get; set; }
        public DbSet<JobType> JobTypes { get; set; }

        public JobDbContext(DbContextOptions option):base(option)
        {
           
        }

    }
}
