using JobBoardCRUD.DataAccess.Models;
using JobBoardCRUD.Domain.Abstractions;
using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using JobBoardCRUD.DataAccess.Models.Tables;

namespace JobBoardCRUD.DataAccess.Repositories
{
    public class JobCRUDRepository : IJobCRUD
    {
        private readonly MyDbContext _context;
        public JobCRUDRepository(MyDbContext context)
        {
            _context = context;
        }     

        public List<JobInfo> ListJobs()
        {
            List<JobInfo> jobs = new List<JobInfo>();


            jobs = (from j in _context.Job
                      where j.JobStatus == true
                      select new JobInfo()
                      { 
                        JobNumber = j.Id,
                        JobTitlePosition = j.JobTitle,
                        JobDescription = j.Description,
                        CreatedAt = j.CreatedAt,
                        ExpiresAt = j.ExpiresAt

                      }).ToList();
            
            return jobs;

            throw new NotImplementedException();
        }
        public JobInfo CreateJob(JobInfo jobInfo)
        {
            Job job = new Job()
            {
                JobTitle = jobInfo.JobTitlePosition,
                Description = jobInfo.JobDescription,
                CreatedAt = DateTime.Now,
                ExpiresAt = jobInfo.ExpiresAt
            };
            _context.Job.Add(job);
            _context.SaveChanges();
            jobInfo.CreatedAt = job.CreatedAt;
            jobInfo.JobNumber = job.Id;

            return jobInfo;
        }
        public JobInfo UpdateJob(JobInfo jobInfo)
        {
            Job jobFound = _context.Job.Where(c => c.Id == jobInfo.JobNumber).FirstOrDefault();
            if (jobFound != null)
            {
                jobFound.JobTitle = jobInfo.JobTitlePosition;
                jobFound.Description = jobInfo.JobDescription;
                jobFound.ExpiresAt = jobInfo.ExpiresAt;
                _context.SaveChanges();
            }
            return jobInfo;
        }
        public JobInfo DeleteJob(JobInfo jobInfo)
        {
            Job jobFound = _context.Job.Where(c => c.Id == jobInfo.JobNumber).FirstOrDefault();
            if (jobFound != null)
            {
                jobFound.JobStatus = false;
                _context.SaveChanges();
            }
            return jobInfo;
        }

    }
}
