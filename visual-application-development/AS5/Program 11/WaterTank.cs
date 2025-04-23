/*
 * Project: Assignment Set 5 Program 11
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: WaterTank
 * Description: Model for a water tank
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program11
{
    public class WaterTank
    {
        #region "Auto-Implemented Properties"

        public int TankCapacity { get; private set; }
        public int TankDepth { get; private set; } // in meters
        public int TankRadius {  get; private set; } // in meters
        public int WaterLevel { get; private set; }

        #endregion

        #region "Constructor"

        public WaterTank(int tankRadius, int tankDepth)
        {
            // set properties using parameters

            TankRadius = tankRadius;
            TankDepth = tankDepth;

            // set max water capacity

            TankCapacity = CalcTankCapacity();
        }

        #endregion

        #region "Methods"

        private int CalcTankCapacity()
        {
            // local variable

            double capacity;

            // calculate capactiy

            capacity = Math.PI * Math.Pow(TankRadius, 2) * TankDepth * 1000; // in litres

            // convert from double to int

            return Convert.ToInt32(Math.Floor(capacity));

        }

        public string AddWater(int litresToAdd)
        {
            // local variables 

            string message = string.Empty;
            int currentToMax;

            // add water to tank if possible

            currentToMax = TankCapacity - WaterLevel;

            if (litresToAdd <= currentToMax)
            {
                WaterLevel += litresToAdd;
                message = $"Water increased by {litresToAdd} litres.\n" +
                    $"Current water level is {WaterLevel} litres.";
            }
            else
            {
                message = $"Water cannot be increased by {litresToAdd} litres.\n" +
                    $"Current water level is {WaterLevel} litres.\n" +
                    $"The tank has {currentToMax} litres remaining until full.";
            }

            return message;
        }

        public string WithdrawWater(int litresToWithdraw)
        {
            // local variables 

            int levelAfter = WaterLevel - litresToWithdraw;
            string message = string.Empty;
            
            // remove water from tank if possible

            if (levelAfter >= 0)
            {
                WaterLevel -= litresToWithdraw;
                message = $"Water decreased by {litresToWithdraw} litres.\n" +
                    $"Current water level is {WaterLevel} litres.";
            }
            else
            {
                message = $"Water cannot be decreased by {litresToWithdraw} litres.\n" +
                    $"Current water level is {WaterLevel} litres.\n" +
                    $"The tank has {WaterLevel} litres remaining until empty.";
            }

            return message;
        }

        public bool FillTank(int litresPerSecond)
        {
            bool outcome = false;
            int currentToMax;

            currentToMax = TankCapacity - WaterLevel;

            if (litresPerSecond <= currentToMax)
            {
                WaterLevel += litresPerSecond;
                outcome = true;
            }

            return outcome;
        }

        public bool DrainTank(int litresPerSecond)
        {
            int levelAfter = WaterLevel - litresPerSecond;
            bool outcome = false;

            if (levelAfter >= 0)
            {
                WaterLevel -= litresPerSecond;
                outcome = true;
            }

            return outcome;
        }

        #endregion

    }
}
