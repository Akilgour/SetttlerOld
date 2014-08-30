using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Repository;
using Repositry.Model;
using Repositry.Models;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutRoad_SouthWeast_BottomHexagonTile
    {
        [TestMethod]
        public void BottomHex_PlayerHasSettlementAtTopLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void BottomHex_PlayerHasCityAtTopLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel,  1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void BottomHex_PlayerHasSettlementAtMiddleLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel,  1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void BottomHex_PlayerHasCityAtMiddleLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel,  1);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasSettlementAtTopLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel,  1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");


        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasCityAtTopLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel,  1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");


        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasSettlementAtMiddleLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel,  1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");


        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasCityAtMiddleLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel,  1);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");

                  }

        [TestMethod]
        public void BottomHex_Null()
        {
            //Assert
            var canPutRoadNorthWeast = new CanPutRoadSouthWest_BottomHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }
    }
}
