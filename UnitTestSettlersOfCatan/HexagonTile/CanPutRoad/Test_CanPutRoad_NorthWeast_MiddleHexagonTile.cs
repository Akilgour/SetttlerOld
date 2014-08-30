using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Model;
using Repositry.Models;
using Repositry.Repository;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutRoad_NorthWeast_MiddleHexagonTile
    {
        [TestMethod]
        public void MiddleHex_PlayerHasSettlementAtMiddleRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void MiddleHex_PlayerHasCityAtMiddleRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void MiddleHex_PlayerHasSettlementAtTopRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void MiddleHex_PlayerHasCityAtTopRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void MiddleHex_OtherPlayerHasSettlementAtMiddleRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void MiddleHex_OtherPlayerHasCityAtMiddleRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert
            //  Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void MiddleHex_OtherPlayerHasSettlementAtTopRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void MiddleHex_OtherPlayerHasCityAtTopRightCorner()
        {
            var middleHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, middleHexagonTileModel, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void MiddleHex_Null()
        {

            //Assert
            var canPutRoadNorthWeast = new CanPutRoadNorthWeast_MiddleHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }
  
    
    }
}
