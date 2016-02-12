//      Create an application that reads these three files and stores their contents in a jagged array. 
//      The array’s first row should hold the exam scores for the students in section 1, the second row 
//      should hold the exam scores for the students in section 2, and the third row should hold the
//      exam scores for the students in section 3. 
//      The application should display each section’s exam scores in a separate ListBox control and then
//      use the jagged array to determine the following: 
//          • The average exam score for each individual section 
//          • The average exam score for all the students in the three sections 
//          • The highest exam score among all three sections and the section number in which that score was found 
//          • The lowest exam score among all three sections and the section number in which that score was found
// 
// Author: Jessica Groot
// Date: 02/12/2016
// Chapter 7, Programming Challenge 9

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class ExamScores : Form
    {
        int[][] examScores;
        public ExamScores()
        {
            InitializeComponent();
        }

        private void btnLoadScores_Click(object sender, EventArgs e)
        {
            string[] exam1 = File.ReadAllLines("Section1.txt");
            string[] exam2 = File.ReadAllLines("Section2.txt");
            string[] exam3 = File.ReadAllLines("Section3.txt");
            lstbxSection1.Items.AddRange(exam1);
            lstbxSection2.Items.AddRange(exam2);
            lstbxSection3.Items.AddRange(exam3);

            examScores = new int[3][];
            examScores[0] = ConvertStringToInt(exam1);
            examScores[1] = ConvertStringToInt(exam2);
            examScores[2] = ConvertStringToInt(exam3);

            txtAverage1.Text = CalculateAverage(examScores[0]).ToString();
            txtAverage2.Text = CalculateAverage(examScores[1]).ToString();
            txtAverage3.Text = CalculateAverage(examScores[2]).ToString();

            txtTotalAverage.Text = CalculateAverage().ToString();

            int highestScore = GetHighestScore();
            txtHighest.Text = highestScore.ToString();
            txtHighestSections.Text = GetSectionNumbers(highestScore);

            int lowestScore = GetLowestScore();
            txtLowest.Text = lowestScore.ToString();
            txtLowestSections.Text = GetSectionNumbers(lowestScore);          
        }

        private int[] ConvertStringToInt(string[] scores)
        {
            int[] intScore = new int[scores.Length];
            for (int i = 0; i < scores.Length; i++ )
            {
                intScore[i] = Convert.ToInt32(scores[i]);
            }
            return intScore;
        }

        private int AddScores(int[] scores)
        {
            int total = 0;
            foreach (int score in scores)
                total += score;
            return total;
        }

        private int CalculateAverage(int[] scores)
        {
            int total = AddScores(scores);
            int average = total / scores.Length;
            return average;
        }

        private int CalculateAverage()
        {
            int average = 0;
            int total = 0;
            int numberOfScores = 0;
            foreach (int[] section in examScores)
            {
                total += AddScores(section);
                numberOfScores += section.Length;
            }
            average = total / numberOfScores;
            return average;
        }

        private int GetHighestScore(int[] scores)
        {
            int highest = 0;
            foreach (int score in scores)
                if (highest < score)
                    highest = score;
            return highest;
        }

        private int GetLowestScore(int[] scores)
        {
            int lowest = 100;
            foreach (int score in scores)
                if (lowest > score)
                    lowest = score;
            return lowest;
        }

        private int GetHighestScore()
        {
            int highest = 0;
            int sectionHighest = 0;
            foreach (int[] section in examScores)
            {
                sectionHighest = GetHighestScore(section);
                if (highest < sectionHighest)
                    highest = sectionHighest;
            }
            return highest;
        }

        private int GetLowestScore()
        {
            int lowest = 100;
            int sectionLowest = 0;
            foreach (int[] section in examScores)
            {
                sectionLowest = GetLowestScore(section);
                if (lowest > sectionLowest)
                    lowest = sectionLowest;
            }
            return lowest;
        }

        private string GetSectionNumbers(int scoreToFind)
        {
            string sectionNumbers = string.Empty;
            int sectionFlag = 0;

            foreach (int[] section in examScores)
            {
                sectionFlag++;
                foreach (int score in section)
                {
                    if (scoreToFind == score)
                    {
                        sectionNumbers +=  sectionFlag.ToString() + ", ";
                        break;
                    }
                }              
            }
            if (sectionNumbers != string.Empty)
                 sectionNumbers = sectionNumbers.Remove(sectionNumbers.Length - 2);
            return sectionNumbers;
        }
    }
}
