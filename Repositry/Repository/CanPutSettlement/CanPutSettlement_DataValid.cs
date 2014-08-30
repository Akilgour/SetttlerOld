using Repositry.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
   public class CanPutSettlement_DataValid : IValidationCanPutSettlement
    {
        public Model.ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID, bool FirstTurn)
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
