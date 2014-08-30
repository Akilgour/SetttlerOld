using SettlerOfCatan.Models;

using SettlerOfCatan.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlerOfCatan.Repository
{
    public class HexagonTilePutRepository : IHexagonTilePutRepository
    {
        //public IHexagonTileCanPutRepository HexagonTileCanPutRepository { get; set; }


        public HexagonTilePutRepository() { }

        public bool PutSettlementAtMiddleRightCorner()
        {
            return  true;
        }


        //public IHexagonTileModel HexagonTileModel { get; set; }

        //public HexagonTilePutRepository(IHexagonTileModel hexagonTileModel) { this.HexagonTileModel = hexagonTileModel; }
       
        //public bool CanPutSettlementAtTopLeftCorner(int playerID,  IHexagonTileModel neighbouringHexagon, bool firstRound = false)
        //{
        //    return CanPutSettlementAt(playerID, HexagonTileModel.TopLeftCorner, HexagonTileModel.MiddleLeftCorner, HexagonTileModel.TopRightCorner, HexagonTileModel.NorthWestSideRoadOwner, HexagonTileModel.NorthSideRoadOwner);//neighbouring
        //}

        //private bool CanPutSettlementAt(int playerID, CornerTypeModel corner, CornerTypeModel cornerToTheLeft, CornerTypeModel cornerToTheRight, int? roadToTheRight, int? roadToTheLeft)
        //{
        //    if (cornerToTheLeft != null)
        //    {
        //        return false;
        //    }

        //    if (cornerToTheRight != null)
        //    {
        //        return false;
        //    }

        //    if (corner == null)
        //    {
        //        bool oneOfTheRoadNull = ((roadToTheLeft == null) || (roadToTheRight == null));
        //        if (oneOfTheRoadNull)
        //        {
        //            return true;
        //        }

        //        bool atOtherPlayersRoad = ((roadToTheLeft != playerID) && (roadToTheRight != playerID));
        //        if (atOtherPlayersRoad)
        //        {
        //            return false;
        //        }
        //    }

        //    if (corner == null)
        //    {
        //        return true;
        //    }

        //    if (corner != null)
        //    {
        //        if ((corner.OwnerID == null) && ((corner.HasCity == false) || (corner.HasSettlement == false)))
        //        {
        //            return true;

        //        }
        //    }

        //    return false;
        //}

        //public bool CanPutSettlementAtTopRightCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSettlementAtMiddleRightCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSettlementAtBottomRightCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSettlementAtBottomLeftCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSettlementAtMiddleLeftCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSettlementAtTopLeftCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSettlementAtTopRightCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSettlementAtMiddleRightCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSettlementAtBottomRightCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSettlementAtBottomLeftCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSettlementAtMiddleLeftCorner(int playerID, bool firstRound = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutNorthSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutNorthEastSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSouthEastSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSouthSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSouthWestSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutNorthWestSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutNorthSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutNorthEastSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSouthEastSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSouthSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSouthWestSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutNorthWestSideRoadOwner(int playerID)
        //{
        //    throw new NotImplementedException();
        //}

        //public void PutRobberThere()
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRobberFromThere()
        //{
        //    throw new NotImplementedException();
        //}

     
    }
}