using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositry.Interface
{
    public interface IValidationToken
    {
        bool IsValid();
        Repositry.Model.ValidationResults Invaild();
    }
}
