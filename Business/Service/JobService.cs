using eshift_good_tranport_system.Business.Interface;
using eshift_good_tranport_system.Models;
using eshift_good_tranport_system.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Business.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _repo;

        public JobService(IJobRepository repo)
        {
            _repo = repo;
        }

        public List<JobModel> GetJobs(string username) => _repo.GetJobsByUsername(username);
        public void AddJob(JobModel job) => _repo.AddJob(job);
        public void UpdateJob(JobModel job) => _repo.UpdateJob(job);
        public void DeleteJob(int jobId) => _repo.DeleteJob(jobId);

        public List<JobModel> GetJobsByUsername(string username)
        {
            throw new NotImplementedException();
        }
        public List<JobModel> GetAllJobs() => _repo.GetAllJobs();

        public void UpdateJobStatus(int jobId, string status) =>
            _repo.UpdateJobStatus(jobId, status);

        public void ApproveJobWithLorry(int jobId, string status, int lorryId) =>
            _repo.ApproveJobWithLorry(jobId, status, lorryId);

        public List<JobModel> GetJobsByStatus(string status)
        {
            return _repo.GetJobsByStatus(status);
        }

        public void AssignLorry(int jobId, int lorryId)
        {
            _repo.AssignLorryToJob(jobId, lorryId);
        }

    }
}