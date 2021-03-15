using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vilage
{
    public abstract class Building
    {
        public abstract Building CreateBuilding();
        public int amountOfBuildings = 0;

        public abstract int GenerateMoney();
        public abstract int GenerateBuildingCost();
        public abstract bool AreBuildingRequierementsMet(int[] building);

    }
}
