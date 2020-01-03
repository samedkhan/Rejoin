using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.ViewModels
{
    public class ResumeIndexViewModel
    {
        public ResumeModel Resume { get; set; }
        public EducationViewModel Education { get; set; }
        public WorkViewModel Work { get; set; }
    }

    public class ResumeModel
    {
        public bool HasResume { get; set; }
        // Profession
        [MaxLength(100)]
        [Required(ErrorMessage = "Required")]
        public string JobProfession { get; set; }

        public int ExperienceYear { get; set; }

        public int ExperienceMonth { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(500)]
        public string PersonalSkills { get; set; }

        public List<EducationViewModel> Educations { get; set; }

        public List<WorkViewModel> Works { get; set; }
    }

    // FOR RESUME VIEW 
    public class EducationViewModel
    {
        // School 
        [MaxLength(100)]
        [Required]
        public string SchoolName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Qualification { get; set; }

        [Required]
        public int StartSchool { get; set; }

        [Required]
        public int EndSchool { get; set; }
    }

    public class WorkViewModel
    {
        // Experience
        [MaxLength(100)]
        [Required]
        public string CompanyName { get; set; }

        [MaxLength(100)]
        [Required]
        public string Position { get; set; }

        [Required]
        public int StartWork { get; set; }

        [Required]
        public int EndWork { get; set; }
    }
}
