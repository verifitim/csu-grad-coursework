/*
 * Project: Assignment Set 2 Program 3
 * Date Created: September 2024
 * Date Modified: September 2024
 * Developed by: Timothy Miller
 * Class Name: Program 3 Form
 * Class Description: UI Class for interactive form that changes appearance based on user input
 */

using System.Threading.Channels;

namespace Program3
{
    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
        }

        // Closes form window
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // When radioBlue selected, changes lblTagline to Blue

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblTagline.ForeColor = Color.Blue;
        }

        // When radioGreen selected, changes lblTagline to Green
        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblTagline.ForeColor = Color.Green;
        }

        // When radioOrange selected, changes lblTagline to Orange
        private void radioOrange_CheckedChanged(object sender, EventArgs e)
        {
            lblTagline.ForeColor = Color.Orange;
        }

        // When radioRed selected, changes lblTagline to Red
        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            lblTagline.ForeColor = Color.Red;
        }

        // Shows/hides lblTitle when chkboxTitle is changed
        private void chkboxTitle_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Visible = chkboxTitle.Checked;
        }

        // Shows/hides lblTagline when chkboxTagline is changed
        private void chkboxTagline_CheckedChanged(object sender, EventArgs e)
        {
            lblTagline.Visible = chkboxTagline.Checked;
        }

        // Shows/hides logo when chkboxLogo is changed
        private void chkboxLogo_CheckedChanged(object sender, EventArgs e)
        {
            logo.Visible = chkboxLogo.Checked;
        }

        // Shows/hides logo when chkboxLogo is changed
        private void chkboxDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            lblDeveloper.Visible = chkboxDeveloper.Checked;
        }
    }
}
