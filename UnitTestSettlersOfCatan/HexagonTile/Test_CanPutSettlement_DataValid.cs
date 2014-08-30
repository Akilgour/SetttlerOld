//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Repositry.Repository;
//using Repositry.Model;
//using Repositry.Models;

//namespace UnitTestSettlersOfCatan.HexagonTile
//{
//    [TestClass]
//    public class Test_CanPutSettlement_DataValid
//    {

//        [TestMethod]
//        public void NoHex()
//        {
//            //Assert
//            CanPutSettlement_DataValid canPutRoadNorthWeast = new CanPutSettlement_DataValid();

//            //Act 
//            var canPut = canPutRoadNorthWeast.IsValid(null, null, null, 1, false);

//            //Assert
//            //ExpectedException
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "At least one hexagon has to be set");
//        }

//        [TestMethod]
//        public void HasFirstHex()
//        {
//            //Assert
//            CanPutSettlement_DataValid canPutRoadNorthWeast = new CanPutSettlement_DataValid();
//            var hex = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

//            //Act 
//            var canPut = canPutRoadNorthWeast.IsValid(hex, null, null, 1, false);

//            //Assert
//            //ExpectedException
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }

//        [TestMethod]
//        public void HasSecondHex()
//        {
//            //Assert
//            CanPutSettlement_DataValid canPutRoadNorthWeast = new CanPutSettlement_DataValid();
//            var hex = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

//            //Act 
//            var canPut = canPutRoadNorthWeast.IsValid(null, hex, null, 1, false);

//            //Assert
//            //ExpectedException
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }


//        [TestMethod]
//        public void HasThirdHex()
//        {
//            //Assert
//            CanPutSettlement_DataValid canPutRoadNorthWeast = new CanPutSettlement_DataValid();
//            var hex = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

//            //Act 
//            var canPut = canPutRoadNorthWeast.IsValid(null, null, hex, 1, false);

//            //Assert
//            //ExpectedException
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }



//    }
//}
