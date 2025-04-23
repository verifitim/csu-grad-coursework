namespace Program5
{
    public partial class Program5 : Form
    {
        // declare class-level variable

        PaintJob aPaintJob;
        public Program5()
        {
            InitializeComponent();
        }

        private void btnCreatePaint_Click(object sender, EventArgs e)
        {
            // instantiate a PaintJob object

            aPaintJob = new PaintJob();

            // declare local variables

            int area;
            double costPerGallon, estimatedCost;
            string message;

            // assign input to variables

            area = Convert.ToInt32(updownArea.Value);
            costPerGallon = Convert.ToDouble(updownCostPerGallon.Value);

            // call CalculateEstimatedCost method

            estimatedCost = aPaintJob.CalculateEstimatedCost(area, costPerGallon);

            // construct message

            message = $"Estimated Cost: {estimatedCost.ToString("n2")}";

            // display result in a message box

            MessageBox.Show(message, "Paint Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset form for fresh input

            updownArea.Value = 0;
            updownCostPerGallon.Value = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close form

            this.Close();
        }
    }
}
