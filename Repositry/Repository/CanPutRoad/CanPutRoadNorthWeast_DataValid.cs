using Repositry.Interface;
using Repositry.Model;
using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    public class CanPutRoad_DataValid : IValidationRoad
    {

        public ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID)
        {
            if ((TopHexagonTileModel == null) && (MiddleHexagonTileModel == null) && (BottomHexagonTileModel == null))
            {
               //throw new Exception("At least one hexagon has to be set");
               return new ValidationResults() { IsValid = false, ErrorMessage = "At least one hexagon has to be set" };

            }
            //return true;
            return new ValidationResults() { IsValid = true };
        }
           
    }
}
