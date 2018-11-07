using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_Application
{
    public partial class Form1 : Form
    {
        private Car car1;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accelerateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(speedResultLabel.Text))
            {
                car1.Accelerate();
                PrintResults();
            }
        }


        private void brakeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(speedResultLabel.Text))
            {
                car1.Brake();
                PrintResults();
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(makeTextBox.Text) && !string.IsNullOrWhiteSpace(yearTextBox.Text)) {
                int year;
                int.TryParse(yearTextBox.Text, out year);
                if (year > 1900)
                {
                    car1 = new Car(year, makeTextBox.Text);
                    PrintResults();
                }
                else {
                    MessageBox.Show("Please Enter A Valid year (Greater than 1900)");
                }
                }
        }
        private void PrintResults()
        {
            makeResultLabel.Text = car1.Make;
            yearResultLabel.Text = car1.Year.ToString();
            speedResultLabel.Text = car1.Speed.ToString();
        }


        }
    }

