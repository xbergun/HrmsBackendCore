using HotChocolate;
using HrmsGraphql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmsGraphql
{
    public class Query
    {
        public IQueryable<Employer> GetEmployers([Service] hrmsContext context)
        {
            IQueryable<Employer> employer = context.Employers;
            return employer;
        }

        public IQueryable<Cv> GetCvs([Service] hrmsContext context)
        {
            IQueryable<Cv> cv = context.Cvs;
            return cv;
        }

        public IQueryable<Employeer> GetEmployeers([Service] hrmsContext context)
        {
            IQueryable<Employeer> employeer = context.Employeers;
            return employeer;
        }

        public IQueryable<JobAdvertisement> GetJobAdvertisements([Service] hrmsContext context)
        {
            IQueryable<JobAdvertisement> jobAdvertisement = context.JobAdvertisements;
            return jobAdvertisement;
        }

        public IQueryable<JobSeeker> GetJobSeekers([Service] hrmsContext context)
        {
            IQueryable<JobSeeker> jobSeeker = context.JobSeekers;
            return jobSeeker;
        }

        public IQueryable<User> GetUsers([Service] hrmsContext context)
        {
            IQueryable<User> user = context.Users;
            return user;
        }
    }
}
