namespace AssignmentBMICalculator
{
    partial class BMICalculatorForm
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
            this.BMItableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Headinglabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.BMIResulttextBox = new System.Windows.Forms.TextBox();
            this.KgradioButton = new System.Windows.Forms.RadioButton();
            this.PoundradioButton = new System.Windows.Forms.RadioButton();
            this.BMItableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMItableLayoutPanel
            // 
            this.BMItableLayoutPanel.ColumnCount = 2;
            this.BMItableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.56458F));
            this.BMItableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.43542F));
            this.BMItableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.BMItableLayoutPanel.Controls.Add(this.HeightLabel, 0, 2);
            this.BMItableLayoutPanel.Controls.Add(this.WeighttextBox, 1, 1);
            this.BMItableLayoutPanel.Controls.Add(this.textBox1, 1, 2);
            this.BMItableLayoutPanel.Controls.Add(this.Headinglabel, 0, 0);
            this.BMItableLayoutPanel.Location = new System.Drawing.Point(12, 28);
            this.BMItableLayoutPanel.Name = "BMItableLayoutPanel";
            this.BMItableLayoutPanel.RowCount = 6;
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60305F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60305F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.41221F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.17557F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60305F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60305F));
            this.BMItableLayoutPanel.Size = new System.Drawing.Size(280, 261);
            this.BMItableLayoutPanel.TabIndex = 0;
            this.BMItableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BMItableLayoutPanel_Paint);
            // 
            // WeightLabel
            // 
            this.WeightLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.WeightLabel.Location = new System.Drawing.Point(3, 43);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(149, 41);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = " My Weight";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoEllipsis = true;
            this.HeightLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.HeightLabel.Location = new System.Drawing.Point(3, 86);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(149, 41);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = " My Height";
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeighttextBox.Location = new System.Drawing.Point(164, 46);
            this.WeighttextBox.MaxLength = 3;
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(110, 38);
            this.WeighttextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(164, 89);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 38);
            this.textBox1.TabIndex = 1;
            // 
            // Headinglabel
            // 
            this.Headinglabel.BackColor = System.Drawing.Color.Gray;
            this.BMItableLayoutPanel.SetColumnSpan(this.Headinglabel, 2);
            this.Headinglabel.Location = new System.Drawing.Point(3, 0);
            this.Headinglabel.Name = "Headinglabel";
            this.Headinglabel.Size = new System.Drawing.Size(265, 43);
            this.Headinglabel.TabIndex = 2;
            this.Headinglabel.Text = "BMI Calculator";
            this.Headinglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.56458F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.43542F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ResulttextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CalculateButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Resetbutton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Exitbutton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.KgradioButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PoundradioButton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.99274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.65891F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.73802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46006F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.75563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.45083F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BMItableLayoutPanel_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = " My Weight";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = " My Height";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(169, 43);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 38);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(169, 89);
            this.textBox3.MaxLength = 3;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 38);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "BMI Calculator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoEllipsis = true;
            this.ResultLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.ResultLabel.Location = new System.Drawing.Point(3, 174);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(149, 39);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = " My BMI";
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResulttextBox.Location = new System.Drawing.Point(169, 177);
            this.ResulttextBox.MaxLength = 3;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(110, 38);
            this.ResulttextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateButton, 2);
            this.CalculateButton.Location = new System.Drawing.Point(3, 216);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(265, 41);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.Maroon;
            this.Resetbutton.Location = new System.Drawing.Point(3, 265);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(155, 44);
            this.Resetbutton.TabIndex = 3;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Maroon;
            this.Exitbutton.Location = new System.Drawing.Point(169, 265);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(116, 45);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            // 
            // BMIResulttextBox
            // 
            this.BMIResulttextBox.BackColor = System.Drawing.Color.DimGray;
            this.BMIResulttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResulttextBox.Location = new System.Drawing.Point(15, 319);
            this.BMIResulttextBox.Multiline = true;
            this.BMIResulttextBox.Name = "BMIResulttextBox";
            this.BMIResulttextBox.Size = new System.Drawing.Size(277, 119);
            this.BMIResulttextBox.TabIndex = 1;
            this.BMIResulttextBox.Text = "Underweight:  18.5 below\r\nNormal:            18.5 to 24.9\r\noverweight:      25 to" +
    " 29.9\r\nObese:               30 above\r\n";
            // 
            // KgradioButton
            // 
            this.KgradioButton.AutoSize = true;
            this.KgradioButton.Location = new System.Drawing.Point(3, 134);
            this.KgradioButton.Name = "KgradioButton";
            this.KgradioButton.Size = new System.Drawing.Size(65, 35);
            this.KgradioButton.TabIndex = 4;
            this.KgradioButton.TabStop = true;
            this.KgradioButton.Text = "Kg";
            this.KgradioButton.UseVisualStyleBackColor = true;
            this.KgradioButton.CheckedChanged += new System.EventHandler(this.KgradioButton_CheckedChanged);
            // 
            // PoundradioButton
            // 
            this.PoundradioButton.AutoSize = true;
            this.PoundradioButton.Location = new System.Drawing.Point(169, 134);
            this.PoundradioButton.Name = "PoundradioButton";
            this.PoundradioButton.Size = new System.Drawing.Size(110, 35);
            this.PoundradioButton.TabIndex = 5;
            this.PoundradioButton.TabStop = true;
            this.PoundradioButton.Text = "Pound";
            this.PoundradioButton.UseVisualStyleBackColor = true;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMIResulttextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BMItableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BMItableLayoutPanel.ResumeLayout(false);
            this.BMItableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMItableLayoutPanel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Headinglabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.TextBox BMIResulttextBox;
        private System.Windows.Forms.RadioButton KgradioButton;
        private System.Windows.Forms.RadioButton PoundradioButton;
    }
}

