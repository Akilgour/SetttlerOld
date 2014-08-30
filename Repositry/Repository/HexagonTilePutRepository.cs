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
    public class HexagonTilePutRepository : IHexagonTilePutRepository
    {
        public HexagonTilePutRepository() { }
        public IHexagonTileModel TopHexagonTileModel;
        public IHexagonTileModel MiddleHexagonTileModel ;
        public IHexagonTileModel BottomHexagonTileModel;
        public int PlayerID;

        public bool PutSettlementAtMiddleRightCorner()
        {
            if ((TopHexagonTileModel == null) && (MiddleHexagonTileModel == null) && (BottomHexagonTileModel == null))
            {
                throw new Exception("At least one hexagon has to be set");
            }

            var canPut = HexagonTileCanPutRepository.CanPutSettlementAtMiddleRightCorner();

            if (canPut == false)
            { return false; }

            if (TopHexagonTileModel != null)
            {
                TopHexagonTileModel.BottomLeftCorner = new CornerTypeModel();
                TopHexagonTileModel.BottomLeftCorner.HasSettlement = true;
                TopHexagonTileModel.BottomLeftCorner.OwnerID = PlayerID;
            }

            if (MiddleHexagonTileModel != null)
            {
                MiddleHexagonTileModel.MiddleRightCorner = new CornerTypeModel();
                MiddleHexagonTileModel.MiddleRightCorner.HasSettlement = true;
                MiddleHexagonTileModel.MiddleRightCorner.OwnerID = PlayerID;
            }

            if (BottomHexagonTileModel != null)
            {
                BottomHexagonTileModel.TopLeftCorner = new CornerTypeModel();
                BottomHexagonTileModel.TopLeftCorner.HasSettlement = true;
                BottomHexagonTileModel.TopLeftCorner.OwnerID = PlayerID;
            }

            return true;
        }

        public IHexagonTileCanPutRepository HexagonTileCanPutRepository { get; set; }
    }
}
