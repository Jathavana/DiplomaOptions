using DiplomaOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiplomaDataModel.CustomValidation
{
    public class DuplicateStudent : ValidationAttribute
    {
        public int Term;
        private DiplomaContext db = new DiplomaContext();

        public DuplicateStudent()
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var input = value.ToString();

                Term = (db.YearTerms
                .Where(t => t.isDefault == true)
                .Select(t => t.YearTermId)).FirstOrDefault();

                var query = db.Choices
                    .Where(c => c.StudentId == input)
                    .Where(c => c.YearTermId == Term)
                    .Select(c => c);

                if (query != null)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;

        }
    }
}