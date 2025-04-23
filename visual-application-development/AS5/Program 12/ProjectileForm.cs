/*
 * Project: Assignment Set 5 Program 12
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: ProjectileForm
 * Description: Interface for the Projectile class
 */

namespace Program12
{
    public partial class ProjectileForm : Form
    {
        // decalare object

        private Projectile aProjectile;
        public ProjectileForm()
        {
            InitializeComponent();
        }

        private void btnCreateProjectile_Click(object sender, EventArgs e)
        {
            // input & local variables

            int initialHeight = Convert.ToInt32(nudInitialHeight.Value);
            int initialVelocity = Convert.ToInt32(nudInitialVelocity.Value);

            // instantiate object

            aProjectile = new(initialHeight, initialVelocity);

            // enable/disable controls

            grpProjectileData.Enabled = false;
            grpProjectileMotionInfo.Enabled = true;
            grpResetExit.Enabled = true;
        }

        private void btnMaximumHeight_Click(object sender, EventArgs e)
        {
            string message = aProjectile.MaxHeight.ToString("n2") + " ft";

            lblMaximumHeight.Text = message;
        }

        private void btnLandingTime_Click(object sender, EventArgs e)
        {
            string message = aProjectile.LandTime.ToString("n2") + " s";

            lblLandingTime.Text = message;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            nudInitialHeight.Value = nudInitialHeight.Minimum;
            nudInitialVelocity.Value = nudInitialVelocity.Minimum;

            lblMaximumHeight.Text = null;
            lblLandingTime.Text = null;

            // enable disable controls

            grpProjectileData.Enabled = true;
            grpProjectileMotionInfo.Enabled = false;
            grpResetExit.Enabled = false;

            // set focus

            nudInitialHeight.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
