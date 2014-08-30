﻿using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{

    public class PlayerModel : IPlayerModel
    {
        public PlayerModel(int PlayerID) { this.PlayerID = PlayerID; }

        public int PlayerID { get; set; }
        public int NumberOfWood { get; set; }
        public int NumberOfRock { get; set; }
        public int NumberOfSheep { get; set; }
        public int NumberOfClay { get; set; }
        public int NumberOfWheat { get; set; }
        public int NumberOfDesert { get; set; }
    }
}
