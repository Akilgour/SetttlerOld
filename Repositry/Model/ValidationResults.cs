using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{
   public  class ValidationResults : IValidationResults
    {
        public bool IsValid { get; set;  }
        public string ErrorMessage { get; set; }
    }
}
