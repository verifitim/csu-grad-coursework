namespace Program8
{
    public partial class PaySlipForm : Form
    {

        // declare object variable

        private PaySlip aPaySlip;

        public PaySlipForm()
        {
            InitializeComponent();
        }

        private void btnCreatePaySlip_Click(object sender, EventArgs e)
        {
            // declare local variables

            string employeeName;
            decimal hoursWorked, payRate, netPay;

            // assign input data to variables

            employeeName = txtboxEmployeeName.Text;
            hoursWorked = nudHoursWorked.Value;
            payRate = nudPayRate.Value;

            // instantiate a PaySlip object

            aPaySlip = new PaySlip(employeeName, hoursWorked, payRate);

            // access and display NetPay

            netPay = Math.Round(aPaySlip.NetPay,2);
            lblInfo.Text = $"Net Pay: {netPay.ToString("C")}";
        }

        private void btnDisplaySummary_Click(object sender, EventArgs e)
        {
            // declare local variables

            int totalPaySlips;
            string totalGrossPay, totalNetPay, avgNetPay;

            // assign class level info to variables

            totalPaySlips = PaySlip.TotalPaySlips;
            totalGrossPay = PaySlip.TotalGrossPay.ToString("C");
            totalNetPay = PaySlip.TotalNetPay.ToString("C");
            avgNetPay = PaySlip.CalculateAverageNetPay().ToString("C");

            // display info in label

            lblInfo.Text = $"Total Pay Slips: {totalPaySlips}\n" +
                $"Total Gross Pay: {totalGrossPay}\n" +
                $"Total Net Pay: {totalNetPay}\n" +
                $"Average Net Pay: {avgNetPay}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxEmployeeName.Clear();
            nudHoursWorked.Value = nudHoursWorked.Minimum;
            nudPayRate.Value = nudPayRate.Minimum;
            lblInfo.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
