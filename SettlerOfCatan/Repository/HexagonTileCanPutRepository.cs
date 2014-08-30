//using SettlerOfCatan.Models;
//using SettlerOfCatan.Models.Interface;
//using SettlerOfCatan.Repository.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;


//namespace SettlerOfCatan.Repository
//{
//    public class HexagonTileCanPutRepository : IHexagonTileCanPutRepository
//    {
//        public IHexagonTileModel TopHexagonTile  { get; set; }
//        public IHexagonTileModel MiddleHexagonTile { get; set; }
//        public IHexagonTileModel BottomHexagonTile { get; set; }

//        public int PlayerID { get; set; }
//        public bool FirstTurn { get; set; }

//        public HexagonTileCanPutRepository() { }

//        public bool CanPutSettlementAtMiddleRightCorner()
//        {
//            if (FirstTurn)
//            {

//                if (CornerTypeModeHasSettlement(MiddleHexagonTile.TopRightCorner))
//                {
//                    return false;
//                }

//                if (CornerTypeModeHasSettlement(MiddleHexagonTile.BottomRightCorner))
//                {
//                    return false;
//                }

//                if (CornerTypeModeHasSettlement(MiddleHexagonTile.MiddleRightCorner))
//                {
//                    return false;
//                }

//                if (BottomHexagonTile != null)
//                {
//                    if (CornerTypeModeHasSettlement(BottomHexagonTile.TopRightCorner))
//                    {
//                        return false;
//                    }

//                    if (CornerTypeModeHasSettlement(BottomHexagonTile.MiddleLeftCorner))
//                    {
//                        return false;
//                    }

//                    if (CornerTypeModeHasSettlement(BottomHexagonTile.TopLeftCorner))
//                    {
//                        return false;
//                    }
//                }

//                if (TopHexagonTile != null)
//                {
//                    if (CornerTypeModeHasSettlement(TopHexagonTile.MiddleLeftCorner))
//                    {
//                        return false;
//                    }

//                    if (CornerTypeModeHasSettlement(TopHexagonTile.BottomLeftCorner))
//                    {
//                        return false;
//                    }

//                    if (CornerTypeModeHasSettlement(TopHexagonTile.BottomRightCorner))
//                    {
//                        return false;
//                    }
//                }
//                return true;
//            }

//            return false;
//        }

//        private bool CornerTypeModeHasSettlement(CornerTypeModel aaa)
//        {
//            if (aaa != null)
//            {
//                if (aaa.HasSettlement)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        public bool CanPutSettlementAtMiddleLeftCorner()
//        {
//            throw new NotImplementedException();
//        }

//        public bool PutSettlementAtMiddleRightCorner()
//        {
//            return false;
//        }

//        public bool PutSettlementAtMiddleLeftCorner()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}