using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }

        [MaxLength(100)]
        [Required]
        public string CompanyName { get; set; }

        [MaxLength(100)]
        [Required]
        public string Position { get; set; }

        [Required]
        public int StartWorkYear { get; set; }

        [Required]
        public int EndWorkYear { get; set; }

        [Required]
        public int ResumeId { get; set; }

        public UserResume Resume { get; set; }
    }
}
