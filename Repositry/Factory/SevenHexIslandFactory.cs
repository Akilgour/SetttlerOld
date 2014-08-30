﻿//using Repositry.Models;
//using SettlerOfCatan.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace SettlerOfCatan.Factory
//{
//     class SevenHexIslandFactory :IIsland
//    {

//        public List<HexagonTileModel> GetIsland(List<ResourceModel> ResourceList)
//        {
          
//            List<HexagonTileModel> hexIsland = new List<HexagonTileModel>();

//            hexIsland.Add(new HexagonTileModel() { HexagonID = "A", ResourceID = 2, DiceNumber = 3, TopLeftCorner = new CornerTypeModel(), TopRightCorner = new CornerTypeModel(), MiddleRightCorner = new CornerTypeModel(), BottomRightCorner = new CornerTypeModel(), BottomLeftCorner = new CornerTypeModel(), MiddleLeftCorner = new CornerTypeModel(), NorthSideRoadOwner = 0, NorthEastSideRoadOwner = 0, SouthEastSideRoadOwner = 0, SouthSideRoadOwner = 0, SouthWestSideRoadOwner = 0, NorthWestSideRoadOwner = 0, HasRobber = false });
//            hexIsland.Add(new HexagonTileModel() { HexagonID = "B", ResourceID = 1, DiceNumber = 2, TopLeftCorner = new CornerTypeModel(), TopRightCorner = new CornerTypeModel(), MiddleRightCorner = new CornerTypeModel(), BottomRightCorner = new CornerTypeModel(), BottomLeftCorner = new CornerTypeModel(), MiddleLeftCorner = new CornerTypeModel(), NorthSideRoadOwner = 0, NorthEastSideRoadOwner = 0, SouthEastSideRoadOwner = 0, SouthSideRoadOwner = 0, SouthWestSideRoadOwner = 0, NorthWestSideRoadOwner = 0, HasRobber = false });
//            hexIsland.Add(new HexagonTileModel() { HexagonID = "C", ResourceID = 6, DiceNumber = 6, TopLeftCorner = new CornerTypeModel(), TopRightCorner = new CornerTypeModel(), MiddleRightCorner = new CornerTypeModel(), BottomRightCorner = new CornerTypeModel(), BottomLeftCorner = new CornerTypeModel(), MiddleLeftCorner = new CornerTypeModel(), NorthSideRoadOwner = 0, NorthEastSideRoadOwner = 0, SouthEastSideRoadOwner = 0, SouthSideRoadOwner = 0, SouthWestSideRoadOwner = 0, NorthWestSideRoadOwner = 0, HasRobber = true });
//            hexIsland.Add(new HexagonTileModel() { HexagonID = "D", ResourceID = 3, DiceNumber = 2, TopLeftCorner = new CornerTypeModel(), TopRightCorner = new CornerTypeModel(), MiddleRightCorner = new CornerTypeModel(), BottomRightCorner = new CornerTypeModel(), BottomLeftCorner = new CornerTypeModel(), MiddleLeftCorner = new CornerTypeModel(), NorthSideRoadOwner = 0, NorthEastSideRoadOwner = 0, SouthEastSideRoadOwner = 0, SouthSideRoadOwner = 0, SouthWestSideRoadOwner = 0, NorthWestSideRoadOwner = 0, HasRobber = false });
//            hexIsland.Add(new HexagonTileModel() { HexagonID = "E", ResourceID = 1, DiceNumber = 5, TopLeftCorner = new CornerTypeModel(), TopRightCorner = new CornerTypeModel(), MiddleRightCorner = new CornerTypeModel(), BottomRightCorner = new CornerTypeModel(), BottomLeftCorner = new CornerTypeModel(), MiddleLeftCorner = new CornerTypeModel(), NorthSideRoadOwner = 0, NorthEastSideRoadOwner = 0, SouthEastSideRoadOwner = 0, SouthSideRoadOwner = 0, SouthWestSideRoadOwner = 0, NorthWestSideRoadOwner = 0, HasRobber = false });
//            hexIsland.Add(new HexagonTileModel() { HexagonID = "F", ResourceID = 4, DiceNumber = 3, TopLeftCorner = new CornerTypeModel(), TopRightCorner = new CornerTypeModel(), MiddleRightCorner = new CornerTypeModel(), BottomRightCorner = new CornerTypeModel(), BottomLeftCorner = new CornerTypeModel(), MiddleLeftCorner = new CornerTypeModel(), NorthSideRoadOwner = 0, NorthEastSideRoadOwner = 0, SouthEastSideRoadOwner = 0, SouthSideRoadOwner = 0, SouthWestSideRoadOwner = 0, NorthWestSideRoadOwner = 0, HasRobber = false });
//            hexIsland.Add(new HexagonTileModel() { HexagonID = "G", ResourceID = 5, DiceNumber = 4, TopLeftCorner = new CornerTypeModel(), TopRightCorner = new CornerTypeModel(), MiddleRightCorner = new CornerTypeModel(), BottomRightCorner = new CornerTypeModel(), BottomLeftCorner = new CornerTypeModel(), MiddleLeftCorner = new CornerTypeModel(), NorthSideRoadOwner = 0, NorthEastSideRoadOwner = 0, SouthEastSideRoadOwner = 0, SouthSideRoadOwner = 0, SouthWestSideRoadOwner = 0, NorthWestSideRoadOwner = 0, HasRobber = false });

//            hexIsland.Where(hex => hex.HexagonID == "A").Single().TopLeftCorner.OwnerID = 1;
//            hexIsland.Where(hex => hex.HexagonID == "A").Single().TopLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "A").Single().BottomLeftCorner.OwnerID = 2;
//            hexIsland.Where(hex => hex.HexagonID == "A").Single().BottomLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "A").Single().NorthWestSideRoadOwner = 1;

//            hexIsland.Where(hex => hex.HexagonID == "B").Single().TopLeftCorner.OwnerID = 1;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().TopLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().NorthSideRoadOwner = 1;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().MiddleRightCorner.OwnerID = 2;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().MiddleRightCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().NorthEastSideRoadOwner = 2;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().SouthSideRoadOwner = 2;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().MiddleLeftCorner.OwnerID = 2;
//            hexIsland.Where(hex => hex.HexagonID == "B").Single().MiddleLeftCorner.HasSettlement = true;

//            hexIsland.Where(hex => hex.HexagonID == "C").Single().BottomLeftCorner.OwnerID = 2;
//            hexIsland.Where(hex => hex.HexagonID == "C").Single().BottomLeftCorner.HasSettlement = true;

//            hexIsland.Where(hex => hex.HexagonID == "D").Single().TopLeftCorner.OwnerID = 2;
//            hexIsland.Where(hex => hex.HexagonID == "D").Single().TopLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "D").Single().MiddleRightCorner.OwnerID = 3;
//            hexIsland.Where(hex => hex.HexagonID == "D").Single().MiddleRightCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "D").Single().SouthEastSideRoadOwner = 3;

//            hexIsland.Where(hex => hex.HexagonID == "E").Single().TopLeftCorner.OwnerID = 2;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().TopLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().NorthSideRoadOwner = 2;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().MiddleRightCorner.OwnerID = 4;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().MiddleRightCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().SouthEastSideRoadOwner = 4;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().SouthSideRoadOwner = 4;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().BottomLeftCorner.OwnerID = 4;
//            hexIsland.Where(hex => hex.HexagonID == "E").Single().BottomLeftCorner.HasSettlement = true;

//            hexIsland.Where(hex => hex.HexagonID == "F").Single().TopLeftCorner.OwnerID = 3;
//            hexIsland.Where(hex => hex.HexagonID == "F").Single().TopLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "F").Single().BottomLeftCorner.OwnerID = 3;
//            hexIsland.Where(hex => hex.HexagonID == "F").Single().BottomLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "F").Single().SouthWestSideRoadOwner = 3;
//            hexIsland.Where(hex => hex.HexagonID == "F").Single().NorthWestSideRoadOwner = 3;

//            hexIsland.Where(hex => hex.HexagonID == "G").Single().TopLeftCorner.OwnerID = 4;
//            hexIsland.Where(hex => hex.HexagonID == "G").Single().TopLeftCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "G").Single().NorthEastSideRoadOwner = 3;
//            hexIsland.Where(hex => hex.HexagonID == "G").Single().MiddleRightCorner.OwnerID = 3;
//            hexIsland.Where(hex => hex.HexagonID == "G").Single().MiddleRightCorner.HasSettlement = true;
//            hexIsland.Where(hex => hex.HexagonID == "G").Single().NorthWestSideRoadOwner = 4;

//            return hexIsland;
//        }

//    }
//}