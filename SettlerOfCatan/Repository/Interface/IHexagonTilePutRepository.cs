 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlerOfCatan.Repository.Interface
{
    public interface IHexagonTilePutRepository
    {

        bool PutSettlementAtMiddleRightCorner();

        //bool CanPutSettlementAtTopLeftCorner(int playerID, IHexagonTileModel neighbouringHexagon, bool firstRound = false);
        //bool CanPutSettlementAtTopRightCorner(int playerID, bool firstRound = false);
        //bool CanPutSettlementAtMiddleRightCorner(int playerID, bool firstRound = false);
        //bool CanPutSettlementAtBottomRightCorner(int playerID, bool firstRound = false);
        //bool CanPutSettlementAtBottomLeftCorner(int playerID, bool firstRound = false);
        //bool CanPutSettlementAtMiddleLeftCorner(int playerID, bool firstRound = false);

        //bool PutSettlementAtTopLeftCorner(int playerID, bool firstRound = false);
        //bool PutSettlementAtTopRightCorner(int playerID, bool firstRound = false);
        //bool PutSettlementAtMiddleRightCorner(int playerID, bool firstRound = false);
        //bool PutSettlementAtBottomRightCorner(int playerID, bool firstRound = false);
        //bool PutSettlementAtBottomLeftCorner(int playerID, bool firstRound = false);
        //bool PutSettlementAtMiddleLeftCorner(int playerID, bool firstRound = false);

        //bool CanPutNorthSideRoadOwner(int playerID);
        //bool CanPutNorthEastSideRoadOwner(int playerID);
        //bool CanPutSouthEastSideRoadOwner(int playerID);
        //bool CanPutSouthSideRoadOwner(int playerID);
        //bool CanPutSouthWestSideRoadOwner(int playerID);
        //bool CanPutNorthWestSideRoadOwner(int playerID);

        //bool PutNorthSideRoadOwner(int playerID);
        //bool PutNorthEastSideRoadOwner(int playerID);
        //bool PutSouthEastSideRoadOwner(int playerID);
        //bool PutSouthSideRoadOwner(int playerID);
        //bool PutSouthWestSideRoadOwner(int playerID);
        //bool PutNorthWestSideRoadOwner(int playerID);

        //void PutRobberThere();
        //void RemoveRobberFromThere();
    }
}
