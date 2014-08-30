using Repositry.Interface;
using Repositry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry.Repository
{
    public class RoadRepository
    {
        private List<ValidationResults> validationResults;
        private List<IValidationRoad> validations;

        public RoadRepository(List<IValidationRoad> validations)
        {
            this.validations = validations;
        }

        public List<ValidationResults> CanPutRoad(object TopHexagonTileModel, object MiddleHexagonTileModel, object BottomHexagonTileModel, int PlayerID)
        {
            var validate = validations.Select(v => v.IsValid(TopHexagonTileModel, MiddleHexagonTileModel, BottomHexagonTileModel, PlayerID));
            return validate.Where(v => !v.IsValid).ToList();
        }
    }
}
