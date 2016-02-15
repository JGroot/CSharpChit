//  Sum of Numbers in a String 
//  Create an application that lets the user enter a string containing 
//  series of numbers separated by commas. Here is an example of valid input: 
//      7, 9, 10, 2, 18, 6 
//  The program should calculate and display the sum of all the numbers.
//Author:  Jessica Groot
//Date: 02/10/2016


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SumOfNumbers
{
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();
        }
    
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtNumbers.Text;
            string[] numbers = { };
            decimal total = 0;
            string error = string.Empty;
            lblError.Text = string.Empty;

            if (input != string.Empty)
            {
                numbers = Regex.Split(input, "\\s?,\\s?");
                foreach (string number in numbers)
                {
                    if (number != string.Empty)
                    {
                        string formattedNum = number.Trim();
                        if (Regex.IsMatch(formattedNum, "^\\d*\\.?\\d+?$"))
                            total += Convert.ToDecimal(formattedNum);
                        else
                            error += "\'" + formattedNum + "\'" + "is not a valid number." + Environment.NewLine;
                    }
                }
            }
            lblAnswer.Text = total.ToString();
            if (error != string.Empty)
                lblError.Text = error; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
