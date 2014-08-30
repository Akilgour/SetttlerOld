using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSettlersOfCatan.DiceFactory;

namespace UnitTestSettlersOfCatan.DiceTest
{
    [TestClass]
    public class Test_DiceRepositoryLoadedToOne
    {
        [TestMethod]
        public void RoleDice()
        {
            //Arrange 
            var dice = new DiceRepositoryLoadedToOne();

            //Act 
            int number = dice.RoleDice();

            //Assert
            Assert.AreEqual(number, 1);

        }
    }
}
