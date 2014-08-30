
using SettlerOfCatan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SettlerOfCatan.Controllers
{
    public class SevenHexagonController : Controller
    {
        //
        // GET: /SevenHexagone/

      

        public ActionResult Index()
        {
            //List<ResourceModel> resourceList = new List<ResourceModel>();
            //resourceList.Add(new ResourceModel() { ResourceID = 1, ResourceTitle = "Wood" });
            //resourceList.Add(new ResourceModel() { ResourceID = 2, ResourceTitle = "Rock" });
            //resourceList.Add(new ResourceModel() { ResourceID = 3, ResourceTitle = "Sheep" });
            //resourceList.Add(new ResourceModel() { ResourceID = 4, ResourceTitle = "Clay" });
            //resourceList.Add(new ResourceModel() { ResourceID = 5, ResourceTitle = "Wheat" });
            //resourceList.Add(new ResourceModel() { ResourceID = 6, ResourceTitle = "Desert" });

            //SevenHexIslandFactory asdf = new SevenHexIslandFactory();

            //List<HexagonTileModel> hexIsland = asdf.GetIsland(resourceList);

            //return View(hexIsland);
            return View();
        }

        //private static List<HexagonTileModel> NewMethod()
        //{
            
        //}

        //public int RoleDice()
        //{
        //    Random rnd = new Random();
        //    int redDiceNumber = rnd.Next(1, 3);  
        //    int yellowDiceNumber = rnd.Next(1, 3);  
        //    return redDiceNumber + yellowDiceNumber;
        //}

        //public void TaleTurn(int playerNumber,  List<HexagonTileModel> hexIsland)
        //{
        //    int diceNumber = RoleDice();
        //    if (diceNumber != 7)
        //    {
        //        List<HexagonTileModel> asdf = hexIsland.Where(hex => hex.DiceNumber == diceNumber).ToList();

        //        foreach (var hex in asdf)
        //        {
        //            if (!hex.HasRobber)
        //            {

        //            }
        //        }
        //    }
        //}

        //public Tuple<List<int>, List<int>> Getasdf(HexagonTileModel hexagon) {

        //    List<int> playersWithSettlement = new List<int>();
        //    List<int> playersWithCity = new List<int>();

        //    if (NewMethod(hexagon.TopLeftCorner) != null) 
        //    {
                
        //    }


        //    return Tuple.Create(playersWithSettlement, playersWithCity);
        //}

        //private int? GetSettlementOwnerID(CornerTypeModel cornerTypeModel)
        //{
        //    if (cornerTypeModel.HasSettlement)
        //    {
        //        return cornerTypeModel.OwnerID;
        //    }
        //    return null;
        //}

        //private int? GetCityOwnerID(CornerTypeModel cornerTypeModel)
        //{
        //    if (cornerTypeModel.HasCity)
        //    {
        //        return cornerTypeModel.OwnerID;
        //    }
        //    return null;
        //}


    }
}
