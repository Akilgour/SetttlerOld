using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Models.Interface
{
    public interface IHexagonTileModel
    {
        String HexagonID { get; set; }
        int ResourceID { get; set; }
        int DiceNumber { get; set; }

        CornerTypeModel TopLeftCorner { get; set; }
        CornerTypeModel TopRightCorner { get; set; }
        CornerTypeModel MiddleRightCorner { get; set; }
        CornerTypeModel BottomRightCorner { get; set; }
        CornerTypeModel BottomLeftCorner { get; set; }
        CornerTypeModel MiddleLeftCorner { get; set; }

        int? NorthSideRoadOwner { get; set; }
        int? NorthEastSideRoadOwner { get; set; }
        int? SouthEastSideRoadOwner { get; set; }
        int? SouthSideRoadOwner { get; set; }
        int? SouthWestSideRoadOwner { get; set; }
        int? NorthWestSideRoadOwner { get; set; }

        bool HasRobber { get; set; }

    }
}
