namespace Week1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Code executed when clicking calculate button
        private void button1_Click(object sender, EventArgs e)
        {
            //Convert all fields to double
            double milesDriven = double.Parse(txtMilesDriven.Text);
            double fuelPrice = double.Parse(txtFuelPrice.Text);
            double parkingFee = double.Parse(txtParkingFee.Text);
            double tollFee = double.Parse(txtTollFee.Text);
            double carMPG = double.Parse(txtCarMPG.Text);

            //Calculation for result
            double result = (((milesDriven / carMPG) * fuelPrice) + parkingFee + tollFee) / 100;

            //Output
            MessageBox.Show("Your cost is : $" + result);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}