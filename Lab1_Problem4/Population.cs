using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Problem3
{
    internal class Population
    {
        int startingPop, days;
        double avgDailyPopGrowth;

        public Population(int startingPop, double avgDailyPopGrowth, int days) 
        {
            this.avgDailyPopGrowth = 1 + avgDailyPopGrowth;
            this.startingPop = startingPop; 
            this.days = days;
        }

        public int[] calcDailyPop()
        {
            int[] populationPerDay = new int[this.days];
            double val = this.startingPop;
            for (int i = 0; i < this.days; i++)
            {
                val *= avgDailyPopGrowth;
                populationPerDay[i] = (int) val;
            }

            return populationPerDay;
        }
    }
}
