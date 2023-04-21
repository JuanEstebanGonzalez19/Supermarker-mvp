using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_mvp.Presenters.Common
{
    internal class ModelDataValidation
    {
        public void Validate(object model) 
        {
            string errorMessage = "";
            List<ValidationResult> validationResult = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, validationContext, validationResult, true);
            if (isValid == false) 
            {
                foreach (var item in validationResult) 
                {
                    errorMessage += item.ErrorMessage + "\n"; 
                }
                throw new ValidationException(errorMessage);
            }
        }
    }
}
