using Repositry.Models;
using Repositry.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Model
{
    public class HexagonTileModel : IHexagonTileModel
    {

        public String HexagonID { get; set; }
        public int ResourceID { get; set; }
        public int DiceNumber { get; set; }

        public CornerTypeModel TopLeftCorner { get; set; }
        public CornerTypeModel TopRightCorner { get; set; }
        public CornerTypeModel MiddleRightCorner { get; set; }
        public CornerTypeModel BottomRightCorner { get; set; }
        public CornerTypeModel BottomLeftCorner { get; set; }
        public CornerTypeModel MiddleLeftCorner { get; set; }

        public int? NorthSideRoadOwner { get; set; }
        public int? NorthEastSideRoadOwner { get; set; }
        public int? SouthEastSideRoadOwner { get; set; }
        public int? SouthSideRoadOwner { get; set; }
        public int? SouthWestSideRoadOwner { get; set; }
        public int? NorthWestSideRoadOwner { get; set; }

        public bool HasRobber { get; set; }

    }
}
