//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Repositry.Repository;
//using Repositry.Models;
//using Repositry.Model;
////using SettlerOfCatan.Repository;
////using SettlerOfCatan.Models;

//namespace UnitTestSettlersOfCatan.HexagonTileTest
//{
//    [TestClass]
//    public class Test_HexagonTileRepositry_CanPutSettlemt
//    {

//        #region First Turn Is True

//        #region GotSettlemtByThisPlayer

//        #region Middle Bottom Hex

//        [TestMethod]
//        public void MiddleBottomHexAllEmpty()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
            
//           // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, true);

//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.PlayerID = 1;

//            //helper.FirstTurn = true;

//            ////Act 
//            //bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;
                       
//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }


//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, true);

//            //Assert
//     //       Assert.AreEqual(can, true);
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);

//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, true);

//            //Assert
//           // Assert.AreEqual(can, true);
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, true);

//            //Assert
//          //  Assert.AreEqual(can, true);
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();


//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, true);


//            //Assert
//           // Assert.AreEqual(can, false);

//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.TopHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();
            
//            //Act 
//        //    bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, true);

//            //Assert
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }

//#endregion

//        #region Top Middle Hex


//        [TestMethod]
//        public void TopMiddleHexAllEmpty()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = null;
//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }


//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }


//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomRightGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopLeftGotSettlemtByThisPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        #endregion

//        #region Top Middle Bottom Hex

//        [TestMethod]
//        public void TopMiddleBottomHexAllEmpty()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
           
//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
          
//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        #region top

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopLeftGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomLefttGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleLefttGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region middle


//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopLeftGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomLefttGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleLefttGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        #endregion

//        #region bottom


//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopLeftGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomRightGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomLefttGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleLefttGotSettlemtByThisPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 1;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #endregion

//        #endregion

//        #region GotSettlemtByOtherPlayer

//        #region Middle Bottom Hex


//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 2;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//         //   bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 2, true);

//            //Assert
//         //   Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");


//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 2;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 2, true);

//            //Assert
//          //  Assert.AreEqual(can, false);

//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");

//        }


//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 2;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();


//            //Act 
//         //   bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 2, true);


//            //Assert
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 2;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//            //bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 2, true);

//            //Assert
//           // Assert.AreEqual(can, true);
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 2;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 2, true);

//            //Assert
//           // Assert.AreEqual(can, true);

//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 2;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();


//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 2, true);

//            //Assert
//         //   Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.TopHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = true;
//            //helper.PlayerID = 2;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//         //   bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 2, true);

//            //Assert
//           // Assert.AreEqual(can, true);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }

//        #endregion

//        #region Top Middle Hex

//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }


//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomRightGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopLeftGotSettlemtByOtherPlayer()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = true;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        #endregion

//        #region Top Middle Bottom Hex


//        #region top

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopLeftGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomLefttGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleLefttGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region middle


//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopLeftGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomLefttGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleLefttGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        #endregion

//        #region bottom


//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopLeftGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomRightGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomLefttGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, true);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleLefttGotSettlemtByOtherPlayery()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = true;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #endregion

//        #endregion

//        #endregion

//        #region First Turn Is False

//        #region GotSettlemtByThisPlayer

//        #region Middle Bottom Hex

//        [TestMethod]
//        public void MiddleBottomHexAllEmptyFirstTurnIsFalse()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.PlayerID = 1;
//            //helper.FirstTurn = false;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();
           

//            //Act 
//            //bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//            Assert.AreEqual(canPut.IsValid, true); 
//            Assert.AreEqual(canPut.ErrorMessage, null);

//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();


//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//          //  Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//          //  Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);

//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();


//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//           // Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }


//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//            //bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();


//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//       //     Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();
//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//          //  Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();
//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//         //   Assert.AreEqual(can, false);

//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.TopHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();
//            //Act 
//           // bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert

//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");


//        }

//        #endregion

//        #region Top Middle Hex

//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }


//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomRightGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopLeftGotSettlemtByThisPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region Top Middle Bottom Hex


//        #region top

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopLeftGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomLefttGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleLefttGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region middle


//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopLeftGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomLefttGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleLefttGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region bottom


//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopLeftGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomRightGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomLefttGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleLefttGotSettlemtByThisPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #endregion

//#endregion

//        #region GotSettlemtByOtherPlayer

//        #region Middle Bottom Hex

//        [TestMethod]
//        public void MiddleBottomHexAllEmptyFirstTurnIsFalseNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.PlayerID = 1;
//            //helper.FirstTurn = false;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//           //bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);


//            //Assert
//         //   Assert.AreEqual(can, false);

//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//          //  Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");


//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexBottomLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//            //bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//            Assert.AreEqual(canPut.IsValid, true);
//            Assert.AreEqual(canPut.ErrorMessage, null);

//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexMiddleLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexMiddleHexTopLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.TopHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 1;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//           // Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }


//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//      //      bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert

//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");

//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();


//            //Act 
//         //   bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//          //  Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");

//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexBottomLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();

//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);

//            //Assert
//           // Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexMiddleLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.BottomHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();
//            //Act 
//            //bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, true);

//            //Assert
//           // Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "Corner already has Settlement or Cities");
//        }

//        [TestMethod]
//        public void MiddleBottomHexBottomHexTopLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
//            //HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            //helper.TopHexagonTile = null;
//            //helper.MiddleHexagonTile = middleHexagonTile;
//            //helper.TopHexagonTile = bottomHexagonTile;
//            //helper.FirstTurn = false;
//            //helper.PlayerID = 1;
//            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner();



//            //Act 
//          //  bool can = helper.CanPutSettlementAtMiddleRightCorner();
//            var canPut = canPutValidator.IsValid(null, middleHexagonTile, bottomHexagonTile, 1, false);


//            //Assert
//         //   Assert.AreEqual(can, false);
//            Assert.AreEqual(canPut.IsValid, false);
//            Assert.AreEqual(canPut.ErrorMessage, "No adjacent Settlement or Cities");

//        }

//        #endregion

//        #region Top Middle Hex

//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexBottomLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexMiddleLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexMiddleHexTopLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }


//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomRightGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexBottomLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexMiddleLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleHexTopHexTopLeftGotSettlemtByOtherPlayerNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
//            helper.BottomHexagonTile = null;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.TopHexagonTile = topHexagonTile;
//            helper.FirstTurn = false;
//            helper.PlayerID = 2;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region Top Middle Bottom Hex


//        #region top

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopLeftGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexTopRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexBottomLefttGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexTopHexMiddleLefttGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region middle


//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopLeftGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexTopRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexBottomLefttGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexMiddleHexMiddleLefttGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #region bottom


//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopLeftGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexTopRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert 
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomRightGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexBottomLefttGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        [TestMethod]
//        public void TopMiddleBottomHexBottomHexMiddleLefttGotSettlemtByOtherPlayeryNotFirstTime()
//        {
//            //Arrange 
//            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
//            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
//            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

//            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

//            helper.TopHexagonTile = topHexagonTile;
//            helper.MiddleHexagonTile = middleHexagonTile;
//            helper.BottomHexagonTile = bottomHexagonTile;

//            helper.PlayerID = 2;

//            helper.FirstTurn = false;

//            //Act 
//            bool can = helper.CanPutSettlementAtMiddleRightCorner();

//            //Assert
//            Assert.AreEqual(can, false);
//        }

//        #endregion

//        #endregion
        
//        #endregion

//        #endregion

//    }
//}
