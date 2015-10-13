using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaDataModel
{

    public class Choice
    {

        private DiplomaContext db = new DiplomaContext();

        public Choice()
        {
            YearTermId = (db.YearTerms
                .Where(t => t.isDefault == true)
                .Select(t => t.YearTermId).FirstOrDefault());



        }


        public int ChoiceId { get; set; }

        //No dropdown of yearTerm - use constructor to retrieve default Term
        //Don't scaffold
        [ScaffoldColumn(false)]
        public int YearTermId { get; set; }

        [Required]
        //Enter Regex to check Student ID A00## Format Max 9
        //No duplicate rows allowed for the same year term
        [Display(Name = "Student Id")]
        [RegularExpression("A00\\d{6}", ErrorMessage="Invalid Student ID, A00123456 is the expected format")]
        public string StudentId { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Student First Name")]
        public string StudentFirstName { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Student Last Name")]
        public string StudentLastName { get; set;  }

        //ONLY DISPLAY ACTIVE OPTIONS
        //ALL FOUR REQUIRED
        //FIRST YEAR STUDENTS CANNOT CHOOSE THE SAME OPTION MORE THAN TWICE
        [Required]
        //[UIHint("_OptionDropDown")]
        [Display(Name = "First Option Choice")]
        public int FirstChoiceOptionId { get; set; }

        [Display(Name = "Second Option Choice")]
        [Required]
        //[UIHint("_OptionDropDown")]
        public int SecondChoiceOptionId { get; set; }

        [Display(Name = "Third Option Choice")]
        [Required]
        //[UIHint("_OptionDropDown")]
        public int ThirdChoiceOptionId { get; set; }

        [Display(Name = "Fourth Option Choice")]
        [Required]
        //[UIHint("_OptionDropDown")]
        public int FourthChoiceOptionId { get; set; }

        //Always the current dates, don't scaffold
        [ScaffoldColumn(false)]
        public DateTime SelectionDate { get; set; }

        //Don't scaffold these
        [ScaffoldColumn(false)]
        public YearTerm YearTerm { get; set; }

        //Don't scaffold these
        [ScaffoldColumn(false)]
        //[ForeignKey("FirstChoiceOptionId")]
        public Option FirstChoiceOption { get; set; }
        [ScaffoldColumn(false)]
        //[ForeignKey("SecondChoiceOptionId")]
        public Option SecondChoiceOption { get; set; }
        [ScaffoldColumn(false)]
        //[ForeignKey("ThirdChoiceOptionId")]
        public Option ThirdChoiceOption { get; set; }
        [ForeignKey("FourthChoiceOptionId")]
        //[ScaffoldColumn(false)]
        public Option FourthChoiceOption { get; set; }

    }
}
