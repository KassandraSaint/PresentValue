using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentValue
{
    public partial class Form1 : Form
    {
        // Initializing variables to hold all of the values
        decimal futureVal = 0m;
        decimal rate = 0.05m;
        int years = 0;
        decimal presentValue = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        // Boolean method to verify user's input
        private bool InputIsValid(ref decimal futureVal, ref decimal rate, ref int years)
        {
            // Initializing flag variable for the method to return
            bool goodInput = false;
            // Trying to parse input from the user
            if (decimal.TryParse(futureBox.Text, out futureVal))
            {
                if (decimal.TryParse(rateBox.Text, out rate))
                {
                    if (int.TryParse(yearsBox.Text, out years))
                    {
                        // Changing flag variable to true if inputs are valid
                        goodInput = true;
                    }
                    // If user's input was wrong showing corresponding messages
                    else
                    {
                        MessageBox.Show("Enter number of years.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter your annual rate.");
                }
            }
            else
            {
                MessageBox.Show("Enter how much money you want to get in future.");
            }
            // Returning boolean flag variable
            return goodInput;
        }
        // Value rteturning PresentValue method to calculate amount to invest
        private decimal PresentValue(ref decimal futureVal, ref decimal rate, ref int years)
        {
            if (InputIsValid(ref futureVal, ref rate, ref years))
            {
                // Calculating present value using provided formula
                presentValue = futureVal / (decimal)Math.Pow((double)(1 + (rate / 100)), years);
            }
            return presentValue;
        }
        private void calcBtn_Click(object sender, EventArgs e)
        {
            // Calling PresentValue function to calculate value to invest
            presentValue = PresentValue(ref futureVal, ref rate, ref years);
            // Updating presentValue Label
            presentValueLabel.Text = presentValue.ToString("c");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
