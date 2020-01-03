using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rejoin.Models;

namespace Rejoin.Data
{
    public class RejoinDbContext:DbContext
    {
        public RejoinDbContext(DbContextOptions<RejoinDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<UserResume> UserResumes { get; set; }

        public DbSet<Job> Jobs { get; set; }
    }
}
