using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Models
{
    public class UserResume
    {
        [Key]
        public int ResumeId { get; set; }

        [Required]
        public User user { get; set; }

        [Required]
        public int UserId { get; set; }

        public List<Work> works { get; set; }

        public List<Education> educations { get; set; }
    }
}
