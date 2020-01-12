using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Models
{
    public enum JobType
    {
        FullTime = 0,
        PartTime = 1,
        WorkFromHome = 2,
        Internship = 3
    }
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public JobType Jobtype { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Role { get; set; }

        [Required]
        public int ExpierenceYear { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required]
        [MaxLength(500)]
        [Column(TypeName = "ntext")]
        public string JobDescription { get; set; }


        [Required]
        [MaxLength(100)]
        public string Category { get; set; }

        public int UserId { get; set; }

        public User user { get; set; }

        public List<Apply> Appliers { get; set; }
    }
}
