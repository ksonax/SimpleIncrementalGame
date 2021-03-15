using System;
using System.Collections.Generic;

namespace Vilage
{
    public class LumberjackHouse : Building
    {
        public string name = "LumberjackHouse";
        public int buildingIncome = 300;
        public int buildingCost = 1500;

        public override Building CreateBuilding()
        {
            return new LumberjackHouse();
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