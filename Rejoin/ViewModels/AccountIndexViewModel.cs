using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Rejoin.Models;

namespace Rejoin.ViewModels
{
    public class AccountIndexViewModel
    {
        public AccountLoginModel Login { get; set; }
        public AccountRegisterModel Register { get; set; }
        public AccountProfileModel Profile { get; set; }
       
    }

    public class AccountRegisterModel
    {

        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string Username { get; set; }


        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "It is not e-mail address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsCompany { get; set; }
    }

    public class AccountLoginModel
    {
        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string Username { get; set; }


        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class AccountProfileModel
    {
        public IFormFile Photo { get; set; }

        public bool HasResume { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string FirstName { get; set; }


        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(100)]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Required")]
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

        [MaxLength(10, ErrorMessage = "Phone must be 10 character")]
        [MinLength(10, ErrorMessage = "Phone must be 10 character")]
        public string Phone { get; set; }
    }

    
}

