using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Repository;
using Repositry.Models;
using Repositry.Model;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutRoad_DataValid
    {
        [TestMethod]
         public void NoHex()
        {
            //Assert
            CanPutRoad_DataValid canPutRoadNorthWeast = new CanPutRoad_DataValid();

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, null, null, 1);

            //Assert
            //ExpectedException
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "At least one hexagon has to be set");
        }

        [TestMethod]
        public void HasFirstHex()
        {
            //Assert
            CanPutRoad_DataValid canPutRoadNorthWeast = new CanPutRoad_DataValid();
            var hex = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(hex, null, null, 1);

            //Assert
            //ExpectedException
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void HasSecondHex()
        {
            //Assert
            CanPutRoad_DataValid canPutRoadNorthWeast = new CanPutRoad_DataValid();
            var hex = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, hex, null, 1);

            //Assert
            //ExpectedException
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }


        [TestMethod]
        public void HasThirdHex()
        {
            //Assert
            CanPutRoad_DataValid canPutRoadNorthWeast = new CanPutRoad_DataValid();
            var hex = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            //Act 
            var canPut = canPutRoadNorthWeast.IsValid(null, null, hex, 1);

            //Assert
            //ExpectedException
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

    }
}
