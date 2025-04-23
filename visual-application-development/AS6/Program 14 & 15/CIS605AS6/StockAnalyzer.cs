/*
 * Project:         Assignment Set 6 - Program 14
 * Date:            October 2024
 * Developed By:    LV
 * Class Name:      StockAnalyzer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS605AS6
{
    public class StockAnalyzer
    {
        #region "Property"

        public string TickerSymbol { get; private set; }
        public decimal[] StockPrices { get; private set; }

        #endregion

        #region "Constructor"

        public StockAnalyzer(string symbol, decimal[] prices)
        {
            TickerSymbol = symbol;

            StockPrices = prices;
        }

        #endregion

        #region "Methods"

        /* Complete this method to find and return the largest price change (either up or down) between any two consecutive trading days. 
         * 
         * Price change (either up or down) between two consecutive trading days (e.g., Days 1 and 2) =
         * 
         *        Absolute value of (Day 2 Price - Day 1 Price) 
        */

        public decimal FindLargestAbsolutePriceChange()
        {
            
        }

        /* Complete this method to find and return the smallest percentage gain in price between any two consecutive trading days.
         * 
         *  The return value should be formatted to display with a % sign and 5 decimal places.
         *  
         *  Percentage change in price between two consecutive trading days (e.g., Days 1 and 2) =
         *  
         *        (Day 2 Price - Day 1 Price) / Day 1 Price
        */

        public string FindSmallestPercentageGainInPrice()
        {
            
        }

        /* Complete this method to find and return the number of times there is a negative change in price between any two consecutive trading days.
         * 
         * There is a negative change in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price < 0
        */

        public int FindNumTimesNegativePriceChange()
        {
            
        }

        /* Complete this method to find and return the longest period (in days) of continuous price gain.
        * 
        * There is a gain in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price > 0
       */

        public int FindLongestPriceGainStreak()
        {
            
        }

        #endregion
    }
}
