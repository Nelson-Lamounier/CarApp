using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Car //Must be Public class in order to access both forms
    {
        // Class structure (Field)
        private int _year;
        private string _make;
        private int _speed;

        // Constructor
        public Car(string make, int year)
        {
            //Assign values to our Fields - Year will equal the year inputed by user
            _make = make;
            _year = year;
            _speed = 0;
        }

        //Properties that will get and set these Fields we have 
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        // Methods for Accelerate and Stop
        // The accelerate will add plus five to speed and break will decrease the speed by five.
        public void Accelarate()// Void as we don't need to return any value because we are manipulating our fields directly
        {
            _speed += 5;
        }
        public void Break()
        {
            _speed -= 5;
        }
    }
}
