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
            this.MYweightlabel = new System.Windows.Forms.Label();
            this.MYheightlabel = new System.Windows.Forms.Label();
            this.EnterWeighttextbox = new System.Windows.Forms.TextBox();
            this.Enterheighttextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.MetricradioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.BMIcalCalculateButton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.BMIResulttextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.82759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.17241F));
            this.tableLayoutPanel1.Controls.Add(this.MYweightlabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MYheightlabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.EnterWeighttextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Enterheighttextbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BMIResultLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MetricradioButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ResulttextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BMIcalCalculateButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Resetbutton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ExitButton, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.99274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.65891F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.73802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.73802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.45083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BMItableLayoutPanel_Paint);
            // 
            // MYweightlabel
            // 
            this.MYweightlabel.BackColor = System.Drawing.Color.SeaGreen;
            this.MYweightlabel.Location = new System.Drawing.Point(3, 40);
            this.MYweightlabel.Name = "MYweightlabel";
            this.MYweightlabel.Size = new System.Drawing.Size(149, 41);
            this.MYweightlabel.TabIndex = 0;
            this.MYweightlabel.Text = " My Weight";
            // 
            // MYheightlabel
            // 
            this.MYheightlabel.AutoEllipsis = true;
            this.MYheightlabel.BackColor = System.Drawing.Color.SeaGreen;
            this.MYheightlabel.Location = new System.Drawing.Point(3, 86);
            this.MYheightlabel.Name = "MYheightlabel";
            this.MYheightlabel.Size = new System.Drawing.Size(149, 41);
            this.MYheightlabel.TabIndex = 0;
            this.MYheightlabel.Text = " My Height";
            this.MYheightlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // EnterWeighttextbox
            // 
            this.EnterWeighttextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnterWeighttextbox.Location = new System.Drawing.Point(162, 43);
            this.EnterWeighttextbox.MaxLength = 3;
            this.EnterWeighttextbox.Name = "EnterWeighttextbox";
            this.EnterWeighttextbox.Size = new System.Drawing.Size(125, 38);
            this.EnterWeighttextbox.TabIndex = 1;
            this.EnterWeighttextbox.TextChanged += new System.EventHandler(this.EnterWeighttextbox_TextChanged);
            // 
            // Enterheighttextbox
            // 
            this.Enterheighttextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enterheighttextbox.Location = new System.Drawing.Point(162, 89);
            this.Enterheighttextbox.MaxLength = 3;
            this.Enterheighttextbox.Name = "Enterheighttextbox";
            this.Enterheighttextbox.Size = new System.Drawing.Size(125, 38);
            this.Enterheighttextbox.TabIndex = 1;
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
            // BMIResultLabel
            // 
            this.BMIResultLabel.AutoEllipsis = true;
            this.BMIResultLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.BMIResultLabel.Location = new System.Drawing.Point(3, 174);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(149, 39);
            this.BMIResultLabel.TabIndex = 0;
            this.BMIResultLabel.Text = " My BMI";
            // 
            // MetricradioButton
            // 
            this.MetricradioButton.AutoSize = true;
            this.MetricradioButton.Location = new System.Drawing.Point(162, 134);
            this.MetricradioButton.Name = "MetricradioButton";
            this.MetricradioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricradioButton.TabIndex = 5;
            this.MetricradioButton.TabStop = true;
            this.MetricradioButton.Text = "Metric";
            this.MetricradioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 134);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 6;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResulttextBox.Location = new System.Drawing.Point(162, 177);
            this.ResulttextBox.MaxLength = 3;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(125, 38);
            this.ResulttextBox.TabIndex = 1;
            // 
            // BMIcalCalculateButton
            // 
            this.BMIcalCalculateButton.AutoSize = true;
            this.BMIcalCalculateButton.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.SetColumnSpan(this.BMIcalCalculateButton, 2);
            this.BMIcalCalculateButton.Location = new System.Drawing.Point(3, 222);
            this.BMIcalCalculateButton.Name = "BMIcalCalculateButton";
            this.BMIcalCalculateButton.Size = new System.Drawing.Size(275, 37);
            this.BMIcalCalculateButton.TabIndex = 3;
            this.BMIcalCalculateButton.Text = "Calculate BMI";
            this.BMIcalCalculateButton.UseVisualStyleBackColor = false;
            this.BMIcalCalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.Maroon;
            this.Resetbutton.Location = new System.Drawing.Point(3, 265);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(128, 45);
            this.Resetbutton.TabIndex = 3;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // BMIResulttextBox
            // 
            this.BMIResulttextBox.BackColor = System.Drawing.Color.DimGray;
            this.BMIResulttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResulttextBox.Location = new System.Drawing.Point(15, 319);
            this.BMIResulttextBox.Multiline = true;
            this.BMIResulttextBox.Name = "BMIResulttextBox";
            this.BMIResulttextBox.ReadOnly = true;
            this.BMIResulttextBox.Size = new System.Drawing.Size(270, 110);
            this.BMIResulttextBox.TabIndex = 1;
            this.BMIResulttextBox.Text = "Underweight:  18.5 below\r\nNormal:            18.5 to 24.9\r\noverweight:      25 to" +
    " 29.9\r\nObese:               30 above\r\n";
            this.BMIResulttextBox.TextChanged += new System.EventHandler(this.BMIResulttextBox_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Maroon;
            this.ExitButton.Location = new System.Drawing.Point(162, 265);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(116, 45);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
        private System.Windows.Forms.Label MYweightlabel;
        private System.Windows.Forms.Label MYheightlabel;
        private System.Windows.Forms.TextBox EnterWeighttextbox;
        private System.Windows.Forms.TextBox Enterheighttextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.Button BMIcalCalculateButton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.TextBox BMIResulttextBox;
        private bool KgradioButton;
        private System.Windows.Forms.RadioButton MetricradioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

