using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_06156158
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countbt_Click(object sender, EventArgs e)
        {
            double bmi=countbmi();
            String alert = "";
            
            if (bmi<18.5)
            {
                pictureBox.Image=HW_06156158.Properties.Resources.bmi_level_01;
                alert = "(過輕)";
            }
            else if (bmi < 24)
            {
                pictureBox.Image = HW_06156158.Properties.Resources.bmi_level_02;
                alert = "(正常)";
            }
            else if (bmi < 27)
            {
                pictureBox.Image = HW_06156158.Properties.Resources.bmi_level_03;
                alert = "(過重)";
            }
            else if (bmi < 30)
            {
                pictureBox.Image = HW_06156158.Properties.Resources.bmi_level_04;
                alert = "(肥胖)";
            }
            else 
            {
                pictureBox.Image = HW_06156158.Properties.Resources.bmi_level_05;
                alert = "(太胖拉)";
            }
            showbmilab.Text = (Convert.ToString(bmi))+alert;
            showbmilab.Visible = true;

        }
        double countbmi()
        {
            double Height = Convert.ToDouble(talltextbox.Text);
            double Weight = Convert.ToDouble(weighttextbox.Text);
            if (cmradio.Checked)
            {
                Height /= 100;
            }
            double bmi = Weight / Math.Pow(Height,2);
            bmi = Convert.ToInt32(bmi * 100)/100;
            return bmi;
        }
    }
}
