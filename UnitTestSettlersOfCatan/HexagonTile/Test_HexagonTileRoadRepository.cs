using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SettlerOfCatan.Repository;
//using SettlerOfCatan.Models;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_HexagonTileRoadRepository
    {

        //[TestMethod]
        //public void FirstTurnCanPutSettlementAtTopLeftCornerWhenEmpty()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };


        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel, true);

        //    //Assert
        //    Assert.AreEqual(can, true);
        //}

        //[TestMethod]
        //public void FirstTurnCanPutSettlementAtTopLeftCornerWhenTopRightUsed()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 };
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel, true);

        //    //Assert
        //    Assert.AreEqual(can, false);
        //}

        //[TestMethod]
        //public void FirstTurnCanPutSettlementAtTopLeftCornerWhenMiddleLefttUsed()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 };
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel, true);

        //    //Assert
        //    Assert.AreEqual(can, false);
        //}

        //[TestMethod]
        //public void FirstTurnCanPutSettlementAtTopLeftCornerWhenTopRightIsUsedOnnNighbouringHex()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 };
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };


        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel, true);

        //    //Assert
        //    Assert.AreEqual(can, false);
        //}

        //[TestMethod]
        //public void FirstTurnCanPutSettlementAtTopLeftCornerWhenUsed()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 };
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel, true);

        //    //Assert
        //    Assert.AreEqual(can, false);
        //}

        //[TestMethod]
        //public void NotFirstTurnCanPutSettlementAtTopLeftCornerWhenEmpty()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel);

        //    //Assert
        //    Assert.AreEqual(can, true);
        //}

        //[TestMethod]
        //public void NotFirstTurnCanPutSettlementAtTopLeftCornerWhenUsed()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 };
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel);

        //    //Assert
        //    Assert.AreEqual(can, false);
        //}

        //[TestMethod]
        //public void NotFirstTurnCanPutSettlementAtTopLeftCornerWhenOtherPlayersRoadRunsThroughtIt()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.NorthSideRoadOwner = 2;
        //    hexagonTile.HexagonTileModel.NorthWestSideRoadOwner = 2;
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel);

        //    //Assert
        //    Assert.AreEqual(can, false);
        //}

        //[TestMethod]
        //public void NotFirstTurnCanPutSettlementAtTopLeftCornerWhenPlayersRoadRunsThroughtIt()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.NorthSideRoadOwner = 1;
        //    hexagonTile.HexagonTileModel.NorthWestSideRoadOwner = 1;
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel);

        //    //Assert
        //    Assert.AreEqual(can, true);
        //}

        //[TestMethod]
        //public void NotFirstTurnCanPutSettlementAtTopLeftCornerWhenLeftBelongToPlayerRightBelongToOtherPlayer()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.NorthSideRoadOwner = 1;
        //    hexagonTile.HexagonTileModel.NorthWestSideRoadOwner = 2;
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel);

        //    //Assert
        //    Assert.AreEqual(can, true);
        //}

        //[TestMethod]
        //public void NotFirstTurnCanPutSettlementAtTopLeftCornerWhenRightBelongToPlayerLeftBelongToOtherPlayer()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.NorthSideRoadOwner = 2;
        //    hexagonTile.HexagonTileModel.NorthWestSideRoadOwner = 1;
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel);

        //    //Assert
        //    Assert.AreEqual(can, true);
        //}


        //[TestMethod]
        //public void NotFirstTurnCanPutSettlementAtTopLeftCornerWhenAllThreeRoadBelongToPlayer()
        //{
        //    //Arrange 
        //    HexagonTileRoadRepository hexagonTile = new HexagonTileRoadRepository(new HexagonTileModel());
        //    hexagonTile.HexagonTileModel.NorthSideRoadOwner = 1;
        //    hexagonTile.HexagonTileModel.NorthWestSideRoadOwner = 1;
        //    HexagonTileModel hexagonTileModel = new HexagonTileModel() { NorthEastSideRoadOwner = 1 };

        //    //Act 
        //    bool can = hexagonTile.CanPutSettlementAtTopLeftCorner(1, hexagonTileModel);

        //    //Assert
        //    Assert.AreEqual(can, true);
        //}




    }
}
