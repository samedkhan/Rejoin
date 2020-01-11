using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Rejoin.Models
{

    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }

        
        public bool IsCompany { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Adress { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string ZipCode { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(100)]
        public string Facebook { get; set; }

        [MaxLength(100)]
        public string Google { get; set; }


        [Column(TypeName = "ntext")]
        public string AboutMe { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [MaxLength(10)]
        public string Phone { get; set; }

        public string Token { get; set; }

        public bool HasResume { get; set; }

        public bool HasJobSubmit { get; set; }

        public LookingJob LookingForJob { get; set; }

       

        public List<Language> KnownLanguages { get; set; }

        public UserResume Resumes { get; set; }

        public List<Job> Jobs { get; set; }
    }
}
