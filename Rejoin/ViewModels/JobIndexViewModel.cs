﻿using Rejoin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.ViewModels
{
    public class JobIndexViewModel
    {
        public BreadcumbViewModel Breadcumb { get; set; }
        public JobCreateIndexViewModel JobCreate { get; set; }

        public JobSeachViewModel JobSearch { get; set; }

    }
    public class JobSeachViewModel
    {
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Category { get; set; }
    }
    public class JobCreateIndexViewModel
    {
        [Required(ErrorMessage = "Required")]
        public JobType Jobtype { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(100)]
        public string Role { get; set; }

        [Required(ErrorMessage = "Required")]
        public int ExpierenceYear { get; set; }

        [Required(ErrorMessage = "Required")]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(100)]
        public string City { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(100)]
        public string Category { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(500)]
        public string JobDescription { get; set; }
    }

    
  
}
