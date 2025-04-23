/*
 * Project: Assignment Set 5 Program 13
 * Developed by: Timothy Miller
 * Date Created: October 2024
 * Date Last Modified: October 2024
 * Class Name: FormChampion
 * Description: Interface for testing comboboxes and loops but with a tennis theme
 */

namespace Program13
{
    public partial class FormChampions : Form
    {
        public FormChampions()
        {
            InitializeComponent();
        }

        private void btnHowManyWins_Click(object sender, EventArgs e)
        {
            string tennisPlayer = cboTopPlayers.Text;
            int numTimes = 0;

            for (int i = 0; i < cboWimbledonChampions.Items.Count; ++i)
            {
                if (tennisPlayer == cboWimbledonChampions.Items[i].ToString())
                {
                    numTimes++;
                }
            }

            lblResult.Text = $"{tennisPlayer} was a Wibledon Champion {numTimes} times.";
        }

        private void btnB2B_Click(object sender, EventArgs e)
        {
            int numTimesBackToBack = 0;

            for (int i = 0; i < cboWimbledonChampions.Items.Count - 1; ++i)
            {
                if (cboWimbledonChampions.Items[i].ToString() == cboWimbledonChampions.Items[i + 1].ToString())
                {
                    numTimesBackToBack++;
                }

            }
            lblResult.Text = $"Wibledon Champions have gone back to back {numTimesBackToBack} times!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
