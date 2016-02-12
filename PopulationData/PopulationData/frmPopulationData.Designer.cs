namespace PopulationData
{
    partial class frmPopulationData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txGreatest = new System.Windows.Forms.TextBox();
            this.txtLeast = new System.Windows.Forms.TextBox();
            this.btnCalulate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average annual change in population:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year with the greatest increase in population:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year with the least increase in population:";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(224, 81);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 3;
            // 
            // txGreatest
            // 
            this.txGreatest.Location = new System.Drawing.Point(256, 123);
            this.txGreatest.Name = "txGreatest";
            this.txGreatest.Size = new System.Drawing.Size(100, 20);
            this.txGreatest.TabIndex = 4;
            // 
            // txtLeast
            // 
            this.txtLeast.Location = new System.Drawing.Point(240, 166);
            this.txtLeast.Name = "txtLeast";
            this.txtLeast.Size = new System.Drawing.Size(100, 20);
            this.txtLeast.TabIndex = 5;
            // 
            // btnCalulate
            // 
            this.btnCalulate.Location = new System.Drawing.Point(34, 32);
            this.btnCalulate.Name = "btnCalulate";
            this.btnCalulate.Size = new System.Drawing.Size(75, 23);
            this.btnCalulate.TabIndex = 6;
            this.btnCalulate.Text = "Calculate";
            this.btnCalulate.UseVisualStyleBackColor = true;
            this.btnCalulate.Click += new System.EventHandler(this.btnCalulate_Click);
            // 
            // frmPopulationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 233);
            this.Controls.Add(this.btnCalulate);
            this.Controls.Add(this.txtLeast);
            this.Controls.Add(this.txGreatest);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPopulationData";
            this.Text = "Population Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txGreatest;
        private System.Windows.Forms.TextBox txtLeast;
        private System.Windows.Forms.Button btnCalulate;
    }
}

