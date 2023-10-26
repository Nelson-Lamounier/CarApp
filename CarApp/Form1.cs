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
    public partial class CarClass : Form
    {
        public CarClass()
        {
            InitializeComponent();
        }

        private void labelSpeed_Click(object sender, EventArgs e)
        {

        }

        Car car; // Create a variable of type car at the form level to be use for accelerate and brake buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Instantiate the second form
            UserInputForm frm2 = new UserInputForm();
            frm2.ShowDialog(); //Display the form, when user clicks the ad button, we instantiate the obeject of the second form
            car = frm2.car; // Reference properties of the car that was created on the second form

            CarDisplay();
            // Enable buttons once car is created/accessible
            btnAcc.Enabled = true;
            btnBreak.Enabled = true;
        }

        private void CarDisplay() // Displays the make and year inputed on form 2 to form 1 - calling the method on add button click event
        {
            txtCarMake.Text = car.Make;
            txtCarY.Text = car.Year.ToString();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            // Calling the methods to display current car speed (+ *5)
            car.Accelarate();
            txtSpeed.Text = car.Speed.ToString();

        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (car.Speed > 0) // Insure that car does not display negativa Speed
            // Calling the method to decrease speed (- *5)
                car.Break();
            txtSpeed.Text = car.Speed.ToString();
        }
    }
}
