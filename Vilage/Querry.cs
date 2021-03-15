using System;
using System.Collections.Generic;

namespace Vilage
{
    public class Querry : Building
    {
        public string name = "Querry";
        public int buildingIncome = 200;
        public int buildingCost = 500;

        public override Building CreateBuilding()
        {
            return new Querry();
        }
        public override int GenerateMoney()
        {
            return buildingIncome;
        }
        public override int GenerateBuildingCost()
        {
            return buildingCost;
        }
        public override bool AreBuildingRequierementsMet(int[] building)
        {
            return true;
        }

    }
}