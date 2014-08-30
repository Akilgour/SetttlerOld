using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Model;
using Repositry.Models;
using Repositry.Repository;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutRoad_East_BottomHexagonTile
    {
        [TestMethod]
        public void BottomHex_PlayerHasSettlementAtTopLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

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
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void BottomHex_PlayerHasSettlementAtTopRightCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void BottomHex_PlayerHasCityAtTopRightCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasSettlementAtTopLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert
           // Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasCityAtTopLeftCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert
            //Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasSettlementAtTopRightCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert
         //   Assert.AreEqual(canPut, false);
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void BottomHex_OtherPlayerHasCityAtTopRightCorner()
        {
            var bottomHexagonTileModel = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            //Assert
            var canPutValidator = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutValidator.IsValid(null, null, bottomHexagonTileModel, 1);

            //Assert
            //Assert.AreEqual(canPut, false);//
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
        }


        [TestMethod]
        public void BottomHex_Null()
        {
         
            //Assert
            var canPutRoadNorthWeast = new CanPutRoadEast_BottomHexagonTile();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, null, null, 1);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }
    }
}
