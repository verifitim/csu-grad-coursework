/*
 * Project: Assignment Set 2 Program 4
 * Date Created: September 2024
 * Date Modified: September 2024
 * Developed by: Timothy Miller
 * Class Name: Program 4 Form
 * Class Description: Loan class to calculate monthly loan payments
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Loan
    {
        // Calculates the monthly payment of a loan given the principal amount, duration, and annual interest rate
        internal static double CalculateMonthlyPayment(int amount, int duration, double annualRate)
        {
            double monthlyRate = annualRate / (100 * 12);
            double monthlyPayment = amount * (monthlyRate * Math.Pow(1 + monthlyRate, duration)) /
                (Math.Pow(1 + monthlyRate, duration) - 1);
            return Math.Round(monthlyPayment,2);
        }
    }
}
