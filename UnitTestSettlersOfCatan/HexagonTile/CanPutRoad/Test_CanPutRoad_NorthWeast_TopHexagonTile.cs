using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Model;
using Repositry.Repository;
using Repositry.Models;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutRoad_NorthWeast_TopHexagonTile
    {
        [TestMethod]
        public void TopHex_PlayerHasSettlementAtBottomLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_PlayerHasCityAtBottomLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_PlayerHasSettlementAtMiddleLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_PlayerHasCityAtMiddleLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasSettlementAtBottomLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasCityAtBottomLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasSettlementAtMiddleLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasCityAtMiddleLeftCorner()
        {
            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(topHexagonTileModel, null, null,1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }


        [TestMethod]
        public void TopHex_Null()
        {
            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }
    }
}
