using JobBoardCRUD.DataAccess.Test.MockRepositories;
using JobBoardCRUD.Domain.Abstractions;
using JobBoardCRUD.Domain.Services;
using JobBoardCRUD.Models.Entities;
using System;
using Xunit;

namespace JobBoardCRUD.DataAccess.Test
{
    public class JobCRUDMockTest
    {
        [Fact]
        public void ListJobsMockTest()
        {
            //Arrange
            IJobCRUD jobRepo = new JobCRUDRepositoryMock();
            JobCRUDService jobService = new JobCRUDService();
            //Act
            var result = jobService.ListJobs(jobRepo);
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void CreateJobMockTest()
        {
            //Arrange
            IJobCRUD jobRepo = new JobCRUDRepositoryMock();
            JobCRUDService jobService = new JobCRUDService();
            JobInfo jobInfo = new JobInfo()
            {
                JobNumber = 1,
                JobTitlePosition = "Data Scientist",
                JobDescription = "A data scientist is a professional responsible for collecting, analyzing and interpreting extremely large amounts of data.",
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(3)
            };
            //Act
            JobInfo result = jobService.CreateJob(jobRepo, jobInfo);
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void UpdateJobMockTest()
        {
            //Arrange
            IJobCRUD jobRepo = new JobCRUDRepositoryMock();
            JobCRUDService jobService = new JobCRUDService();
            JobInfo jobInfo = new JobInfo()
            {
                JobNumber = 2,
                JobTitlePosition = "Software Developer",
                JobDescription = "A software developer is a company or person that creates software - either completely, or with other companies or people.",
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(3)
            };
            //Act
            JobInfo result = jobService.UpdateJob(jobRepo, jobInfo);
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void DeleteJobMockTest()
        {
            //Arrange
            IJobCRUD jobRepo = new JobCRUDRepositoryMock();
            JobCRUDService jobService = new JobCRUDService();
            JobInfo jobInfo = new JobInfo()
            {
                JobNumber = 3,
                JobTitlePosition = " Information Security Analyst",
                JobDescription = "Information security analysts design and implement security measures to protect an organization's computer networks and systems.",
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(3)
            };
            //Act
            JobInfo result = jobService.DeleteJob(jobRepo, jobInfo);
            //Assert
            Assert.NotNull(result);
        }
    }
}
