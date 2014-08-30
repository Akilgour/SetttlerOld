using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Interface
{
    public interface IPlayerRepository
    {
        void AddOneWood();
        void AddOneRock();
        void AddOneSheep();
        void AddOneClay();
        void AddOneWheat();

        void AddTwoWood();
        void AddTwoRock();
        void AddTwoSheep();
        void AddTwoClay();
        void AddTwoWheat();

        bool CanPayForRoad();
        bool PayForRoad();

        bool CanPayForSettlement();
        bool PayForSettlement();

        bool CanPayForCity();
        bool PayForCity();

        bool CanPayForDevelopmentCard();
        bool PayForDevelopmentCard();

    }
}
