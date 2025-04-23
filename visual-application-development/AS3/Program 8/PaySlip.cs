/*
 * Project: Assignment Set 3 Program 8
 * Developed by: Timothy Miller
 * Date Created: September 2024
 * Date Last Modified: September 2024
 * Class Name: PaySlip
 * Description: Class for payroll operations
 */

using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program8
{
    internal class PaySlip
    {

        #region "Constants"

        const decimal fedTaxRate = 0.1329m, stateTaxRate = 0.0355m, socialTaxRate = 0.0717m, medicareTaxRate = 0.0168m;

        #endregion

        #region "Fields"

        internal readonly string EmployeeName;
        internal readonly decimal HoursWorked, PayRate, NetPay;

        #endregion

        #region "Properties"

        public static int TotalPaySlips { get; private set; }
        public static decimal TotalGrossPay {  get; private set; }
        public static decimal TotalNetPay { get; private set; }

        #endregion

        #region "Constructor"

        public PaySlip(string employeeName, decimal hoursWorked, decimal payRate)
        {
            EmployeeName = employeeName;
            HoursWorked = hoursWorked;
            PayRate = payRate;
            NetPay = CalculateNetPay();
        }

        #endregion

        #region "Methods"

        private decimal CalculateNetPay()
        {
            // create variables

            decimal grossPay, fedTax, stateTax, socialTax, medicareTax, netPay;  

            // calculate gross pay

            grossPay = HoursWorked * PayRate;

            // caluculate various taxes

            fedTax = grossPay * fedTaxRate;
            stateTax  = grossPay * stateTaxRate;
            socialTax = grossPay * socialTaxRate;
            medicareTax = grossPay * medicareTaxRate;

            // determine net pay

            netPay = grossPay - fedTax - stateTax - socialTax - medicareTax;

            // increment static properties

            TotalPaySlips++;
            TotalGrossPay += grossPay;
            TotalNetPay += netPay;

            // return net pay

            return netPay;
        }

        public static decimal CalculateAverageNetPay()
        {
            decimal avgNetPay;

            avgNetPay = TotalNetPay / TotalPaySlips;

            return avgNetPay;
        }

        #endregion

    }
}
