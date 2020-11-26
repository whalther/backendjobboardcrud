using JobBoardCRUD.DataAccess.Models;
using JobBoardCRUD.DataAccess.Repositories;
using JobBoardCRUD.Domain.Abstractions;
using JobBoardCRUD.Domain.Services;
using JobBoardCRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoardCRUD.Application
{
    public class JobCrudApp
    {
        private MyDbContext _context;
        public JobCrudApp(MyDbContext context)
        {
            _context = context;
        }
        public List<JobInfo> ListJobs()
        {
            IJobCRUD jobRepo = new JobCRUDRepository(_context);
            JobCRUDService jobService = new JobCRUDService();
            
            return jobService.ListJobs(jobRepo);
        }
        public JobInfo CreateJob(JobInfo jobInfo)
        {
            IJobCRUD jobRepo = new JobCRUDRepository(_context);
            JobCRUDService jobService = new JobCRUDService();

            return jobService.CreateJob(jobRepo, jobInfo);
        }
        public JobInfo UpdateJob(JobInfo jobInfo)
        {
            IJobCRUD jobRepo = new JobCRUDRepository(_context);
            JobCRUDService jobService = new JobCRUDService();

            return jobService.UpdateJob(jobRepo, jobInfo);
        }
    }
}
