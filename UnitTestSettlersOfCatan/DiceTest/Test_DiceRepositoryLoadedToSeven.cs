using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSettlersOfCatan.DiceFactory;

namespace UnitTestSettlersOfCatan.DiceTest
{
    class Test_DiceRepositoryLoadedToSeven
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
