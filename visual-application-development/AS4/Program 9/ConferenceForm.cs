/*
 * Project: Assignment Set 4 Program 9
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: ConferenceForm
 * Description: Graphical interface for Conference class
 */

using Accessibility;

namespace Program9
{
    public partial class ConferenceForm : Form
    {

        // declare object variable

        Conference aConference;
        public ConferenceForm()
        {
            InitializeComponent();
        }

        private void txtConferenceName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConferenceName.Text))
            {
                // disable the Create Conference button if conference name textbox is empty

                btnCreateConference.Enabled = false;
            }
            else
            {
                // enable the Create Conference button if if conference name textbox is filled

                btnCreateConference.Enabled = true;
            }
        }

        private void btnCreateConference_Click(object sender, EventArgs e)
        {
            // local variables

            string confName;
            int numAttendees, numNights;
            AccommodationType accommodation;
            bool internet, recCenter;

            // fill variables with form data

            confName = txtConferenceName.Text;
            numAttendees = Convert.ToInt32(nudNumberOfAttendees.Value);
            numNights = Convert.ToInt32(nudNumberOfNights.Value);

            // use radio button choice to set accommodation type

            //if (radioSingle.Checked)
            //{
            //    accommodation = AccommodationType.Single;
            //}
            //else if (radioDouble.Checked)
            //{
            //    accommodation = AccommodationType.Double;
            //}
            //else
            //{
            //    accommodation = AccommodationType.Suite;
            //}

            accommodation = SetAccommodationType();

            // use check boxes to set optional services

            //if (chkboxInternetAccess.Checked)
            //{
            //    internet = true;
            //}
            //else
            //{
            //    internet = false;
            //}

            internet = SetInternetAccess();

            //if (chkboxRecCenterAccess.Checked)
            //{
            //    recCenter = true;
            //}
            //else
            //{
            //    recCenter = false;
            //}

            recCenter = SetRecCenterAccess();

            // instantiate Conference instance

            aConference = new(confName, numAttendees, numNights, accommodation, internet, recCenter);

            // disable the Create Conference button and conference name text box

            btnCreateConference.Enabled = false;
            txtConferenceName.Enabled = false;

            // enable Modify Conference Event button

            btnModifyConference.Enabled = true;

            // display conference info

            lblDisplay.Text = aConference.ToString();

        }

        private void btnModifyConference_Click(object sender, EventArgs e)
        {
            // declare variables

            int numAttendees, numNights;
            AccommodationType accommodation;
            bool internet, recCenter;

            // assign new input to variables

            numAttendees = Convert.ToInt32(nudNumberOfAttendees.Value);
            numNights = Convert.ToInt32(nudNumberOfNights.Value);
            accommodation = SetAccommodationType();
            internet = SetInternetAccess();
            recCenter = SetRecCenterAccess();

            // update aConference's properties

            aConference.NumberOfAttendees = numAttendees;
            aConference.NumberOfNights = numNights;
            aConference.AccommodationChoice = accommodation;
            aConference.InternetAccess = internet;
            aConference.RecreationCenterAccess = recCenter;

            // update label

            lblDisplay.Text = aConference.ToString();
        }

        private AccommodationType SetAccommodationType()
        {
            // declare variable

            AccommodationType accommodation;

            // use radio selection to set accommodation type

            if (radioSingle.Checked)
            {
                accommodation = AccommodationType.Single;
            }
            else if (radioDouble.Checked)
            {
                accommodation = AccommodationType.Double;
            }
            else
            {
                accommodation = AccommodationType.Suite;
            }

            return accommodation;
        }

        private bool SetInternetAccess()
        {
            // declare variable

            bool internet;

            // use check box to set internet access

            if (chkboxInternetAccess.Checked)
            {
                internet = true;
            }
            else
            {
                internet = false;
            }

            return internet;
        }

        private bool SetRecCenterAccess()
        {
            // declare variable

            bool recCenter;

            // use check box to set internet access

            if (chkboxRecCenterAccess.Checked)
            {
                recCenter = true;
            }
            else
            {
                recCenter = false;
            }

            return recCenter;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtConferenceName.Clear();
            lblDisplay.Text = string.Empty;
            nudNumberOfAttendees.Value = nudNumberOfAttendees.Minimum;
            nudNumberOfNights.Value = nudNumberOfNights.Minimum;
            radioSingle.Checked = true;
            chkboxInternetAccess.Checked = false;
            chkboxRecCenterAccess.Checked = false;

            // enable/disable buttons

            txtConferenceName.Enabled = true;
            btnCreateConference.Enabled = true;
            btnModifyConference.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult aResult;

            aResult = MessageBox.Show("Do you wish to exit?", "Exit Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtConferenceName.Focus();
            }
        }
    }
}
