using Repositry.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
   public class CanPutRoadEast_BottomHexagonTile : IValidationRoad
    {
       public ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID)
        {
            if (BottomHexagonTileModel == null)
            {
                return new ValidationResults() { IsValid = true };
            }

            if (BottomHexagonTileModel is HexagonTileModel)
            {
                HexagonTileModel bottomHexagonTileModel = (HexagonTileModel)BottomHexagonTileModel;

                if (CanPutRoad_CanPut.CanPut(PlayerID, bottomHexagonTileModel.TopLeftCorner))
                    return new ValidationResults() { IsValid = true };


                if (CanPutRoad_CanPut.CanPut(PlayerID, bottomHexagonTileModel.TopRightCorner))
                    return new ValidationResults() { IsValid = true };


            }
            return new ValidationResults() { IsValid = false, ErrorMessage = "No adjacent Settlement or Cities" };

        }

       public bool IsValid()
       {
           throw new NotImplementedException();
       }
    }
}
