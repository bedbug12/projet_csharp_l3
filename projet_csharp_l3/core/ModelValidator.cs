using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.core
{
    public class ModelValidator
    {
        public static void validate(object model)
        {
            string ErrorMessage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValide = Validator.TryValidateObject(model, context, validationResults, true);
            if (!isValide)
            {
                foreach (var validationResult in validationResults)
                {
                    ErrorMessage += validationResult.ErrorMessage + "\n";
                    throw new Exception(ErrorMessage);
                }
            }
        }
    }
}
