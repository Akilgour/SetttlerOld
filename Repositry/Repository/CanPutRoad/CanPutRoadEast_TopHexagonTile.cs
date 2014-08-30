using Repositry.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    public class CanPutRoadEast_TopHexagonTile : IValidationRoad
    {
        public ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID)
        {
            if (TopHexagonTileModel == null)
            {
                return new ValidationResults() { IsValid = true };
            }

            if (TopHexagonTileModel is HexagonTileModel)
            {
                HexagonTileModel topHexagonTileModel = (HexagonTileModel)TopHexagonTileModel;

                if (CanPutRoad_CanPut.CanPut(PlayerID, topHexagonTileModel.BottomLeftCorner))
                    return new ValidationResults() { IsValid = true };

                if (CanPutRoad_CanPut.CanPut(PlayerID, topHexagonTileModel.BottomRightCorner))
                    return new ValidationResults() { IsValid = true };

            }

            return new ValidationResults() { IsValid = false, ErrorMessage = "No adjacent Settlement or Cities" };
        }
    }
}
