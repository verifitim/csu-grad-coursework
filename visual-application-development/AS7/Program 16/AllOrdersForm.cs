/*
 * Project:         Assignment Set 7 - Program 16
 * Date:            December 2024
 * Developed By:    TM
 * Class Name:      AllOrdersForm
 * Assumption:      Shows a matrix of orders and properties
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program16
{
    public partial class AllOrdersForm : Form
    {
        public AllOrdersForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
