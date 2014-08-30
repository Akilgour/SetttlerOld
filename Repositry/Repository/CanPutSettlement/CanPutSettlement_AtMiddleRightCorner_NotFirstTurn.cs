using Repositry.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    public class CanPutSettlement_AtMiddleRightCorner_NotFirstTurn : IValidationCanPutSettlement
    {


        public ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID, bool FirstTurn)
        {
            return new ValidationResults() { IsValid = true };
        }
    }
}
