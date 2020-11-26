using JobBoardCRUD.DataAccess.Models;
using JobBoardCRUD.Domain.Abstractions;
using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JobBoardCRUD.DataAccess.Repositories
{
    public class JobCRUDRepository : IJobCRUD
    {
        private readonly MyDbContext _context;
        public JobCRUDRepository(MyDbContext context)
        {
            _context = context;
        }
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


            jobs = (from j in _context.Job
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

        public JobInfo UpdateJob(JobInfo jobInfo)
        {
            return jobInfo;
        }
    }
}
