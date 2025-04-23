/*
 * Project: Assignment Set 3 Program 7
 * Developed by: Timothy Miller
 * Date Created: September 2024
 * Date Last Modified: September 2024
 * Class Name: TruckRental
 * Description: Class for calculating a car/truck rental charge
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class TruckRental
    {
        #region "Fields"

        private int beginOdometerReading, daysRented, endOdometerReading;

        #endregion

        #region "Properties"

        public int BeginOdometerReading { get; set; }
        public string CustomerName {  get; set; } 
        public int DaysRented { get; set; }
        public int EndOdometerReading { get; set; }
        public decimal RentalCharge { get; set; }

        #endregion

        #region "Constructors"

        internal TruckRental() { }

        internal TruckRental(string nameOfCustomer, int endMiles, int beginMiles, int numDays)
        {
            CustomerName = nameOfCustomer;
            EndOdometerReading = endMiles;
            BeginOdometerReading = beginMiles;
            DaysRented = numDays;
        }

        #endregion

        #region "Methods"

        internal void CalculateRentalCharge()
        {
            RentalCharge = 63.9m * DaysRented + .81m * (EndOdometerReading - BeginOdometerReading);
        }

        #endregion

    }

}
