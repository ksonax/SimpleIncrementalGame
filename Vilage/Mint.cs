using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vilage
{
    public class Mint : Building
    {
        public string name = "Mint";
        public int buildingIncome = 3000;
        public int buildingCost = 10000;

        public override Building CreateBuilding()
        {
            return new Mint();
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
            if (buildings[3] < buildings[0] && buildings[3] < buildings[2] && buildings[3] < buildings[1])
                return true;

            else
                return false;
        }
    }
}
