using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaDataModel
{
    public class YearTerm
    {
        public int YearTermId { get; set; }

        public int Year { get; set; }

        public int Term { get; set; }

        [Display(Name = "Default")]
        public Boolean isDefault { get; set; }

        public List<Choice> Choices { get; set; }
    }
}
