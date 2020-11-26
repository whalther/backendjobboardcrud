using JobBoardCRUD.Domain.Abstractions;
using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoardCRUD.Domain.Services
{
    public class JobCRUDService
    {
        public List<JobInfo> ListJobs(IJobCRUD jobCRUDRepo)
        {
            return jobCRUDRepo.ListJobs();
        }
        public JobInfo CreateJob(IJobCRUD jobCRUDRepo, JobInfo jobInfo)
        {
            return jobCRUDRepo.CreateJob(jobInfo);
        }
        public JobInfo UpdateJob(IJobCRUD jobCRUDRepo, JobInfo jobInfo)
        {
            return jobCRUDRepo.UpdateJob(jobInfo);
        }
        public JobInfo DeleteJob(IJobCRUD jobCRUDRepo, JobInfo jobInfo)
        {
            return jobCRUDRepo.DeleteJob(jobInfo);
        }
    }
}
