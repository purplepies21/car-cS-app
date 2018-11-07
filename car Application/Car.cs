using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_Application
{
    class Car
    {
        private int _speed = 0;
        private int _year;
        private string _make;

        public Car(int year, string make) {
            Speed = 0;
            Make = make;
            Year = year;
        }
        public Car() {
            _speed = 0;
            _make = "";
            _year = 0;
        }
        public string Make {
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
        public void Accelerate() {

            Speed += 5;
        }
        public void Brake()
        {
            Speed -= 5;
        }
    }
}
