using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentBMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void BMItableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(EnterWeighttextbox.Text);
            double height = Convert.ToDouble(Enterheighttextbox.Text);
            double result = 0.0;
            if (ImperialRadioButton.Checked)
            {
                result = (weight * 703) / (height * height);

            }
            else if (MetricradioButton.Checked)
            {
                result = weight / (height * height);
            }

            ResulttextBox.Text = "BMI:" + result.ToString("#.#");

        }

        

        
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            EnterWeighttextbox.Text = "";
            Enterheighttextbox.Text = "";
            ResulttextBox.Text = "";

            ImperialRadioButton.Checked = false;
            MetricradioButton.Checked = false;


        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EnterWeighttextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMIResulttextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
