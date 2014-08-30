using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositry.Model;
using Repositry.Repository;
using Repositry.Models;

namespace UnitTestSettlersOfCatan.HexagonTile
{
    [TestClass]
    public class Test_CanPutSettlement_AtMiddleRightCorner_NotFirstTurn
    {

        [TestMethod]
        public void AllEmpty()
        {
 
            //Arrange 
            HexagonTileModel topHexagonTile = new HexagonTileModel() { };
            HexagonTileModel middleHexagonTile = new HexagonTileModel() { };
            HexagonTileModel bottomHexagonTile = new HexagonTileModel() { };

            // HexagonTileCanPutRepository helper = new HexagonTileCanPutRepository();
            var canPutValidator = new CanPutSettlement_AtMiddleRightCorner_NotFirstTurn();
            var canPut = canPutValidator.IsValid(topHexagonTile, middleHexagonTile, bottomHexagonTile, 1, true);
  
            //Assert
            Assert.AreEqual(canPut.IsValid, true);
            Assert.AreEqual(canPut.ErrorMessage, null);
        }



    }
}
