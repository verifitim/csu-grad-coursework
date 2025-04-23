/*
 * Project: Assignment Set 2 Project 4
 * Date: September 2024
 * Developed By: Timothy Miller
 * Class Name: Program4 Presentation Layer
 * Purpose: Demonstrates how to use a static class to do calculations with form input
 * Uses: Loan Class
*/

namespace Program4
{
    public partial class Program4 : Form
    {
        public Program4()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            int loanAmount, loanDuration;

            double annualInterestRate, monthlyPayment;

            // convert data in numeric up down controls and assign to variables

            loanAmount = Convert.ToInt32(updownAmount.Value);
            loanDuration = Convert.ToInt32(updownDuration.Value);
            annualInterestRate = Convert.ToDouble(updownRate.Value);

            // use Loan class method CalculateMonthlyPayment to determine monthlyPayment

            monthlyPayment = Loan.CalculateMonthlyPayment(loanAmount, loanDuration, annualInterestRate);

            // display monthlyPayment value on lblPayment

            lblPayment.Text = monthlyPayment.ToString("n2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            lblPayment.Text = null;
            updownAmount.Value = 0;
            updownDuration.Value = 0;
            updownRate.Value = 0;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }
    }
}
