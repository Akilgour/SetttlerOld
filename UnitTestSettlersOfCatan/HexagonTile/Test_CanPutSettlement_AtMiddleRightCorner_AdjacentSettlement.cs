using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Model;
using Repositry.Repository;
using Repositry.Models;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement
    {

        [TestMethod]
        public void AllEmpty()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_FirstTurn();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



        #region topHexagonTile

        [TestMethod]
        public void ThisPlayertopHexagonTile_TopLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



        [TestMethod]
        public void ThisPlayertopHexagonTile_TopRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }


        [TestMethod]
        public void ThisPlayertopHexagonTile_MiddleRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void ThisPlayertopHexagonTile_BottomRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }

        [TestMethod]
        public void ThisPlayertopHexagonTile_BottomLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void ThisPlayertopHexagonTile_MiddleLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }
        #endregion

        #region middleHexagonTile

        [TestMethod]
        public void ThisPlayermiddleHexagonTile_TopLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



        [TestMethod]
        public void ThisPlayermiddleHexagonTile_TopRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }


        [TestMethod]
        public void ThisPlayermiddleHexagonTile_MiddleRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void ThisPlayermiddleHexagonTile_BottomRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }

        [TestMethod]
        public void ThisPlayermiddleHexagonTile_BottomLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);

        }

        [TestMethod]
        public void ThisPlayermiddleHexagonTile_MiddleLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }
        #endregion

        #region bottomHexagonTile

        [TestMethod]
        public void ThisPlayerbottomHexagonTile_TopLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



        [TestMethod]
        public void ThisPlayerbottomHexagonTile_TopRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }


        [TestMethod]
        public void ThisPlayerbottomHexagonTile_MiddleRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void ThisPlayerbottomHexagonTile_BottomRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void ThisPlayerbottomHexagonTile_BottomLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);

        }

        [TestMethod]
        public void ThisPlayerbottomHexagonTile_MiddleLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }
        #endregion


        #region topHexagonTile

        [TestMethod]
        public void OtherPlayerThisPlayertopHexagonTile_TopLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



        [TestMethod]
        public void OtherPlayerThisPlayertopHexagonTile_TopRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }


        [TestMethod]
        public void OtherPlayerThisPlayertopHexagonTile_MiddleRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void OtherPlayerThisPlayertopHexagonTile_BottomRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }

        [TestMethod]
        public void OtherPlayerThisPlayertopHexagonTile_BottomLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void OtherPlayerThisPlayertopHexagonTile_MiddleLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }
        #endregion

        #region middleHexagonTile

        [TestMethod]
        public void OtherPlayerThisPlayermiddleHexagonTile_TopLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



        [TestMethod]
        public void OtherPlayerThisPlayermiddleHexagonTile_TopRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }


        [TestMethod]
        public void OtherPlayerThisPlayermiddleHexagonTile_MiddleRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void OtherPlayerThisPlayermiddleHexagonTile_BottomRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }

        [TestMethod]
        public void OtherPlayerThisPlayermiddleHexagonTile_BottomLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);

        }

        [TestMethod]
        public void OtherPlayerThisPlayermiddleHexagonTile_MiddleLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }
        #endregion

        #region bottomHexagonTile

        [TestMethod]
        public void OtherPlayerThisPlayerbottomHexagonTile_TopLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert

            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



        [TestMethod]
        public void OtherPlayerThisPlayerbottomHexagonTile_TopRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }


        [TestMethod]
        public void OtherPlayerThisPlayerbottomHexagonTile_MiddleRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void OtherPlayerThisPlayerbottomHexagonTile_BottomRightCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }

        [TestMethod]
        public void OtherPlayerThisPlayerbottomHexagonTile_BottomLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);

        }

        [TestMethod]
        public void OtherPlayerThisPlayerbottomHexagonTile_MiddleLeftCorner()
        {
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_AdjacentSettlement();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);

            //Assert
            Assert.AreEqual(canPut.IsValid, false);
            Assert.AreEqual(canPut.ErrorMessage, "Corner has adjacent Settlement");
        }
        #endregion
    }
}
