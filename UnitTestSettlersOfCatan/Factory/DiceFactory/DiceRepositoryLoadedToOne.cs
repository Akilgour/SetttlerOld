using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SettlerOfCatan.Helper.Interface;

namespace UnitTestSettlersOfCatan.DiceFactory
{
    class DiceRepositoryLoadedToOne : IDice
    {
        public int RoleDice()
        {
            return 1;
        }
    }
}
