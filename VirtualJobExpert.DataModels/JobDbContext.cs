using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VirtualJobExpert.DataModels
{
    public class JobDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobStatus> JobStatus { get; set; }
        public DbSet<JobType> JobTypes { get; set; }

        public JobDbContext(DbContextOptions option, IHostingEnvironment env) : base(option)
        {
            if (!env.IsDevelopment())
            {  
                var conn = (SqlConnection)Database.GetDbConnection();
                conn.AccessToken = new AzureServiceTokenProvider().GetAccessTokenAsync("https://database.windows.net/").Result;
            }    
        }

    }
}

