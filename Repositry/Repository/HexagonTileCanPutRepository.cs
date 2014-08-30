using Repositry.Interface;
using Repositry.Models;
using Repositry.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
   public class HexagonTileCanPutRepository :IHexagonTileCanPutRepository
    {

        public IHexagonTileModel TopHexagonTile { get; set; }
        public IHexagonTileModel MiddleHexagonTile { get; set; }
        public IHexagonTileModel BottomHexagonTile { get; set; }

        public int PlayerID { get; set; }
        public bool FirstTurn { get; set; }

        public HexagonTileCanPutRepository() { }

        public bool CanPutSettlementAtMiddleRightCorner()
        {
            throw new NotImplementedException();
        }

        //public bool CanPutSettlementAtMiddleRightCorner()
        //{
        //    if (FirstTurn)
        //    {

        //        if (CornerTypeModeHasSettlement(MiddleHexagonTile.TopRightCorner))
        //        {
        //            return false;
        //        }

        //        if (CornerTypeModeHasSettlement(MiddleHexagonTile.BottomRightCorner))
        //        {
        //            return false;
        //        }

        //        if (CornerTypeModeHasSettlement(MiddleHexagonTile.MiddleRightCorner))
        //        {
        //            return false;
        //        }

        //        if (BottomHexagonTile != null)
        //        {
        //            if (CornerTypeModeHasSettlement(BottomHexagonTile.TopRightCorner))
        //            {
        //                return false;
        //            }

        //            if (CornerTypeModeHasSettlement(BottomHexagonTile.MiddleLeftCorner))
        //            {
        //                return false;
        //            }

        //            if (CornerTypeModeHasSettlement(BottomHexagonTile.TopLeftCorner))
        //            {
        //                return false;
        //            }
        //        }

        //        if (TopHexagonTile != null)
        //        {
        //            if (CornerTypeModeHasSettlement(TopHexagonTile.MiddleLeftCorner))
        //            {
        //                return false;
        //            }

        //            if (CornerTypeModeHasSettlement(TopHexagonTile.BottomLeftCorner))
        //            {
        //                return false;
        //            }

        //            if (CornerTypeModeHasSettlement(TopHexagonTile.BottomRightCorner))
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }

        //    return false;
        //}

        private bool CornerTypeModeHasSettlement(CornerTypeModel aaa)
        {
            if (aaa != null)
            {
                if (aaa.HasSettlement)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CanPutCityAtMiddleRightCorner()
        {
            if (FirstTurn) { return false; }

            if (MiddleHexagonTile != null)
            {
                if (MiddleHexagonTile.MiddleRightCorner != null)
                {
                    if (MiddleHexagonTile.MiddleRightCorner.HasSettlement)
                    {
                        if (MiddleHexagonTile.MiddleRightCorner.OwnerID == PlayerID)
                        {
                            return true;
                        }
                    }
                }
            }

            if (TopHexagonTile != null)
            {
                if (TopHexagonTile.BottomLeftCorner != null)
                {
                    if (TopHexagonTile.BottomLeftCorner.HasSettlement)
                    {
                        if (TopHexagonTile.BottomLeftCorner.OwnerID == PlayerID)
                        {
                            return true;
                        }
                    }
                }
            }

            if (BottomHexagonTile != null)
            {
                if (BottomHexagonTile.TopLeftCorner != null)
                {
                    if (BottomHexagonTile.TopLeftCorner.HasSettlement)
                    {
                        if (BottomHexagonTile.TopLeftCorner.OwnerID == PlayerID)
                        {
                            return true;
                        }
                    }
                }
            }

            //if (CanPutCity(TopHexagonTile))
            //{
            //    return true;
            //}

            return false;

        }

        private bool CanPutCity(IHexagonTileModel hexagonTile)
        {
            if (MiddleHexagonTile != null)
            {
                if (MiddleHexagonTile.MiddleLeftCorner != null)
                {
                    if (MiddleHexagonTile.MiddleLeftCorner.HasSettlement)
                    {
                        if (MiddleHexagonTile.MiddleLeftCorner.OwnerID == PlayerID)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }


      
    }
}
