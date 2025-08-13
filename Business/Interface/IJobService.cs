using eshift_good_tranport_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Business.Interface
{
    public interface IJobService
    {
        List<JobModel> GetJobsByUsername(string username);
        List<JobModel> GetJobs(string username);
        void AddJob(JobModel job);
        void DeleteJob(int jobId);
        void UpdateJob(JobModel job);
        List<JobModel> GetAllJobs();
        void UpdateJobStatus(int jobId, string status);
        void ApproveJobWithLorry(int jobId, string status, int lorryId);

    }
}
