using JobBoardCRUD.Domain.Abstractions;
using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoardCRUD.DataAccess.Test.MockRepositories
{
    public class JobCRUDRepositoryMock : IJobCRUD
    {
        public JobInfo CreateJob(JobInfo jobInfo)
        {
            return jobInfo;
        }

        public JobInfo DeleteJob(JobInfo jobInfo)
        {
            return jobInfo;
        }

        public List<JobInfo> ListJobs()
        {
            List<JobInfo> jobs = new List<JobInfo>();
            jobs.Add(new JobInfo()
            {
                JobNumber = 1,
                JobTitlePosition = "Data Scientist",
                JobDescription = "A data scientist is a professional responsible for collecting, analyzing and interpreting extremely large amounts of data.",
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(3)
            });
            jobs.Add(new JobInfo()
            {
                JobNumber = 2,
                JobTitlePosition = "Software Developer",
                JobDescription = "A software developer is a company or person that creates software - either completely, or with other companies or people.",
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(3)
            });
            jobs.Add(new JobInfo()
            {
                JobNumber = 3,
                JobTitlePosition = " Information Security Analyst",
                JobDescription = "Information security analysts design and implement security measures to protect an organization's computer networks and systems.",
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(3)
            });
            return jobs;
        }

        public JobInfo UpdateJob(JobInfo jobInfo)
        {
            return jobInfo;
        }
    }
}
