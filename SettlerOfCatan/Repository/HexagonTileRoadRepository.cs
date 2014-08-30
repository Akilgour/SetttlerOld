using SettlerOfCatan.Models;
using SettlerOfCatan.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlerOfCatan.Repository
{
    public class HexagonTileRoadRepository //: IHexagonTileRoadRepository
    {

        //public IHexagonTileModel HexagonTileModel { get; set; }
        //public IHexagonTileModel? NeighbouringHexagonTileModel { get; set; }
        //public int PlayerID { get; set; }

        public HexagonTileRoadRepository()
        {

        }


        //public bool CanPutNorthSideRoadOwner()
        //{
                   
        //    return CanPutSettlementAt( HexagonTileModel.TopLeftCorner, HexagonTileModel.MiddleLeftCorner, HexagonTileModel.TopRightCorner, HexagonTileModel.NorthWestSideRoadOwner, HexagonTileModel.NorthSideRoadOwner);//neighbouring
        //}

        //private bool CanPutSettlementAt( CornerTypeModel corner, CornerTypeModel cornerToTheLeft, CornerTypeModel cornerToTheRight, int? roadToTheRight, int? roadToTheLeft)
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

        //        bool atOtherPlayersRoad = ((roadToTheLeft != PlayerID) && (roadToTheRight != PlayerID));
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


        //public bool CanPutNorthEastSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSouthEastSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSouthSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutSouthWestSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CanPutNorthWestSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutNorthSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutNorthEastSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSouthEastSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSouthSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutSouthWestSideRoadOwner()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutNorthWestSideRoadOwner(int playerID, IHexagonTileModel? neighbouringHexagon)
        //{
        //    throw new NotImplementedException();
        //}
    }
}