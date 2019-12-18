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

        public DbSet<Person> MyProperty { get; set; }
    }
}
