using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model.Interface
{
    public interface IValidationResults
    {
         bool IsValid { get; set; }
         string ErrorMessage { get; set; }
    }
}
