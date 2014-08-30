using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Repositry.Repository;
using Repositry.Model;
//using SettlerOfCatan.Repository;
//using SettlerOfCatan.Models;

namespace UnitTestSettlersOfCatan.PlayerTest
{
    [TestClass]
    public class Test_PlayerRepository
    {
        #region AddOne

        [TestMethod]
        public void PlayerRepository_AddOneClay()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);

            //Act 
            PlayerRepository.AddOneClay();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
        }

        [TestMethod]
        public void PlayerRepository_AddOneRock()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 0);

            //Act 
            PlayerRepository.AddOneRock();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 1);
        }

        [TestMethod]
        public void PlayerRepository_AddOneSheep()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);

            //Act 
            PlayerRepository.AddOneSheep();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 1);
        }

        [TestMethod]
        public void PlayerRepository_AddOneWheat()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);

            //Act 
            PlayerRepository.AddOneWheat();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 1);
        }

        [TestMethod]
        public void PlayerRepository_AddOneWood()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);

            //Act 
            PlayerRepository.AddOneWood();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
        }

        #endregion

        #region AddTwo

        [TestMethod]
        public void PlayerRepository_AddTwoClay()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);

            //Act 
            PlayerRepository.AddTwoClay();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 2);
        }

        [TestMethod]
        public void PlayerRepository_AddTwoRock()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 0);

            //Act 
            PlayerRepository.AddTwoRock();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 2);
        }

        [TestMethod]
        public void PlayerRepository_AddTwoSheep()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);

            //Act 
            PlayerRepository.AddTwoSheep();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 2);
        }

        [TestMethod]
        public void PlayerRepository_AddTwoWheat()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);

            //Act 
            PlayerRepository.AddTwoWheat();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 2);
        }

        [TestMethod]
        public void PlayerRepository_AddTwoWood()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);

            //Act 
            PlayerRepository.AddTwoWood();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 2);
        }
        #endregion

        #region CanPayForRoad

        [TestMethod]
        public void PlayerRepository_CanPayForRoadWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);

            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForRoadWithEnoughtWoodNoClay_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();

            //Act 
            var canPayForRoad = PlayerRepository.CanPayForRoad();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(canPayForRoad, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForRoadWithEnoughtClayNoWood_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneClay();

            //Act 
            var canPayForRoad = PlayerRepository.CanPayForRoad();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(canPayForRoad, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForRoadWithEnoughtClayAndWood_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWood();

            //Act 
            var canPayForRoad = PlayerRepository.CanPayForRoad();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(canPayForRoad, true);
        }

        #endregion

        #region CanPayForSettlement

        [TestMethod]
        public void PlayerRepository_CanPayForSettlementWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);

            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForSettlementWithEnoughtWoodNoWoodNoWheatNoSheep_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneClay();

            //Act 
            var canPayForSettlement = PlayerRepository.CanPayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(canPayForSettlement, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForSettlementWithEnoughtWoodEnoughtWoodNoWheatNoSheep_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();

            //Act 
            var canPayForSettlement = PlayerRepository.CanPayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(canPayForSettlement, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForSettlementWithEnoughtWoodEnoughtWoodEnoughtWheatNoSheep_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForSettlement = PlayerRepository.CanPayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(canPayForSettlement, false);
        }


        [TestMethod]
        public void PlayerRepository_CanPayForSettlementWithEnoughtClayAndWood_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneSheep();

            //Act 
            var canPayForSettlement = PlayerRepository.CanPayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 1);
            Assert.AreEqual(canPayForSettlement, true);
        }

        #endregion

        #region CanPayForCity

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithOneRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }


        [TestMethod]
        public void PlayerRepository_CanPayForCityWithTwoRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithThreeRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithFourRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithThreeRockOneWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithThreeRockTwoWheat_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, true);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithNoRockTwoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

       

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithOneRockTwoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForCityWithTwoRockTwoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForCity = PlayerRepository.CanPayForCity();

            //Assert
            Assert.AreEqual(canPayForCity, false);
        }

        #endregion

        #region CanPayForDevelopmentCard

        [TestMethod]
        public void PlayerRepository_CanPayForDevelopmentCardWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));

            //Act 
            var canPayForDevelopmentCard = PlayerRepository.CanPayForDevelopmentCard();

            //Assert
            Assert.AreEqual(canPayForDevelopmentCard, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForDevelopmentCardWithRockNoSheepNoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();

            //Act 
            var canPayForDevelopmentCard = PlayerRepository.CanPayForDevelopmentCard();

            //Assert
            Assert.AreEqual(canPayForDevelopmentCard, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForDevelopmentCardWithRockWithSheepNoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneSheep();

            //Act 
            var canPayForDevelopmentCard = PlayerRepository.CanPayForDevelopmentCard();

            //Assert
            Assert.AreEqual(canPayForDevelopmentCard, false);
        }

        [TestMethod]
        public void PlayerRepository_CanPayForDevelopmentCardWithRockWithSheepWithWheat_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneSheep();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForDevelopmentCard = PlayerRepository.CanPayForDevelopmentCard();

            //Assert
            Assert.AreEqual(canPayForDevelopmentCard, true);
        }
        #endregion

        #region PayForRoad

        [TestMethod]
        public void PlayerRepository_PayForRoadWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }


        [TestMethod]
        public void PlayerRepository_PayForRoadWithEnoughtWoodNoClay_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();

            //Act 
            var payForRoad = PlayerRepository.PayForRoad();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(payForRoad, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForRoadWithEnoughtClayNoWood_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneClay();

            //Act 
            var payForRoad = PlayerRepository.PayForRoad();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(payForRoad, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForRoadWithEnoughtClayAndWood_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWood();

            //Act 
            var payForRoad = PlayerRepository.PayForRoad();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(payForRoad, true);
        }

        [TestMethod]
        public void PlayerRepository_PayForRoadWithDoulbeEnoughtClayAndWood_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWood();

            //Act 
            var payForRoad = PlayerRepository.PayForRoad();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(payForRoad, true);
        }

        #endregion

        #region PayForSettlement

        [TestMethod]
        public void PlayerRepository_PayForSettlementWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);

            Assert.AreEqual(payForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForSettlementWithEnoughtWoodNoWoodNoWheatNoSheep_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneClay();

            //Act 
            var payForSettlement = PlayerRepository.PayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(payForSettlement, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForSettlementWithEnoughtWoodEnoughtWoodNoWheatNoSheep_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();

            //Act 
            var payForSettlement = PlayerRepository.PayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(payForSettlement, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForSettlementWithEnoughtWoodEnoughtWoodEnoughtWheatNoSheep_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWheat();

            //Act 
            var payForSettlement = PlayerRepository.PayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(payForSettlement, false);
        }


        [TestMethod]
        public void PlayerRepository_PayForSettlementWithEnoughtClayAndWood_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneSheep();

            //Act 
            var payForSettlement = PlayerRepository.PayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(payForSettlement, true);
        }

        [TestMethod]
        public void PlayerRepository_PayForSettlementWithDoubleEnoughtClayAndWood_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneSheep();

            PlayerRepository.AddOneWood();
            PlayerRepository.AddOneClay();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneSheep();
            //Act 
            var payForSettlement = PlayerRepository.PayForSettlement();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfClay, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWood, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 1);
            Assert.AreEqual(payForSettlement, true);
        }

        #endregion
        
        #region PayForCity

        [TestMethod]
        public void PlayerRepository_PayForCityWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithOneRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }


        [TestMethod]
        public void PlayerRepository_PayForCityWithTwoRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithThreeRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithFourRock_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithThreeRockOneWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithThreeRockTwoWheat_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);

            Assert.AreEqual(payForCity, true);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithSixRockFourWheat_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 3);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 2);

            Assert.AreEqual(payForCity, true);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithNoRockTwoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }



        [TestMethod]
        public void PlayerRepository_PayForCityWithOneRockTwoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForCityWithTwoRockTwoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneWheat();
            PlayerRepository.AddOneWheat();

            //Act 
            var payForCity = PlayerRepository.PayForCity();

            //Assert
            Assert.AreEqual(payForCity, false);
        }

        #endregion

        #region PayForDevelopmentCard

        [TestMethod]
        public void PlayerRepository_PayForDevelopmentCardWithNoResources_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));

            //Act 
            var payForDevelopmentCard = PlayerRepository.PayForDevelopmentCard();

            //Assert
            Assert.AreEqual(payForDevelopmentCard, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForDevelopmentCardWithRockNoSheepNoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();

            //Act 
            var payForDevelopmentCard = PlayerRepository.PayForDevelopmentCard();

            //Assert
            Assert.AreEqual(payForDevelopmentCard, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForDevelopmentCardWithRockWithSheepNoWheat_False()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneSheep();

            //Act 
            var payForDevelopmentCard = PlayerRepository.PayForDevelopmentCard();

            //Assert
            Assert.AreEqual(payForDevelopmentCard, false);
        }

        [TestMethod]
        public void PlayerRepository_PayForDevelopmentCardWithRockWithSheepWithWheat_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneSheep();
            PlayerRepository.AddOneWheat();

            //Act 
            var canPayForDevelopmentCard = PlayerRepository.PayForDevelopmentCard();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 0);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 0);

            Assert.AreEqual(canPayForDevelopmentCard, true);
        }

        [TestMethod]
        public void PlayerRepository_PayForDevelopmentCardWithDoubleRockWithDoubleSheepWithDoubleWheat_True()
        {
            //Arrange 
            PlayerRepository PlayerRepository = new PlayerRepository(new PlayerModel(1));
            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneSheep();
            PlayerRepository.AddOneWheat();

            PlayerRepository.AddOneRock();
            PlayerRepository.AddOneSheep();
            PlayerRepository.AddOneWheat();
            //Act 
            var canPayForDevelopmentCard = PlayerRepository.PayForDevelopmentCard();

            //Assert
            Assert.AreEqual(PlayerRepository.Player.NumberOfRock, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfSheep, 1);
            Assert.AreEqual(PlayerRepository.Player.NumberOfWheat, 1);

            Assert.AreEqual(canPayForDevelopmentCard, true);
        }
        #endregion

    }
}
