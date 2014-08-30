using Repositry.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    public class CanPutRoadNorthWeast_MiddleHexagonTile : IValidationRoad
    {



        public ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID)
        {
            if (MiddleHexagonTileModel == null)
            {
                return new ValidationResults() { IsValid = true };
            }

            if (MiddleHexagonTileModel is HexagonTileModel)
            {
                HexagonTileModel middleHexagonTileModel = (HexagonTileModel)MiddleHexagonTileModel;

                if (CanPutRoad_CanPut.CanPut(PlayerID, middleHexagonTileModel.MiddleRightCorner))
                    return new ValidationResults() { IsValid = true };

                if (CanPutRoad_CanPut.CanPut(PlayerID, middleHexagonTileModel.TopRightCorner))
                    return new ValidationResults() { IsValid = true };
            }

            return new ValidationResults() { IsValid = false, ErrorMessage = "No adjacent Settlement or Cities" };

        }

    }
}
