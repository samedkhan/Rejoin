using Rejoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.ViewModels
{
    public class CandidateIndexViewModel
    {
        public BreadcumbViewModel Breadcumb { get; set; }


    }

    public class CandidateProfileModel
    {
        public LookingJob LookingForJob { get; set; }

        public string AboutMe { get; set; }

        public List<Language> KnownLanguages { get; set; }

    }
}
