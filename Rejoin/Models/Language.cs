using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Models
{
    public enum KnownLevel
    {
        Little = 0,
        Middle = 1,
        Super = 2
    }
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public KnownLevel KnownLevel { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
