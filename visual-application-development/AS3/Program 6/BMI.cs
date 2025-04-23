/*
 * Project: Assignment Set 3 Program 6
 * Developed by: Timothy Miller
 * Date Created: September 2024
 * Date Last Modified: September 2024
 * Class Name: BMI
 * Description: Class for calculating BMI
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class BMI
    {

        #region "Fields"

        private string userName;
        private int userWeight, userHeight;

        #endregion

        #region "Properties"

        public string UserName{ get; set; }
        public int UserWeight{ get; set; }
        public int UserHeight {  get; set; }

        #endregion

        #region "Constructors"

        public BMI(string name, int weight, int height)
        {
            UserName = name;
            UserWeight = weight;
            UserHeight = height;
        }

        #endregion

        #region "Methods"

        // calculates and returns BMI
        public double CalculateBMI()
        {
            return UserWeight * 703 / Math.Pow(UserHeight, 2);
        }

        #endregion
    }
}
