using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Models
{
    public class Apply
    {
        [Key]
        public int ApplyId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User user { get; set; }

        [Required]
        public int JobId { get; set; }

        public Job Job { get; set; }
    }
}
