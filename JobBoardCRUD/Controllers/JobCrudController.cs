﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardCRUD.Application;
using JobBoardCRUD.DataAccess.Models;
using JobBoardCRUD.Models.Entities;
using JobBoardCRUD.Models.Generics;
using Microsoft.AspNetCore.Http;
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
        [Route("Jobs")]
        public Result Jobs()
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
    }
}
