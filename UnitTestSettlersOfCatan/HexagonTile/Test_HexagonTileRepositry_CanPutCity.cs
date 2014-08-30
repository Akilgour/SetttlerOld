using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Repository;
using Repositry.Models;
using Repositry.Model;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_HexagonTileRepositry_CanPutCity
    {

        #region TopHex

        [TestMethod]
        public void TopHexNoSettlemtFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexHasSettlemtForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexHasCityForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexHasSettlemtForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexHasCityForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexNoSettlemtNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexHasSettlemtForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexHasCityForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopHexHasSettlementForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, true);
        }

        [TestMethod]
        public void TopHexHasCityForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        #endregion

        #region MiddleHex

        [TestMethod]
        public void MiddleHexNoSettlemtFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexHasSettlemtForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexHasCityForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexHasSettlemtForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexHasCityForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexNoSettlemtNotFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexHasSettlemtForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexHasCityForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void MiddleHexHasSettlementForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, true);
        }

        [TestMethod]
        public void MiddleHexHasCityForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.MiddleHexagonTile = middleHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        #endregion

        #region BottomHex

        [TestMethod]
        public void BottomHexNoSettlemtFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexHasSettlemtForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexHasCityForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexHasSettlemtForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexHasCityForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexNoSettlemtNotFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexHasSettlemtForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexHasCityForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomHexHasSettlementForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, true);
        }

        [TestMethod]
        public void BottomHexHasCityForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel BottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            helper.TopHexagonTile = null;
            helper.BottomHexagonTile = BottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        #endregion

        #region TopMiddleHex

        [TestMethod]
        public void TopMiddleHexNoSettlemtFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexHasSettlemtForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexHasCityForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexHasSettlemtForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexHasCityForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexNoSettlemtNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexHasSettlemtForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexHasCityForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopMiddleHexHasSettlementForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();


            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, true);
        }

        [TestMethod]
        public void TopMiddleHexHasCityForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();


            helper.MiddleHexagonTile = middleHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        #endregion

        #region TopBottomHex

        [TestMethod]
        public void TopBottomHexNoSettlemtFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexHasSettlemtForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexHasCityForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexHasSettlemtForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexHasCityForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexNoSettlemtNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexHasSettlemtForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexHasCityForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void TopBottomHexHasSettlementForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();


            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, true);
        }

        [TestMethod]
        public void TopBottomHexHasCityForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();


            helper.BottomHexagonTile = bottomHexagonTile;
            helper.TopHexagonTile = topHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        #endregion

        #region MiddleBottomHex

        [TestMethod]
        public void BottomMiddleHexNoSettlemtFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexHasSettlemtForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexHasCityForOtherPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexHasSettlemtForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexHasCityForThisPlayerFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = true;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexNoSettlemtNotFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexHasSettlemtForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexHasCityForOtherPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();

            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        [TestMethod]
        public void BottomMiddleHexHasSettlementForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();


            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, true);
        }

        [TestMethod]
        public void BottomMiddleHexHasCityForThisPlayerNotFristTurn()
        {
            //Arrange 
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();


            helper.MiddleHexagonTile = middleHexagonTile;
            helper.BottomHexagonTile = bottomHexagonTile;
            helper.PlayerID = 1;

            helper.FirstTurn = false;

            //Act 
            bool can = helper.CanPutCityAtMiddleRightCorner();

            //Assert
            Assert.AreEqual(can, false);
        }

        #endregion

    }
}
