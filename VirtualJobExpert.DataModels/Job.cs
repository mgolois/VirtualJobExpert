using System;

namespace VirtualJobExpert.DataModels
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int StatusId { get; set; }
        public JobStatus Status { get; set; }
        public int CategoryId { get; set; }
        public JobCategory Category { get; set; }
        public int TypeId { get; set; }
        public JobType Type { get; set; }
        public string CityState { get; set; }
        public string Zipcode { get; set; }
        public DateTime? PostedDate { get; set; }
        public string Salary { get; set; }
        public string Link { get; set; }
        public string WeeklyHours { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CompanyName { get; set; }
        public string CareerLevel { get; set; }
    }
}
