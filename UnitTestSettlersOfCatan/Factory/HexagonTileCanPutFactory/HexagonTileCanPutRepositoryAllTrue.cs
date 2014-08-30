using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SettlerOfCatan.Repository;
//using SettlerOfCatan.Repository.Interface;
using Repositry.Interface;

namespace UnitTestSettlersOfCatan.Factory.HexagonTileCanPutFactory
{
    class HexagonTileCanPutRepositoryAllTrue : IHexagonTileCanPutRepository
    {
        public bool CanPutSettlementAtMiddleRightCorner()
        {
            return true;
        }

        //public bool PutSettlementAtMiddleRightCorner()
        //{
        //    throw new NotImplementedException();
        //}

        public bool CanPutCityAtMiddleRightCorner()
        {
            return true;
        }
    }
}
