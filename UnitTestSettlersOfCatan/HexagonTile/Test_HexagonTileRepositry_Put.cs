//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
////using SettlerOfCatan.Models;
//using UnitTestSettlersOfCatan.Factory.HexagonTileCanPutFactory;
//using Repositry.Interface;
//using Repositry.Repository;
////using SettlerOfCatan.Repository;
////using SettlerOfCatan.Repository.Interface;
////using SettlerOfCatan.Repository.Interface.IHexagonTileCanPutRepository;
////using SettlerOfCatan.Repository;
////using UnitTestSettlersOfCatan.Factory.HexagonTileCanPutFactory;
////using SettlerOfCatan.Repository.Interface;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Interface;
using Repositry.Model;
using Repositry.Repository;
using UnitTestSettlersOfCatan.Factory.HexagonTileCanPutFactory;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_HexagonTileRepositry_Put
    {
        # region No Hex

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void CanPutSettlementFalse()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;
            
            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            //ExpectedException
        }

        [TestMethod]
        public void CanPutSettlementTopHexFalse()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };

            helper.HexagonTileCanPutRepository = canPutHelper;
            helper.TopHexagonTileModel = TopHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner, null);   
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void CanPutSettlementTrue()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            //ExpectedException
        }

        #endregion

        #region TopHex
        [TestMethod]
        public void CanPutSettlementFalseTopHex()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
            Assert.AreEqual(helper.TopHexagonTileModel, TopHexagonTileModel);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner, null);
       
        }

        [TestMethod]
        public void CanPutSettlementTrueTopHex_HasSettlement()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;
            
            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasCity, false);   
        }

        [TestMethod]
        public void CanPutSettlementTrueTopHex_PlayerOne()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;
            helper.PlayerID = 1;
           

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 1);
             
        }

        [TestMethod]
        public void CanPutSettlementTrueTopHex_PlayerTwo()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;
            helper.PlayerID = 2;
            
            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 2);
        }
        #endregion

        #region MiddleHex

        [TestMethod]
        public void CanPutSettlementFalseMiddleHex()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel hexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = hexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner, null);
       
        }

        [TestMethod]
        public void CanPutSettlementTrueMiddleHex_HasSettlement()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;
            
            HexagonTileModel hexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = hexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasSettlement, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasCity, false);   
        }

        [TestMethod]
        public void CanPutSettlementTrueMiddleHex_PlayerOne()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel hexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = hexagonTileModel;
            helper.PlayerID = 1;
           

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 1);
             
        }

        [TestMethod]
        public void CanPutSettlementTrueMiddleHex_PlayerTwo()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel hexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = hexagonTileModel;
            helper.PlayerID = 2;
            
            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 2);
        }


        #endregion

        #region BottomHex
        [TestMethod]
        public void CanPutSettlementFalseBottomHex()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel BottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = BottomHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
            Assert.AreEqual(helper.BottomHexagonTileModel, BottomHexagonTileModel);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopRightCorner, null);

        }

        [TestMethod]
        public void CanPutSettlementTrueBottomHex_HasSettlement()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel BottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = BottomHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasCity, false);
        }

        [TestMethod]
        public void CanPutSettlementTrueBottomHex_PlayerOne()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel BottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = BottomHexagonTileModel;
            helper.PlayerID = 1;


            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 1);

        }

        [TestMethod]
        public void CanPutSettlementTrueBottomHex_PlayerTwo()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel BottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = BottomHexagonTileModel;
            helper.PlayerID = 2;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 2);
        }
        #endregion

        #region Top Middle Hex
        [TestMethod]
        public void CanPutSettlementFalseTopMiddleHex()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = topHexagonTileModel;

            HexagonTileModel midHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = midHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
            Assert.AreEqual(helper.TopHexagonTileModel, topHexagonTileModel);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner, null);

            Assert.AreEqual(helper.MiddleHexagonTileModel, midHexagonTileModel);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner, null);

        }

        [TestMethod]
        public void CanPutSettlementTrueTopMiddle_HasSettlement()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;

            HexagonTileModel midHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = midHexagonTileModel;

            
            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasCity, false);

            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasSettlement, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasCity, false);
        }

        [TestMethod]
        public void CanPutSettlementTrueTopMiddle_PlayerOne()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;
            helper.PlayerID = 1;

            HexagonTileModel midHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = midHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 1);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 1);
        }

        [TestMethod]
        public void CanPutSettlementTrueTopMiddle_PlayerTwo()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;

            HexagonTileModel midHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = midHexagonTileModel;
            
            helper.PlayerID = 2;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 2);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 2);
        }
        #endregion

        #region Top Bottom Hex
        [TestMethod]
        public void CanPutSettlementFalseTopBottomHex()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
            Assert.AreEqual(helper.TopHexagonTileModel, TopHexagonTileModel);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner, null);

            Assert.AreEqual(helper.BottomHexagonTileModel, bottomHexagonTileModel);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner, null);

        }

        [TestMethod]
        public void CanPutSettlementTrueTopBottom_HasSettlement()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasCity, false);

            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasCity, false);
        }

        [TestMethod]
        public void CanPutSettlementTrueTopBottom_PlayerOne()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;
            helper.PlayerID = 1;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 1);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 1);

        }

        [TestMethod]
        public void CanPutSettlementTrueTopBottom_PlayerTwo()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel TopHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = TopHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            helper.PlayerID = 2;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 2);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 2);

        }
        #endregion


        #region Middle Bottom Hex
        [TestMethod]
        public void CanPutSettlementFalseMiddleBottomHex()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;
             
            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
             
            Assert.AreEqual(helper.MiddleHexagonTileModel, MiddleHexagonTileModel);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner, null);

            Assert.AreEqual(helper.BottomHexagonTileModel, bottomHexagonTileModel);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner, null);

        }

        [TestMethod]
        public void CanPutSettlementTrueMiddleBottom_HasSettlement()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            //Ai8ct 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasSettlement, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasCity, false);

            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasCity, false);
        }

        [TestMethod]
        public void CanPutSettlementTrueMiddleBottom_PlayerOne()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;
            helper.PlayerID = 1;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 1);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 1);

        }

        [TestMethod]
        public void CanPutSettlementTrueMiddleBottom_PlayerTwo()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            helper.PlayerID = 2;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 2);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 2);

        }
        #endregion

        #region Top Middle Bottom Hex
        [TestMethod]
        public void CanPutSettlementFalseTopMiddleBottomHex()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllFalse();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = topHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, false);
            Assert.AreEqual(helper.MiddleHexagonTileModel, MiddleHexagonTileModel);
            Assert.AreEqual(helper.MiddleHexagonTileModel.BottomLeftCorner, null);

            Assert.AreEqual(helper.BottomHexagonTileModel, bottomHexagonTileModel);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner, null);

            Assert.AreEqual(helper.TopHexagonTileModel, topHexagonTileModel);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner, null);
        }

        [TestMethod]
        public void CanPutSettlementTrueTopMiddleBottom_HasSettlement()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = topHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasSettlement, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.HasCity, false);

            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.HasCity, false);

            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasSettlement, true);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.HasCity, false);
        }

        [TestMethod]
        public void CanPutSettlementTrueTopMiddleBottom_PlayerOne()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;
            helper.PlayerID = 1;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = topHexagonTileModel;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 1);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 1);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 1);

        }

        [TestMethod]
        public void CanPutSettlementTrueTopMiddleBottom_PlayerTwo()
        {
            //Arrange 
            var canPutHelper = new HexagonTileCanPutRepositoryAllTrue();
            var helper = new HexagonTilePutRepository();
            helper.HexagonTileCanPutRepository = canPutHelper;

            HexagonTileModel MiddleHexagonTileModel = new HexagonTileModel() { };
            helper.MiddleHexagonTileModel = MiddleHexagonTileModel;

            HexagonTileModel bottomHexagonTileModel = new HexagonTileModel() { };
            helper.BottomHexagonTileModel = bottomHexagonTileModel;

            HexagonTileModel topHexagonTileModel = new HexagonTileModel() { };
            helper.TopHexagonTileModel = topHexagonTileModel;

            helper.PlayerID = 2;

            //Act 
            bool can = helper.PutSettlementAtMiddleRightCorner();

            ////Assert
            Assert.AreEqual(can, true);
            Assert.AreEqual(helper.MiddleHexagonTileModel.MiddleRightCorner.OwnerID, 2);
            Assert.AreEqual(helper.BottomHexagonTileModel.TopLeftCorner.OwnerID, 2);
            Assert.AreEqual(helper.TopHexagonTileModel.BottomLeftCorner.OwnerID, 2);

        }
        #endregion


    }
}
