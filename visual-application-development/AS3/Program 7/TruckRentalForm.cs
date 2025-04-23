/*
 * Project: Assignment Set 3 Program 7
 * Developed by: Timothy Miller
 * Date Created: September 2024
 * Date Last Modified: September 2024
 * Class Name: TruckRental
 * Description: Presentation layer to test TruckRental class
 */

namespace Program7
{
    public partial class TruckRentalForm : Form
    {

        // declare class level variable

        TruckRental aTruckRental;
        public TruckRentalForm()
        {
            InitializeComponent();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            // declare variables

            string nameOfCustomer;
            int endMiles, beginMiles, numDays;

            // assign inputs to variables

            nameOfCustomer = lblCustomerName.Text;
            endMiles = Convert.ToInt32(nudEndMiles.Value);
            beginMiles = Convert.ToInt32(nudBeginMiles.Value);
            numDays = Convert.ToInt32(nudNumDays.Value);

            // instantiate TruckRental object

            aTruckRental = new TruckRental(nameOfCustomer, endMiles, beginMiles, numDays);

            // calcualte rental charge

            aTruckRental.CalculateRentalCharge();

            // display rental charge

            lblRentalCharge.Text = aTruckRental.RentalCharge.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear customer name field

            txtCustomerName.Clear();

            // clear numeric up downs 

            nudBeginMiles.Value = nudBeginMiles.Minimum;
            nudEndMiles.Value = nudEndMiles.Minimum;
            nudNumDays.Value = nudNumDays.Minimum;

            // clear rental charge display

            lblRentalCharge.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudBeginMiles_ValueChanged(object sender, EventArgs e)
        {
            nudEndMiles.Value = nudBeginMiles.Value + 1;
        }
    }
}
