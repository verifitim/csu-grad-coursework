/*
 * Project: Assignment Set 5 Program 12
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: Projectile
 * Description: Model for vertically launched object under the force of gravity
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    public class Projectile
    {
        #region "Constants"

        int findHeightGravConst = 16;
        int maxHeightGravConst = 32;

        #endregion

        #region "Auto-Implemented Properties"

        public int InitialHeight {  get; private set; }
        public int InitialVelocity { get; private set; }
        public double LandTime {  get; private set; }
        public double MaxHeight { get; private set; }

        #endregion

        #region "Constructor"

        public Projectile (int initialHeight, int initialVelocity)
        {
            InitialHeight = initialHeight;
            InitialVelocity = initialVelocity;
            MaxHeight = CalcMaxHeight();
            LandTime = CalcLandTime();
        }

        #endregion

        #region "Methods"

        public double FindHeight(double atTime)
        {
            // height(t) = initial height + (initial velocity * t) – (16 * t^2)

            double height = InitialHeight + (InitialVelocity * atTime) 
                - (findHeightGravConst * Math.Pow(atTime, 2));

            return height;
        }

        private double CalcMaxHeight()
        {
            // find time at max height

            double maxHeightAtTime = InitialVelocity / maxHeightGravConst;

            // call method to find max height

            double maxHeight = FindHeight(maxHeightAtTime);

            return maxHeight;
        }

        private double CalcLandTime()
        {
            double landTime = 0;
            double currentHeight = InitialHeight;

            do
            {
                landTime += 0.1;
                currentHeight = FindHeight(landTime);
                
            } while (currentHeight > 0);

            return landTime;
        }

        #endregion
    }
}
