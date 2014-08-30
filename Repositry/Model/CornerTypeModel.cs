using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repositry.Models
{
    public class CornerTypeModel
    {
        public int? OwnerID { get; set; }
        public bool HasSettlement { get; set; }
        public bool HasCity { get; set; }
    }
}