// X1084
// Lab 7 
// 3/28/2018
// CIS 199-02
// This program takes a user desired future value, Annual interest rate and number of years, then outputs the amount of money one must invest now to obtain the future value desired.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }
        //precondition: click 
        //postcondition: the following code is executed 
        private void calcButton_Click(object sender, EventArgs e)
        {
            double futureValue; //  user desired future value 
            int numYears; //  number of years the user wishes to wait to achieve the future value 
            double annualInterest; //  user input annual interest rate 


            if(double.TryParse(futureValueTextBox.Text, out futureValue) && futureValue >= 0) // Ensures future value is valid numeric input
            {
                if(double.TryParse(annualTextBox.Text, out annualInterest) && annualInterest >= 0) // Ensures annual interest rate is numeric input 
                {
                    if(int.TryParse(yearTextBox.Text, out numYears) && numYears >= 0) // Ensures number of year is valid numeric input 
                    {
                        //output 
                       presentValueTextBox.Text = ($"{CalcPresentValue(futureValue, annualInterest, numYears):C2}");


                    }
                    else
                    {
                        // error message 
                        MessageBox.Show("Please enter valid number of years ");
                    }

                }
                else
                {      // error message 
                    MessageBox.Show("Please enter valid annual interest");
                }

            }
            else
            {        // error message 
                MessageBox.Show("Please entr valid future value "); 
            }

        }
        //Precondition: futureValue >= 0,  annualInterest >= 0, numYears >= 0 
        //Postcondition: the present value function is executed based on the peramiters, present value is returned 
        private double CalcPresentValue(double futureValue, double annualInterest, int numYears)
        {
            double presentValue; // present value one must invest to reach future value 

            presentValue = futureValue / (Math.Pow((1 + annualInterest), numYears));

            return  presentValue; 
        }
    }
}
