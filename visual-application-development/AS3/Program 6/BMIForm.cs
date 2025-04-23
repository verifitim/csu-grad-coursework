/*
 * Project: Assignment Set 3 Program 6
 * Developed by: Timothy Miller
 * Date Created: September 2024
 * Date Last Modified: September 2024
 * Class Name: BMI
 * Description: Presentation layer to test BMI class
 */

namespace Program6
{
    public partial class BMIForm : Form
    {
        // declare class level variable

        BMI aBMI;
        public BMIForm()
        {
            InitializeComponent();
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            // declare variables

            string userName;
            int userWeight, userHeight;
            double userBmi;

            // assign values to variables

            userName = txtName.Text;
            userWeight = Convert.ToInt32(nudWeight.Value);
            userHeight = Convert.ToInt32(nudHeight.Value);

            // instantiate a BMI object

            aBMI = new BMI(userName, userWeight, userHeight);

            // calculate user BMI

            userBmi = aBMI.CalculateBMI();

            // display BMI in label

            lblOutput.Text = userBmi.ToString("n2");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear name field

            txtName.Clear();

            // reset height and weight numeric up downs

            nudHeight.Value = nudHeight.Minimum;
            nudWeight.Value = nudWeight.Minimum;

            // clear label

            lblOutput.ResetText();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
