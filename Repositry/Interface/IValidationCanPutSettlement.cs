using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Interface
{
    public interface IValidationCanPutSettlement : IValidationToken
    {
        object TopHexagonTileModel;
        object MiddleHexagonTileModel;
        object BottomHexagonTileModel;
        int PlayerID;
        bool FirstTurn;
    }
}