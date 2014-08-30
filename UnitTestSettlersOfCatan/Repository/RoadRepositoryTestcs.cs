using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Repository;
using UnitTestSettlersOfCatan.Factory.Validation;
using Repositry.Interface;
using System.Collections.Generic;
using Repositry.Model;
using Repositry.Models;

namespace UnitTestSettlersOfCatan.Repository
{
    [TestClass]
    public class RoadRepositoryTestcs
    {
        #region TestsWithMocks

        [TestMethod]
        public void RoadRepository_IsValid_NoRules()
        {
            var roadRepository = new RoadRepository();


            var canPut = roadRepository.CanPutRoad(null,null,null,1);

              Assert.AreEqual(canPut, null);
        }

        [TestMethod]
        public void RoadRepository_IsValid_ValidTrue()
        {
         
            var roadRepository = new RoadRepository(new List<IValidationRoad>(){new ValidationTrueNoMessage()});

            var canPut = roadRepository.CanPutRoad(null,null,null,1);

           // Assert.AreEqual(canPut[0].IsValid, true);
          //  Assert.AreEqual(canPut[0].ErrorMessage, null);
            Assert.AreEqual(canPut, null);
        }

        [TestMethod]
        public void RoadRepository_IsValid_ValidFalseMessageFoo()
        {
            var roadRepository = new RoadRepository(new List<IValidationRoad>(){new ValidationFalseMessageFoo()});

            var canPut = roadRepository.CanPutRoad(null, null, null, 1);

            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "Foo");
        }

        [TestMethod]
        public void RoadRepository_IsValid_ValidFalseMessageBar()
        {
            var roadRepository = new RoadRepository(new List<IValidationRoad>(){new ValidationFalseMessageBar()});

            var canPut = roadRepository.CanPutRoad(null, null, null, 1);

            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "Bar");
        }


        [TestMethod]
        public void RoadRepository_IsValid_ValidFalseMessageBarFoo()
        {
            var roadRepository = new RoadRepository(new List<IValidationRoad>() { new ValidationFalseMessageBar(), new ValidationFalseMessageFoo() });

            var canPut = roadRepository.CanPutRoad(null, null, null, 1);

            Assert.AreEqual(canPut.Count, 2);

            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "Bar");

            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "Foo");
        }


        [TestMethod]
        public void RoadRepository_IsValid_ValidFalseMessageFooBar()
        {
            var roadRepository = new RoadRepository(new List<IValidationRoad>() { new ValidationFalseMessageFoo(), new ValidationFalseMessageBar() });

            var canPut = roadRepository.CanPutRoad(null, null, null, 1);

            Assert.AreEqual(canPut.Count, 2);

            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "Foo");

            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "Bar");
        }

        [TestMethod]
        public void RoadRepository_IsValid_ValidFalseMessageFooBaroneTrue()
        {
            var roadRepository = new RoadRepository(new List<IValidationRoad>() { new ValidationFalseMessageFoo(), new ValidationFalseMessageBar(), new ValidationTrueNoMessage() });

            var canPut = roadRepository.CanPutRoad(null, null, null, 1);

            Assert.AreEqual(canPut.Count, 2);

            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "Foo");

            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "Bar");
        }

        [TestMethod]
        public void RoadRepository_IsValid_ValidationTrueNoMessageThreeTimes()
        {
            var roadRepository = new RoadRepository(new List<IValidationRoad>() { new ValidationTrueNoMessage(), new ValidationTrueNoMessage(), new ValidationTrueNoMessage() });

            var canPut = roadRepository.CanPutRoad(null, null, null, 1);

            Assert.AreEqual(canPut, null);


        }

        #endregion


        [TestMethod]
        public void RoadRepository_IsValid_AllHexsNull()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();

            var canPutRoadEast_BottomHexagonTile = new CanPutRoadEast_BottomHexagonTile();
            var canPutRoadEast_TopHexagonTile = new CanPutRoadEast_TopHexagonTile();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();
            var canPutRoadSouthWest_BottomHexagonTile = new CanPutRoadSouthWest_BottomHexagonTile();
            var canPutRoadSouthWest_MiddleHexagonTile = new CanPutRoadSouthWest_MiddleHexagonTile();

            var validationList = new List<IValidationRoad>() { canPutRoad_DataValid,
                canPutRoadEast_BottomHexagonTile,
                canPutRoadEast_TopHexagonTile,
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,
                canPutRoadSouthWest_BottomHexagonTile,
                canPutRoadSouthWest_MiddleHexagonTile
            };

            var roadRepository = new RoadRepository( validationList );
            var canPut = roadRepository.CanPutRoad(null, null, null, 1);
            Assert.AreEqual(canPut[0].ErrorMessage, "At least one hexagon has to be set");
        }

        #region Top Hex
        [TestMethod]
        public void RoadRepository_IsValid_TopHex()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();           
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();
   
            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel();

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut.Count, 1);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_SettlementAtBottomLeftCornerForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut, null);
  
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_CityAtBottomLeftCornerForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_SettlementAtBottomLeftCornerForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut.Count, 1);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_CityAtBottomLeftCornerForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut.Count, 1);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_SettlementAtBottomLeftCornerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_CityAtBottomLeftCornerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_SettlementAtBottomLeftCornerAndMiddleLeftForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 }, MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut.Count, 1);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_CityAtBottomLeftCornerAndMiddleLeftForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 }, MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut.Count, 1);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_SettlementAtBottomLeftCornerOtherPlayerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHex_CityAtBottomLeftCornerOtherPlayerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut, null);

        }
        #endregion

        #region TopMiddleHex


        [TestMethod]
        public void RoadRepository_IsValid_TopHexMidHex()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel();
            HexagonTileModel midHexagonTile = new HexagonTileModel();

            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut.Count, 2);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");

            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "No adjacent Settlement or Cities");
   
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_SettlementAtBottomLeftCornerForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_CityAtBottomLeftCornerForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };

            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_SettlementAtBottomLeftCornerForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut.Count, 2);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");

            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_CityAtBottomLeftCornerForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut.Count, 2);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");

            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "No adjacent Settlement or Cities");

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_SettlementAtBottomLeftCornerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 }, TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 } };

            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_CityAtBottomLeftCornerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel tophexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 }, TopRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 } };


            var canPut = roadRepository.CanPutRoad(tophexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_SettlementAtBottomLeftCornerAndMiddleLeftForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 }, MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 }, TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut.Count, 2);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");

            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_CityAtBottomLeftCornerAndMiddleLeftForOtherPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel tophexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 }, MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 }, TopRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };

            var canPut = roadRepository.CanPutRoad(tophexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut.Count, 2);
            Assert.AreEqual(canPut[0].IsValid, false);
            Assert.AreEqual(canPut[0].ErrorMessage, "No adjacent Settlement or Cities");
 
            Assert.AreEqual(canPut[1].IsValid, false);
            Assert.AreEqual(canPut[1].ErrorMessage, "No adjacent Settlement or Cities");
        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_SettlementAtBottomLeftCornerOtherPlayerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel hexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 1 }, TopRightCorner = new CornerTypeModel() { HasSettlement = true, OwnerID = 2 } };


            var canPut = roadRepository.CanPutRoad(hexagonTile, null, null, 1);

            Assert.AreEqual(canPut, null);

        }

        [TestMethod]
        public void RoadRepository_IsValid_TopHexMiddleHex_CityAtBottomLeftCornerOtherPlayerAndMiddleLeftForThisPlayer()
        {
            var canPutRoad_DataValid = new CanPutRoad_DataValid();
            var canPutRoadNorthWeast_MiddleHexagonTile = new CanPutRoadNorthWeast_MiddleHexagonTile();
            var canPutRoadNorthWeast_TopHexagonTile = new CanPutRoadNorthWeast_TopHexagonTile();

            var validationList = new List<IValidationRoad>() { 
                canPutRoad_DataValid,           
                canPutRoadNorthWeast_MiddleHexagonTile,
                canPutRoadNorthWeast_TopHexagonTile,            
            };

            var roadRepository = new RoadRepository(validationList);

            HexagonTileModel topHexagonTile = new HexagonTileModel() { BottomLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 }, MiddleLeftCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };
            HexagonTileModel midHexagonTile = new HexagonTileModel() { MiddleRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 1 }, TopRightCorner = new CornerTypeModel() { HasCity = true, OwnerID = 2 } };


            var canPut = roadRepository.CanPutRoad(topHexagonTile, midHexagonTile, null, 1);

            Assert.AreEqual(canPut, null);

        }
    
    

        #endregion

    }
}
