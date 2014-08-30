using Repositry.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSettlersOfCatan.Factory.Validation
{
    public class ValidationFalseMessageFoo : IValidationRoad
    {


        public ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID)
        {
            return new ValidationResults() { IsValid = false, ErrorMessage = "Foo" };
        }
    }
}
