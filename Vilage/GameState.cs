using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vilage
{
    public class GameState
    {
        public int gold;
        public int income;
        public int[] buildings = { 0, 0, 0, 0, 0 };
        public string errorMsg;

        public GameState(int startingGold, int startingIncome = 0)
        {
            gold = startingGold;
            income = startingIncome;
        }
        
        public void RaiseBuilding(Building building)
        {
            if (gold < building.GenerateBuildingCost())
                errorMsg = "Brak złotŏ";
            else
            {
                errorMsg = "";
                building.amountOfBuildings += 1;
                UpdateBuildingList(building);
                income += building.GenerateMoney();
                gold -= building.GenerateBuildingCost();
            }

        }
        public void UpdateBuildingList(Building building)
        {
            if (building is Sawmill)
                buildings[0] += 1;
            else if (building is Querry)
                buildings[1] += 1;
            else if (building is LumberjackHouse)
                buildings[2] += 1;
            else if (building is Mint)
                buildings[3] += 1;
            else if (building is GoldMine)
                buildings[4] += 1;
        }
    }
}
