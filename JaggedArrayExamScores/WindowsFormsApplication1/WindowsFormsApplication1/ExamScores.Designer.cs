namespace WindowsFormsApplication1
{
    partial class ExamScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbxSection1 = new System.Windows.Forms.ListBox();
            this.lstbxSection2 = new System.Windows.Forms.ListBox();
            this.lstbxSection3 = new System.Windows.Forms.ListBox();
            this.btnLoadScores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAverage1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAverage2 = new System.Windows.Forms.TextBox();
            this.txtAverage3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHighest = new System.Windows.Forms.TextBox();
            this.txtHighestSections = new System.Windows.Forms.TextBox();
            this.Section = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLowest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLowestSections = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstbxSection1
            // 
            this.lstbxSection1.FormattingEnabled = true;
            this.lstbxSection1.Location = new System.Drawing.Point(98, 41);
            this.lstbxSection1.Name = "lstbxSection1";
            this.lstbxSection1.Size = new System.Drawing.Size(87, 134);
            this.lstbxSection1.TabIndex = 0;
            // 
            // lstbxSection2
            // 
            this.lstbxSection2.FormattingEnabled = true;
            this.lstbxSection2.Location = new System.Drawing.Point(204, 41);
            this.lstbxSection2.Name = "lstbxSection2";
            this.lstbxSection2.Size = new System.Drawing.Size(87, 134);
            this.lstbxSection2.TabIndex = 1;
            // 
            // lstbxSection3
            // 
            this.lstbxSection3.FormattingEnabled = true;
            this.lstbxSection3.Location = new System.Drawing.Point(313, 41);
            this.lstbxSection3.Name = "lstbxSection3";
            this.lstbxSection3.Size = new System.Drawing.Size(87, 134);
            this.lstbxSection3.TabIndex = 2;
            // 
            // btnLoadScores
            // 
            this.btnLoadScores.Location = new System.Drawing.Point(12, 41);
            this.btnLoadScores.Name = "btnLoadScores";
            this.btnLoadScores.Size = new System.Drawing.Size(75, 23);
            this.btnLoadScores.TabIndex = 3;
            this.btnLoadScores.Text = "Start";
            this.btnLoadScores.UseVisualStyleBackColor = true;
            this.btnLoadScores.Click += new System.EventHandler(this.btnLoadScores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Section 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Section 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Section 3";
            // 
            // txtAverage1
            // 
            this.txtAverage1.Location = new System.Drawing.Point(98, 185);
            this.txtAverage1.Name = "txtAverage1";
            this.txtAverage1.ReadOnly = true;
            this.txtAverage1.Size = new System.Drawing.Size(87, 20);
            this.txtAverage1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average Score";
            // 
            // txtAverage2
            // 
            this.txtAverage2.Location = new System.Drawing.Point(204, 188);
            this.txtAverage2.Name = "txtAverage2";
            this.txtAverage2.ReadOnly = true;
            this.txtAverage2.Size = new System.Drawing.Size(87, 20);
            this.txtAverage2.TabIndex = 9;
            // 
            // txtAverage3
            // 
            this.txtAverage3.Location = new System.Drawing.Point(313, 188);
            this.txtAverage3.Name = "txtAverage3";
            this.txtAverage3.ReadOnly = true;
            this.txtAverage3.Size = new System.Drawing.Size(87, 20);
            this.txtAverage3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average Score for all Sections";
            // 
            // txtTotalAverage
            // 
            this.txtTotalAverage.Location = new System.Drawing.Point(173, 240);
            this.txtTotalAverage.Name = "txtTotalAverage";
            this.txtTotalAverage.ReadOnly = true;
            this.txtTotalAverage.Size = new System.Drawing.Size(64, 20);
            this.txtTotalAverage.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Highest Score";
            // 
            // txtHighest
            // 
            this.txtHighest.Location = new System.Drawing.Point(173, 269);
            this.txtHighest.Name = "txtHighest";
            this.txtHighest.ReadOnly = true;
            this.txtHighest.Size = new System.Drawing.Size(64, 20);
            this.txtHighest.TabIndex = 14;
            // 
            // txtHighestSections
            // 
            this.txtHighestSections.Location = new System.Drawing.Point(292, 269);
            this.txtHighestSections.Name = "txtHighestSections";
            this.txtHighestSections.ReadOnly = true;
            this.txtHighestSections.Size = new System.Drawing.Size(60, 20);
            this.txtHighestSections.TabIndex = 15;
            // 
            // Section
            // 
            this.Section.AutoSize = true;
            this.Section.Location = new System.Drawing.Point(243, 272);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(48, 13);
            this.Section.TabIndex = 16;
            this.Section.Text = "Sections";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lowest Score";
            // 
            // txtLowest
            // 
            this.txtLowest.Location = new System.Drawing.Point(173, 296);
            this.txtLowest.Name = "txtLowest";
            this.txtLowest.ReadOnly = true;
            this.txtLowest.Size = new System.Drawing.Size(64, 20);
            this.txtLowest.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sections";
            // 
            // txtLowestSections
            // 
            this.txtLowestSections.Location = new System.Drawing.Point(292, 296);
            this.txtLowestSections.Name = "txtLowestSections";
            this.txtLowestSections.ReadOnly = true;
            this.txtLowestSections.Size = new System.Drawing.Size(60, 20);
            this.txtLowestSections.TabIndex = 20;
            // 
            // ExamScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 353);
            this.Controls.Add(this.txtLowestSections);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLowest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.txtHighestSections);
            this.Controls.Add(this.txtHighest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAverage3);
            this.Controls.Add(this.txtAverage2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAverage1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadScores);
            this.Controls.Add(this.lstbxSection3);
            this.Controls.Add(this.lstbxSection2);
            this.Controls.Add(this.lstbxSection1);
            this.Name = "ExamScores";
            this.Text = "Exam Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxSection1;
        private System.Windows.Forms.ListBox lstbxSection2;
        private System.Windows.Forms.ListBox lstbxSection3;
        private System.Windows.Forms.Button btnLoadScores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAverage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAverage2;
        private System.Windows.Forms.TextBox txtAverage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHighest;
        private System.Windows.Forms.TextBox txtHighestSections;
        private System.Windows.Forms.Label Section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLowest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLowestSections;
    }
}

