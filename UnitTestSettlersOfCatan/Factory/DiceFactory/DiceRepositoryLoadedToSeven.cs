using SettlerOfCatan.Helper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSettlersOfCatan.DiceFactory
{
    class DiceRepositoryLoadedToSeven : IDice
    {
        public int RoleDice()
        {
            return 7;
        }
    }
}
