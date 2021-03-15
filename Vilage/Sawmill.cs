using System;
using System.Collections.Generic;
namespace Vilage
{
    public class Sawmill : Building
    {
        public string name = "Sawmill";
        public int buildingIncome = 500;
        public int buildingCost = 3000;

        public override Building CreateBuilding()
        {
            return new Sawmill();
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