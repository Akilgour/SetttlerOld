using Repositry.Interface;
using Repositry.Model;
using Repositry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositry.Models.Interface;

namespace Repositry.Repository
{
    public class CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement : IValidationCanPutSettlement
    {
        public Model.ValidationResults IsValid(IHexagonTileModel topHexagonTileModel, IHexagonTileModel middleHexagonTileModel, IHexagonTileModel bottomHexagonTileModel, int playerID, bool firstTurn)
        {
            if (middleHexagonTileModel != null)
            {
                if (CornerTypeModeHasSettlement(middleHexagonTileModel.TopRightCorner))
                {
                    return new ValidationResults() { IsValid = false, ErrorMessage = "Corner has adjacent Settlement" };
                }

                if (CornerTypeModeHasSettlement(middleHexagonTileModel.BottomRightCorner))
                {
                    return new ValidationResults() { IsValid = false, ErrorMessage = "Corner has adjacent Settlement" };
                }
            }

            if (bottomHexagonTileModel != null)
            {
                if (CornerTypeModeHasSettlement(bottomHexagonTileModel.MiddleLeftCorner))
                {
                    return new ValidationResults() { IsValid = false, ErrorMessage = "Corner has adjacent Settlement" };
                }

                if (CornerTypeModeHasSettlement(bottomHexagonTileModel.TopRightCorner))
                {
                    return new ValidationResults() { IsValid = false, ErrorMessage = "Corner has adjacent Settlement" };
                }
            }

            if (topHexagonTileModel != null)
            {
                if (CornerTypeModeHasSettlement(topHexagonTileModel.MiddleLeftCorner))
                {
                    return new ValidationResults() { IsValid = false, ErrorMessage = "Corner has adjacent Settlement" };
                }

                if (CornerTypeModeHasSettlement(topHexagonTileModel.BottomRightCorner))
                {
                    return new ValidationResults() { IsValid = false, ErrorMessage = "Corner has adjacent Settlement" };
                }
            }

            return new ValidationResults() { IsValid = true };
        }

        private bool CornerTypeModeHasSettlement(CornerTypeModel corner)
        {
            if (corner != null && corner.HasSettlement)
            {
                return true;
            }

            return false;
        }
    }
}