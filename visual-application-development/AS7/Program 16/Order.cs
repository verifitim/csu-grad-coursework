/*
 * Project:         Assignment Set 7 - Program 16
 * Date:            December 2024
 * Developed By:    TM
 * Class Name:      Order
 * Assumption:      A Pizza Order
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    #region "Enumeration"

    public enum CrustAndSize
    {
        CrunchyThin10 = 1,
        DeepDish11 = 2,
        HandTossed12 = 3,
        GlutenFree13 = 4,
        Italiano14 = 5,
        NYStyle15 = 6,
        BigKahuna16 = 7
    }
    #endregion

    internal class Order
    {
        #region "Auto-Implemented Properties"

        public string CustomerName { get; private set; }
        public decimal OrderTotal { get; private set; }
        public string PizzaChoice { get; private set; }
        public CrustAndSize PizzaType {  get; private set; }
        public int Quantity { get; private set; }


        #endregion

        #region "Constructor"

        public Order(string customerName, string pizzaChoice, CrustAndSize pizzaType, int quantity)
        {
            CustomerName = customerName;
            PizzaChoice = pizzaChoice;
            PizzaType = pizzaType;
            Quantity = quantity;
            OrderTotal = CalculateOrderTotal();
        }

        #endregion

        #region "Method"
        
        public decimal CalculateOrderTotal()
        {
            decimal price = 0;

            switch (PizzaType)
            {
                case CrustAndSize.CrunchyThin10:
                    price = 15.99m;
                    break;
                case CrustAndSize.DeepDish11:
                    price = 16.89m;
                    break;
                case CrustAndSize.HandTossed12:
                    price = 17.79m;
                    break;
                case CrustAndSize.GlutenFree13:
                    price = 18.69m;
                    break;
                case CrustAndSize.Italiano14:
                    price = 19.59m;
                    break;
                case CrustAndSize.NYStyle15:
                    price = 20.49m;
                    break;
                default: // BigKahuna16
                    price = 21.39m;
                    break;
            }
            return price * Quantity;
        }

        #endregion
    }
}
