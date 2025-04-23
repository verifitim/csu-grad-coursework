/*
 * Project: Assignment Set 4 Program 10
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: PropertyTaxFrom
 * Description: Graphical interface for the PropertyTax class
 */

namespace Program10
{
    public partial class PropertyTaxForm : Form
    {
        // declare object

        PropertyTax aPropertyTax;
        public PropertyTaxForm()
        {
            InitializeComponent();
        }

        private void PropertyTaxForm_Load(object sender, EventArgs e)
        {
            // set maximum year built value to this year

            nudYearBuilt.Maximum = DateTime.Now.Year;

            // clear nud field default values

            nudBuildingSquareFootage.Text = string.Empty;
            nudLandSquareFootage.Text = string.Empty;
            nudYearBuilt.Text = string.Empty;

        }

        private void btnCreatePropertyTax_Click(object sender, EventArgs e)
        {
            // validate input

            if (txtPropertyOwnerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Owner Name is required", "Input Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPropertyOwnerName.Focus();
                return;
            }

            //if (nudBuildingSquareFootage.ValueChanged == nudBuildingSquareFootage.Minimum ||
            //    nudLandSquareFootage.Value == nudLandSquareFootage.Minimum ||
            //    nudYearBuilt.Value == nudYearBuilt.Minimum)
            //{
            //    MessageBox.Show("Property info is required", "Input Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // local variables

            string ownerName;
            int buildingSize, landSize, yearBuilt;
            LocationType whereLocated;

            // assign input to properties

            ownerName = txtPropertyOwnerName.Text;
            buildingSize = Convert.ToInt32(nudBuildingSquareFootage.Value);
            landSize = Convert.ToInt32(nudLandSquareFootage.Value);
            yearBuilt = Convert.ToInt32(nudYearBuilt.Value);

            if (radioCity.Checked)
            {
                whereLocated = LocationType.City;
            }
            else if (radioSuburb.Checked)
            {
                whereLocated = LocationType.Suburb;
            }
            else
            {
                whereLocated = LocationType.Rural;
            }

            // instantiate PropertyTax object

            aPropertyTax = new PropertyTax(ownerName, buildingSize, landSize, yearBuilt, whereLocated);

            // display PropertyTax info

            lblDisplay.Text = aPropertyTax.ToString();

            // disable create button

            btnCreatePropertyTax.Enabled = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear visible input

            txtPropertyOwnerName.Text = string.Empty;
            nudBuildingSquareFootage.Value = nudBuildingSquareFootage.Minimum;
            nudLandSquareFootage.Value = nudLandSquareFootage.Minimum;
            nudYearBuilt.Value = nudYearBuilt.Minimum;

            // clear values

            nudBuildingSquareFootage.Text = string.Empty;
            nudLandSquareFootage.Text = string.Empty;
            nudYearBuilt.Text = string.Empty;
            lblDisplay.Text = string.Empty;

            // enable create button

            btnCreatePropertyTax.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
