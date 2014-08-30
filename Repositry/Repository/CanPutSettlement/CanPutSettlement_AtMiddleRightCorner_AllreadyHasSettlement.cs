using Repositry.Interface;
using Repositry.Model;
using Repositry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    public class CanPutSettlement_AtMiddleRightCorner_AllreadyHasSettlement : IValidationCanPutSettlement
    {

        public Model.ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID, bool FirstTurn)
        {
            if (FirstTurn)
            {
                if (MiddleHexagonTileModel is HexagonTileModel)
                {
                    HexagonTileModel mddleHexagonTileModel = (HexagonTileModel)MiddleHexagonTileModel;

                    if (CornerTypeModeHasSettlement(mddleHexagonTileModel.MiddleRightCorner))
                    {
                        return new ValidationResults() { IsValid = false, ErrorMessage = "Corner already has Settlement or Cities" };
                    }
                }

                if (BottomHexagonTileModel != null)
                {
                    if (BottomHexagonTileModel is HexagonTileModel)
                    {
                        HexagonTileModel bottomHexagonTile = (HexagonTileModel)BottomHexagonTileModel;
                        if (CornerTypeModeHasSettlement(bottomHexagonTile.TopLeftCorner))
                        {
                            return new ValidationResults() { IsValid = false, ErrorMessage = "Corner already has Settlement or Cities" };
                        }
                    }
                }

                if (TopHexagonTileModel != null)
                {
                    if (TopHexagonTileModel is HexagonTileModel)
                    {
                        HexagonTileModel topHexagonTileModel = (HexagonTileModel)TopHexagonTileModel;


                        if (CornerTypeModeHasSettlement(topHexagonTileModel.BottomLeftCorner))
                        {
                            return new ValidationResults() { IsValid = false, ErrorMessage = "Corner already has Settlement or Cities" };
                        }
                    }
                }
            }
            return new ValidationResults() { IsValid = true };
        }

        private bool CornerTypeModeHasSettlement(CornerTypeModel corner)
        {
            if (corner != null)
            {
                if (corner.HasSettlement)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
