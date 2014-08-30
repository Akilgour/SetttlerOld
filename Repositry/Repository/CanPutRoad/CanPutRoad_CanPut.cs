using Repositry.Model;
using Repositry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    static class CanPutRoad_CanPut
    {

        public static bool CanPut(int PlayerID, CornerTypeModel Corner)
        {
            if (Corner != null)
            {
                if (Corner.HasSettlement)
                {
                    if (Corner.OwnerID == PlayerID)
                    {
                        return true;
                       // return new ValidationResults() { IsValid = true };
                    }
                }

                if (Corner.HasCity)
                {
                    if (Corner.OwnerID == PlayerID)
                    {
                        return true;
                       // return new ValidationResults() { IsValid = true };
                    }
                }
            }
            return false;
          //  return new ValidationResults() { IsValid = false, ErrorMessage = "No adjacent Settlement or Cities" };

        }
    }
}
