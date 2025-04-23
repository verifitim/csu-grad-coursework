/*
 * Project:         Assignment Set 7 - Program 16
 * Date:            December 2024
 * Developed By:    TM
 * Class Name:      OrderMainForm
 * Assumption:      An Order Form for Pizza Orders
*/

using System.Globalization;
using System.Security.Cryptography;

namespace Program16
{
    public partial class OrderMainForm : Form
    {
        public OrderMainForm()
        {
            InitializeComponent();
        }

        // declare class-level variable of type OrderManager

        OrderManager anOrderManager = new OrderManager();

        private void OrderMainForm_Load(object sender, EventArgs e)
        {
            cboPizzaType.DataSource = Enum.GetValues(typeof(CrustAndSize));
            cboPizzaType.SelectedIndex = -1;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            string customerName, pizzaChoice;
            CrustAndSize pizzaType;
            int quantity;

            // validate input 

            if (txtCustomerName.Text == string.Empty)
            {
                MessageBox.Show("Customer Name is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }

            if (nudOrderQuantity.Value <= 0)
            {
                MessageBox.Show("Pizza Quanitity is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudOrderQuantity.Focus();
                return;
            }

            if (cboPizzaChoice.SelectedIndex == -1)
            {
                MessageBox.Show("Pizza Choice is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPizzaChoice.Focus();
                return;
            }

            if (cboPizzaType.SelectedIndex == -1)
            {
                MessageBox.Show("Pizza Type is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPizzaType.Focus();
                return;
            }

            // assign input data to variables

            customerName = txtCustomerName.Text;
            quantity = Convert.ToInt32(nudOrderQuantity.Value);
            pizzaChoice = cboPizzaChoice.Text;
            pizzaType = (CrustAndSize)cboPizzaType.SelectedValue;

            // if it is not already instantiated, instantiate aFoodManager 

            if (anOrderManager is null)
            {
                anOrderManager = new OrderManager();
            }

            // instantiate food object and add it to the FoodList collection

            anOrderManager.AddOrder(customerName, pizzaChoice, pizzaType, quantity);

            // display confirmation

            MessageBox.Show("Pizza added to order!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // disable Create button

            btnAddOrder.Enabled = false;

            // enable the display menu items

            allOrdersToolStripMenuItem.Enabled = true;
            totalOrderAmountForAPizzaChoiceToolStripMenuItem.Enabled = true;
            numberOfOrdersForAPizzaTypeToolStripMenuItem.Enabled = true;
            ordersSummaryToolStripMenuItem.Enabled = true;

            // reset for next food item

            resetForNextOrderToolStripMenuItem_Click(sender, e);
        }

        private void resetForNextOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            nudOrderQuantity.Value = nudOrderQuantity.Minimum;
            cboPizzaChoice.SelectedIndex = -1;
            cboPizzaType.SelectedIndex = -1;

            btnAddOrder.Enabled = true;

            txtCustomerName.Focus();
        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new object of type AllOrdersForm

            AllOrdersForm aForm = new AllOrdersForm();

            // connect OrderManager instance to aForm binding source

            aForm.orderManagerBindingSource.DataSource = anOrderManager;

            // show form

            aForm.ShowDialog();
        }

        private void totalOrderAmountForAPizzaChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // validate an option is selected 

            if (cboPizzaChoice.SelectedIndex == -1)
            {
                MessageBox.Show("Select Pizza Choice", "Input Error,",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // gather input

            string pizzaChoice = cboPizzaChoice.Text;

            // display info in message box

            string message = $"The Total Order Amout is {anOrderManager.GetOrderTotalForPizzaChoice(pizzaChoice).ToString("c")} for {pizzaChoice}";

            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset selection on form 

            cboPizzaChoice.SelectedIndex = -1; // remove what was being displayed in dropdown
        }

        private void numberOfOrdersForAPizzaTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // validate an option is selected 

            if (cboPizzaType.SelectedIndex == -1)
            {
                MessageBox.Show("Select Pizza Type", "Input Error,",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // gather input

            CrustAndSize aPizzaType = (CrustAndSize)cboPizzaType.SelectedValue; // need to cast generic object

            // display info in message box

            string message = $"The Number of Orders of {aPizzaType} is {anOrderManager.GetOrderCountForPizzaType(aPizzaType)}";

            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset selection on form 

            cboPizzaType.SelectedIndex = -1; // remove what was being displayed in dropdown
        }

        private void ordersSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersSummaryForm aForm = new OrdersSummaryForm();

            aForm.lblAverageOrderTotal.Text = anOrderManager.GetAverageOrderTotal().ToString("c2");
            aForm.lblLowestOrderTotal.Text = anOrderManager.FindLowestOrderTotal().ToString("c2");

            aForm.ShowDialog();
        }

        private void addPizzaChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboPizzaChoice.Text == string.Empty)
            {
                MessageBox.Show("Enter a new Pizza Choice", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPizzaChoice.Focus();
                return;
            }

            string newDiet = cboPizzaChoice.Text;  //assign the new member to be added to a variable
            bool duplicate = false;  // duplication indicator 

            //a foreach loop to iterate through the items in the list and check for possible duplication

            foreach (string aItem in cboPizzaChoice.Items) //for each item in the combo box
            {
                if (string.Equals(newDiet, aItem, StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be added
                {
                    duplicate = true; //if the member already exists in the list, set duplication indicator to true
                    break; //break out of the loop
                }
            }

            if (duplicate)  //if duplicate is true, new member is not added
            {
                MessageBox.Show("Pizza Choice not added", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPizzaChoice.Text = string.Empty;
            }
            else  //otherwise, new member is added
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo; //create a CultureInfo object and get its TextInfo property

                newDiet = aTextInfo.ToTitleCase(newDiet); //change the name of the new member to be added to proper case

                cboPizzaChoice.Items.Add(newDiet); //add the new member to the list

                MessageBox.Show("Pizza Choice added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboPizzaChoice.Text = string.Empty;
            }
        }

        private void removePizzaChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboPizzaChoice.Text == string.Empty)
            {
                MessageBox.Show("Enter a Pizza Choice to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string removeMember = cboPizzaChoice.Text;  //assign the member to be removed to a variable
            bool inList = false; // variable to capture whether member to be removed is in the list
            int removeIndex = 0; // variable to capture the index of the member to be removed

            //a for loop to iterate through the items in the list to check whether the member to be removed is in the list

            for (int i = 0; i <= cboPizzaChoice.Items.Count - 1; ++i) //why count - 1?; index of the items in the list starts at 0
            {
                if (string.Equals(removeMember, cboPizzaChoice.Items[i].ToString(), StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be dropped
                {
                    inList = true; //if the member to be dropped is in the list, set inList to true
                    removeIndex = i; // assign the index of the member to be removed
                    break; // break out of the loop
                }
            }

            if (inList)  //if inList is true, drop the member
            {
                cboPizzaChoice.Items.RemoveAt(removeIndex); // remove the member
                MessageBox.Show("Pizza Choice removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPizzaChoice.Text = string.Empty;
            }
            else  //otherwise, member is not removed
            {
                MessageBox.Show("Pizza Choice is not on list", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPizzaChoice.Focus();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
