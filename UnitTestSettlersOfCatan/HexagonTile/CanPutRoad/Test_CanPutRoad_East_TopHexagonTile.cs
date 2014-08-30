using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Repository;
using Repositry.Model;
using Repositry.Models;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutRoad_East_TopHexagonTile
    {
        [TestMethod]
        public void TopHex_PlayerHasSettlementAtBottomLeftCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            //  Assert.AreEqual(canPut, true);
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_PlayerHasCityAtBottomLeftCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            //  Assert.AreEqual(canPut, true);
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_PlayerHasSettlementAtBottomRightCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
            //  Assert.AreEqual(canPut, true);
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_PlayerHasCityAtBottomRightCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
          //  Assert.AreEqual(canPut, true);
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasSettlementAtBottomLeftCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel, null, null, 1);

            //Assert
           // Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasCityAtBottomLeftCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel ,null, null,  1);

            //Assert
         //   Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasSettlementAtBottomRightCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel,null, null, 1);

            //Assert
         //   Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void TopHex_OtherPlayerHasCityAtBottomRightCorner()
        {
            var topHexagonTileModel = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(topHexagonTileModel,null, null,  1);

            //Assert
         //   Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }


        [TestMethod]
        public void TopHex_Null()
        {
            //Assert
            var canPutRoadNorthWeast = new CanPutRoadEast_TopHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }
    }
}
