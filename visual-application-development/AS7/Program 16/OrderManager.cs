/*
 * Project:         Assignment Set 7 - Program 16
 * Date:            December 2024
 * Developed By:    TM
 * Class Name:      OrderManager
 * Assumption:      A Class to Manage Pizza Orders
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    internal class OrderManager
    {
        #region "Auto-Implemented Properties"

        public List<Order> OrderList {  get; private set; }

        #endregion

        #region "Constructor"

        public OrderManager()
        {
            OrderList = new List<Order>();
        }

        #endregion

        #region "Methods"

        public void AddOrder(string customerName, string pizzaChoice, CrustAndSize pizzaType, int quantity)
        {
            Order anOrder = new Order(customerName, pizzaChoice, pizzaType, quantity);
            OrderList.Add(anOrder);
        }

        public void AddOrder(Order anOrder)
        {
            OrderList.Add(anOrder);
        }

        public decimal FindLowestOrderTotal()
        {
            // variable to hold lowest total

            decimal total = OrderList[0].OrderTotal;

            // iterate through all orders

            foreach (Order anOrder in OrderList)
            {
                if (anOrder.OrderTotal < total)
                {
                    total = anOrder.OrderTotal;
                }
            }

            return total;
        }

        public decimal GetOrderTotal()
        {
            // local variables

            decimal total = 0;

            // find OrderTotal sum

            foreach (Order anOrder in OrderList)
            {
                total += anOrder.OrderTotal;
            }

            return total;
        }

        public decimal GetAverageOrderTotal()
        {
            return GetOrderTotal()/ (decimal)OrderList.Count();
        }

        public int GetOrderCountForPizzaType(CrustAndSize crustAndSize)
        {
            int count = 0;

            foreach(Order anOrder in OrderList)
            {
                if (anOrder.PizzaType == crustAndSize)
                {
                    count++;
                }
            }

            return count;
        }

        public decimal GetOrderTotalForPizzaChoice(string pizzaChoice)
        {
            decimal total = 0;

            foreach(Order anOrder in OrderList)
            {
                if (anOrder.PizzaChoice == pizzaChoice)
                {
                    total += anOrder.OrderTotal;
                }
            }

            return total;
        }



        #endregion
    }
}
