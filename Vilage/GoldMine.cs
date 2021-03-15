using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vilage
{
    public class GoldMine : Building
    {
        public string name = "Gold Mine";
        public int buildingIncome = 100;
        public int buildingCost = 5000;

        public override Building CreateBuilding()
        {
            return new GoldMine();
        }
        public override int GenerateMoney()
        {
            return buildingIncome;
        }
        public override int GenerateBuildingCost()
        {
            return buildingCost;
        }
        public override bool AreBuildingRequierementsMet(int[] buildings)
        {
            if (buildings[4] < buildings[0] && buildings[4] < buildings[2] && buildings[4] < buildings[1])
                return true;

            else
                return false;
        }
    }
}
