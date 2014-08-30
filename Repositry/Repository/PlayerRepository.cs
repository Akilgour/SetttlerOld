﻿using Repositry.Interface;
using Repositry.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    public class PlayerRepository : IPlayerRepository
    {

        public IPlayerModel Player { get; set; }

        public PlayerRepository(IPlayerModel Player) { this.Player = Player; }

        public void AddOneWood()
        {
            Player.NumberOfWood++;
        }

        public void AddOneRock()
        {
            Player.NumberOfRock++;
        }

        public void AddOneSheep()
        {
            Player.NumberOfSheep++;
        }

        public void AddOneClay()
        {
            Player.NumberOfClay++;
        }

        public void AddOneWheat()
        {
            Player.NumberOfWheat++;
        }

        public void AddTwoWood()
        {
            Player.NumberOfWood++;
            Player.NumberOfWood++;
        }

        public void AddTwoRock()
        {
            Player.NumberOfRock++;
            Player.NumberOfRock++;
        }

        public void AddTwoSheep()
        {
            Player.NumberOfSheep++;
            Player.NumberOfSheep++;
        }

        public void AddTwoClay()
        {
            Player.NumberOfClay++;
            Player.NumberOfClay++;
        }

        public void AddTwoWheat()
        {
            Player.NumberOfWheat++;
            Player.NumberOfWheat++;
        }

        public bool CanPayForRoad()
        {
            return ((Player.NumberOfWood > 0) && (Player.NumberOfClay > 0));
        }

        public bool PayForRoad()
        {
            if (!CanPayForRoad())
            {
                return false;
            }

            Player.NumberOfWood--;
            Player.NumberOfClay--;
            return true;
        }

        public bool CanPayForSettlement()
        {
            return ((Player.NumberOfWood > 0) && (Player.NumberOfClay > 0) && (Player.NumberOfWheat > 0) && (Player.NumberOfSheep > 0));
        }

        public bool PayForSettlement()
        {
            if (!CanPayForSettlement())
            {
                return false;
            }

            Player.NumberOfWood--;
            Player.NumberOfClay--;
            Player.NumberOfWheat--;
            Player.NumberOfSheep--;
            return true;
        }

        public bool CanPayForCity()
        {
            return ((Player.NumberOfRock >= 3) && (Player.NumberOfWheat >= 2));
        }

        public bool PayForCity()
        {
            if (!CanPayForCity())
            {
                return false;
            }

            Player.NumberOfRock--;
            Player.NumberOfRock--;
            Player.NumberOfRock--;
            Player.NumberOfWheat--;
            Player.NumberOfWheat--;
            return true;
        }


        public bool CanPayForDevelopmentCard()
        {
            return ((Player.NumberOfSheep > 0) && (Player.NumberOfWheat > 0) && (Player.NumberOfRock > 0));
        }

        public bool PayForDevelopmentCard()
        {
            if (!CanPayForDevelopmentCard())
            {
                return false;
            }

            Player.NumberOfSheep--;
            Player.NumberOfWheat--;
            Player.NumberOfRock--;
            return true;
        }
    }
}
