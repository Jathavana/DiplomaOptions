using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaDataModel
{
    public class Option
    {
        public int OptionId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Display(Name = "Active")]
        public Boolean IsActive { get; set; }

        public List<Choice> Choices { get; set; }
    }
}
