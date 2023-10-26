using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class UserInputForm : Form
    {
        public UserInputForm()
        {
            InitializeComponent();
        }

        private void UserInputForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Car car; //Create another car object at Form level because we need to access it from the first form
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the user input
            string make = textBoxCar.Text;
            int year;

            // Validating user input
            if (!string.IsNullOrWhiteSpace(make) && int.TryParse(maskedTextBoxCar.Text, out year))
            {
                // Objects - pass the make and year once user input is validated 
                car = new Car(make, year);
                this.Close(); // Close the form and return to the main form
            }
            else
                MessageBox.Show("Invalid input");
        }
    }
}
