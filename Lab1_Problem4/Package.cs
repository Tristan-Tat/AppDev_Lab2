using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Problem2
{
    public class Package
    {
        double weight_kg;
        double distance_miles;

        public Package(double weight, double distance) 
        { 
            this.weight_kg = weight;
            this.distance_miles = distance;
        }

        public decimal CalcPrice()
        {
            return this.GetRate() * (decimal) Math.Ceiling(this.distance_miles / 500);
        }

        public decimal GetRate()
        {
            if (this.weight_kg <= 2) return 1.10M;
            if (this.weight_kg <= 6) return 2.20M;
            if (this.weight_kg <= 10) return 3.70M;
            return 4.80M;
        }
    }
}
