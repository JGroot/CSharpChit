//  Chapter 7. Challenge 7. Population Data
//  In the Chap07 folder of the Student Sample Programs, you will find a file named USPopulation.txt. 
//  The file contains the midyear population of the United States, in thousands, during the years
//  1950 through 1990. The first line in the file contains the population for 1950, the second line 
//  contains the population for 1951, and so forth. 
//  Create an application that reads the file’s contents into an array or a List. The application 
//  should display the following data: 
//  • The average annual change in population during the time period 
//  • The year with the greatest increase in population during the time period 
//  • The year with the least increase in population during the time period
//  Author:  Jessica Groot
//  Date:  02/07/2016


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace PopulationData
{
    public partial class frmPopulationData : Form
    {
        private static Dictionary<int, int> _PopulationData;
        public frmPopulationData()
        {
            InitializeComponent();
        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data = File.ReadAllLines("USPopulation.txt");
                if (data.Length > 0)
                {
                    _PopulationData = new Dictionary<int, int>();
                    ConvertDataToInt(data);
                    PrintAverageAnnualPopulationGrowth();
                    PrintGreatestPopulationIncreaseYear();
                    PrintLeastPopluationIncreaseYear();
                }
                else
                    MessageBox.Show("No data found in USPopulation.txt");
            }
            catch (IOException)
            {
                MessageBox.Show("Error: USPopulation.txt not found.  Place the file in the solution's bin/debug folder and try again.");
            }
         }

        private void ConvertDataToInt(string[] populationData)
        {
           int year = 1950; //beginning year
            for (int entry = 0; entry < populationData.Length; entry++)
            {
                _PopulationData.Add(year, Convert.ToInt32(populationData[entry]));
                year++;
            }
        }

        private void PrintAverageAnnualPopulationGrowth()
        {
            double pastYear = 0;
            double totalChange = 0;
            double annualPercentageChange = 0;
            double totalPercentageChange = 0;
            double annualAveragePercent = 0;

            foreach (KeyValuePair<int, int> currentYear in _PopulationData)
            {
                if (currentYear.Key == 1950)
                    pastYear = currentYear.Value;
                else
                {
                    totalChange += currentYear.Value - pastYear;
                    annualPercentageChange = totalChange / pastYear;
                    totalPercentageChange += annualPercentageChange;
                    pastYear = currentYear.Value;
                }
            }
            if (totalPercentageChange > 0)
                annualAveragePercent = (totalPercentageChange / _PopulationData.Count) * 100;

            txtAverage.Text = annualAveragePercent.ToString("#0.##") + "%";
        }

        private void PrintGreatestPopulationIncreaseYear()
        {
           int pastYearIncrease = 0;
           int currentYearIncrease = 0;
           int greatestYear = 0;
           int pastYear = 0;
           
           foreach (KeyValuePair<int, int> currentYear in _PopulationData)
           {
               if (currentYear.Key == 1950)
               {
                   pastYear = currentYear.Value;
                   greatestYear = currentYear.Key;
               }
               else
               {
                   currentYearIncrease = currentYear.Value - pastYear;
                   if (currentYearIncrease > pastYearIncrease)
                   {
                       pastYearIncrease = currentYearIncrease;
                       pastYear = currentYear.Value;
                       greatestYear = currentYear.Key;
                   }
               }
           }
            txGreatest.Text = greatestYear.ToString();
        }

      
        private void PrintLeastPopluationIncreaseYear()
        {
            int pastYearIncrease = 0;
            int currentYearIncrease = 0;
            int leastYear = 0;
            int pastYear = 0;

            foreach (KeyValuePair<int, int> currentYear in _PopulationData)
            {
                if (currentYear.Key == 1950)
                {
                    pastYear = currentYear.Value;
                    leastYear = currentYear.Key;
                }
                else
                {
                    currentYearIncrease = currentYear.Value - pastYear;
                    if (currentYearIncrease < pastYearIncrease)
                    {
                        pastYearIncrease = currentYearIncrease;
                        pastYear = currentYear.Value;
                        leastYear = currentYear.Key;
                    }
                }
            }
            txtLeast.Text = leastYear.ToString();
        }
    }
}
