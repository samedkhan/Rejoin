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
        public int UserId { get; set; }

        [Required]
        public User user { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Required")]
        public string JobProfession { get; set; }

        [MaxLength(50)]
        [Required]
        public string PersonalSkill { get; set; }

        [Required]
        public int ExpierenceYear { get; set; }
      

        public List<Work> works { get; set; }

        public List<Education> educations { get; set; }
    }
}
