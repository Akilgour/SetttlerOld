using SettlerOfCatan.Helper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlerOfCatan.Helper
{
    public class Dice : IDice
    {

          public int RoleDice()
        {
            Random rnd = new Random();
            int redDiceNumber = rnd.Next(1, 3);
            int yellowDiceNumber = rnd.Next(1, 3);
            return redDiceNumber + yellowDiceNumber;
        }
    }
}