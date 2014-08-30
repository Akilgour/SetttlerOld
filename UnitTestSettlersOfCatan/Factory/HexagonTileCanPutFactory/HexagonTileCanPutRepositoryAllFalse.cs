using Repositry.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSettlersOfCatan.Factory.HexagonTileCanPutFactory
{
    public class HexagonTileCanPutRepositoryAllFalse : IHexagonTileCanPutRepository
    {

        //public HexagonTileCanPutRepositoryAllFalse() { }

        //public bool CanPutSettlementAtMiddleRightCorner()
        //{
        //    return false;
        //}

        //public bool PutSettlementAtMiddleRightCorner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSettlementAtMiddleLeftCorner()
        //{
        //    throw new NotImplementedException();
        public bool CanPutSettlementAtMiddleRightCorner()
        {
            return false;
        }


        public bool CanPutCityAtMiddleRightCorner()
        {
            return false;
        }
    }
}
