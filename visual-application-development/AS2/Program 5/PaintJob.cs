using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class PaintJob
    {
        /* Method to calculate estimated cost of a paint job
         * Parameters: square footage to be painted, cost of a gallon of paint
         * Output: estimated cost for paint job
         */

        public double CalculateEstimatedCost(int sqft, double costPerGallon)
        {
            // constants and variables

            const int sqftPerGallon = 390;
            const double laborCostPerSqft = 3.05;

            double paintCost, laborCost, totalCost;

            // calculate cost

            paintCost = (sqft / sqftPerGallon) * costPerGallon;
            laborCost = sqft * laborCostPerSqft;
            totalCost = paintCost + laborCost;

            // return estimated cost

            return totalCost;
        }
    }
}
