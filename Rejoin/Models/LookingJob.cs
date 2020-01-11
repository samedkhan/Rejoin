using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Models
{
   
    public class LookingJob
    {

        [Key]
        public int LJId { get; set; }
        [MaxLength]
        public string Name { get; set; }

        public int MinSalary { get; set; }

        public int MaxSalary { get; set; }

        public string  LocationAdress { get; set; }

        public JobType JobType { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
