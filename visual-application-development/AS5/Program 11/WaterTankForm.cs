/*
 * Project: Assignment Set 5 Program 11
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: WaterTankForm
 * Description: Interface for the WaterTank class
 */

namespace Program11
{
    public partial class WaterTankForm : Form
    {
        private WaterTank aWaterTank;
        public WaterTankForm()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs 

            nudRadius.Value = nudRadius.Minimum;
            nudDepth.Value = nudDepth.Minimum;
            nudAddWithdraw.Value = nudAddWithdraw.Minimum;
            nudFillDrain.Value = nudFillDrain.Minimum;

            radAdd.Checked = true;
            radFill.Checked = true;

            lblResult.Text = null;
            lblCurrent.Text = null;
            lblMax.Text = null;
            txtFillDrainResult.Clear();

            // enable/disable controls

            grpWaterTankData.Enabled = true;
            grpIncreaseReduce.Enabled = false;
            grpWaterData.Enabled = false;
            grpFillDrain.Enabled = false;

            // set focus

            nudRadius.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // grab inputs

            int tankRadius = Convert.ToInt32(nudRadius.Value);
            int tankDepth = Convert.ToInt32(nudDepth.Value);

            // instantiate object

            aWaterTank = new WaterTank(tankRadius, tankDepth);

            // enable/disable controls

            grpWaterTankData.Enabled = false;
            grpIncreaseReduce.Enabled = true;
            grpWaterData.Enabled = true;
            grpFillDrain.Enabled = true;
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = $"{aWaterTank.WaterLevel.ToString("n0")} Litres";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lblMax.Text = $"{aWaterTank.TankCapacity.ToString("n0")} Litres";
        }

        private void btnAddWithdraw_Click(object sender, EventArgs e)
        {
            // grab input

            int litres = Convert.ToInt32(nudAddWithdraw.Value);

            // call on WaterTank methods

            lblResult.Text = (radAdd.Checked) ? aWaterTank.AddWater(litres)
                : aWaterTank.WithdrawWater(litres);

            // update current water level label

            btnCurrent_Click(sender, e);
        }
        private void btnFillDrain_Click(object sender, EventArgs e)
        {
            // grab input & local variables

            int litresPerSecond = Convert.ToInt32(nudFillDrain.Value);
            string output = string.Empty;

            // call on WaterTank methods to fill or drain

            if (radFill.Checked)
            {
                do
                {
                    output += aWaterTank.WaterLevel.ToString("n0") + "Litres\r\n";
                    txtFillDrainResult.Text = output;
                } while (aWaterTank.FillTank(litresPerSecond));
            }
            else
            {
                do
                {
                    output += aWaterTank.WaterLevel.ToString("n0") + "Litres\r\n";
                    txtFillDrainResult.Text = output;
                } while (aWaterTank.DrainTank(litresPerSecond));

            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
