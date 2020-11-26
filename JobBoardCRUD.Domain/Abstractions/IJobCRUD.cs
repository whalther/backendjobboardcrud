using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoardCRUD.Domain.Abstractions
{
    public interface IJobCRUD
    {
        List<JobInfo> ListJobs();
        JobInfo CreateJob(JobInfo jobInfo);
        JobInfo UpdateJob(JobInfo jobInfo);
        JobInfo DeleteJob(JobInfo jobInfo);
    }
}
