using Repositry.Model;
using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Interface
{
    public interface IValidationRoad : IValidationToken
    {
        ValidationResults IsValid(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID);
    }
}