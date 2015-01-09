using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeOfResult
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Average average = new Average();

            average.Physics =Convert.ToDouble(phyTextBox.Text);
            average.Chemistry = Convert.ToDouble(cheTextBox.Text);
            average.Math = Convert.ToDouble(mathTextBox.Text);

            
            double avg=average.GetAvg();
            avgTextBox.Text = avg.ToString();

            if (avg >= 80)
            {
                grdTextBox.Text = "A+";
            }
            else if (avg >= 70)
            {
                grdTextBox.Text = "B+";
            }
            if (avg >= 60)
            {
                grdTextBox.Text = "C+";
            }
            if (avg >= 50)
            {
                grdTextBox.Text = "D+";
            }
            if (avg < 50)
            {
                grdTextBox.Text = "F";
            }

        }
    }
}
