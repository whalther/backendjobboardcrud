using System;
using System.Collections.Generic;
using JobBoardCRUD.Application;
using JobBoardCRUD.DataAccess.Models;
using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace JobBoardCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCrudController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        private readonly MyDbContext _context;
        public JobCrudController(MyDbContext context, IConfiguration configuration) 
        {
            _context = context;
            Configuration = configuration;
        }
        [HttpGet]
        [Route("ListJobs")]
        public Result ListJobs()
        {
            Result result = new Result();
            try
            {
                JobCrudApp jobCrudApp = new JobCrudApp(_context);
                List<JobInfo> jobInfo = jobCrudApp.ListJobs();
                Dictionary<string, object> jobList = new Dictionary<string, object>();
                jobList.Add("jobs", jobInfo);
                result = new Result()
                {
                    status = "ok",
                    code = 200,
                    message = "Jobs",
                    data = jobList
                };
            }
            catch (Exception e)
            {

                result = new Result()
                {
                    status = "error",
                    code = 500,
                    message = e.InnerException.Message
                };
            }

            return result;
        }
        [HttpPost]
        [Route("CreateJob")]
        public Result CreateJob(JobInfo jobInfo)
        {
            Result result = new Result();
            try
            {

                JobCrudApp jobCrudApp = new JobCrudApp(_context);
                JobInfo jobInfoResult = jobCrudApp.CreateJob(jobInfo);
                Dictionary<string, object> jobData= new Dictionary<string, object>();
                jobData.Add("job", jobInfoResult);
                result = new Result()
                {
                    status = "ok",
                    code = 200,
                    message = "Created",
                    data = jobData
                };
            }
            catch (Exception e)
            {

                result = new Result()
                {
                    status = "error",
                    code = 500,
                    message = e.InnerException.Message
                };
            }

            return result;
        }
        [HttpPost]
        [Route("UpdateJob")]
        public Result UpdateJob(JobInfo jobInfo)
        {
            Result result = new Result();
            try
            {

                JobCrudApp jobCrudApp = new JobCrudApp(_context);
                JobInfo jobInfoResult = jobCrudApp.UpdateJob(jobInfo);
                Dictionary<string, object> jobData = new Dictionary<string, object>();
                jobData.Add("job", jobInfoResult);
                result = new Result()
                {
                    status = "ok",
                    code = 200,
                    message = "Updated",
                    data = jobData
                };
            }
            catch (Exception e)
            {

                result = new Result()
                {
                    status = "error",
                    code = 500,
                    message = e.InnerException.Message
                };
            }

            return result;
        }

        /// <summary>
        /// Deactivate a Job, just the ID(jobNumber) is required
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteJob")]
        public Result DeleteJob(JobInfo jobInfo)
        {
            Result result = new Result();
            try
            {

                JobCrudApp jobCrudApp = new JobCrudApp(_context);
                JobInfo jobInfoResult = jobCrudApp.DeleteJob(jobInfo);
                Dictionary<string, object> jobData = new Dictionary<string, object>();
                jobData.Add("job", jobInfoResult);
                result = new Result()
                {
                    status = "ok",
                    code = 200,
                    message = "Deleted",
                    data = jobData
                };
            }
            catch (Exception e)
            {

                result = new Result()
                {
                    status = "error",
                    code = 500,
                    message = e.InnerException.Message
                };
            }

            return result;
        }
    }
}
