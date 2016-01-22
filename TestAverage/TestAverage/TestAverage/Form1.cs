using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace TestAverage
{
    public partial class Form1 : Form
    {
        //public Form1()
        //{
        //    InitializeComponent();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    const int SIZE = 5;
        //    int[] scores = new int { SIZE };
        //    int index = 0;
        //    int highestScore;
        //    int lowestScore;
        //    double averageScore;

        //    inputFile = File.OpenText("TestScores.txt");

        //    while (!inputFile.EndOfStream && index<scores.Length)
        //    {
        //        scores[index] = int.Parse(inputFile.ReadLine());
        //        index++;
        //    }

        //    inputFile.Close();

        //    foreach (int value in scores)
        //        listBox1.Items.Add(value);

        //    highestScore = Highest(scores);
        //    lowestScore = Lowest(scores);
        //    averageScore = Average(scores);

        //    textBox1.Text = highestScore.ToString();
        //    textBox2.Text = lowestScore.ToString();
        //    textBox3.Text = averageScore.ToString();
        //}

        //private double Average(int[] iArray)
        //{
        //    int total = 0;
        //    double average;
        //    for (int index = 0; index < iArray.Length; index++)
        //        total += iArray[index];

        //    average = (double)total / iArray.Length;
        //    return average;
        //}

        //private int Highest(int[] iArray)
        //{
        //    int highest = iArray[0];
        //    for (int index = 1; index < iArray.Length; index++)
        //        if (iArray[index] > highest)
        //            highest = iArray[index];
        //    return highest;
        //}

        //private int Lowest(int[] iArray)
        //{
        //    int lowest = iArray[0];
        //    for (int index = 1; index < iArray.Length; index++)
        //        if (iArray[index] < lowest)
        //            lowest = iArray[index];
        //    return lowest;
        //}
    }
}
