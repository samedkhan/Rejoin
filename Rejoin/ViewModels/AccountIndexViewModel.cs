using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Rejoin.Models;

namespace Rejoin.ViewModels
{
    public class AccountIndexViewModel
    {
       public AccountRegisterModel register { get; set; }


    }

    public class AccountRegisterModel
    {

        [Required(ErrorMessage = "Write Username")]
        [MaxLength(50)]
        public string Username { get; set; }


        [Required(ErrorMessage = "Write Password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Write E-mail!!!")]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage = "It is not e-mail address")]
        public string Email { get; set; }
    }
}
