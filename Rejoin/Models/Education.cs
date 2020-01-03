using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Models
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }

        [MaxLength(100)]
        [Required]
        public string SchoolName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Qualification { get; set; }

        [Required]
        public int StartEducationYear { get; set; }

        [Required]
        public int EndEducationYear { get; set; }

        [Required]
        public int ResumeId { get; set; }

        public UserResume Resume { get; set; }
    }
}
