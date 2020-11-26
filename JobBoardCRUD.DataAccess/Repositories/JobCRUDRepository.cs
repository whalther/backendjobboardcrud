using JobBoardCRUD.Domain.Abstractions;
using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoardCRUD.DataAccess.Repositories
{
    public class JobRepository : IJobCRUD
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
            throw new NotImplementedException();
        }

        public JobInfo UpdateJob(JobInfo jobInfo)
        {
            return jobInfo;
        }
    }
}
