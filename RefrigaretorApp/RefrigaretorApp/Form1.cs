using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigaretorApp
{
    public partial class RefrigeratorUI : Form
    {
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        Refrigaretor aRefrigerator = new Refrigaretor();
        private void saveButton_Click(object sender, EventArgs e)
        {

            SaveWeight();
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            
            aRefrigerator.Item = Convert.ToInt32(itemTextBox.Text);
            aRefrigerator.ItemWeight = Convert.ToInt32(weightTextBox.Text);

            int totalUnit = aRefrigerator.Item * aRefrigerator.ItemWeight;

            int maxWeight = SaveWeight();



            int remainWeight = maxWeight - totalUnit;
            currentWeightlabel.Text = Convert.ToString(totalUnit);

            remainWeightlabel.Text = Convert.ToString(remainWeight);
            
            if(totalUnit > maxWeight)
                {
                    MessageBox.Show("Your given amount can’t be entered because it will be over flown.");
                }
            
        }
        public int SaveWeight()
        {
            aRefrigerator.MaxWeight = Convert.ToInt32(inputsaveTextBox.Text);
            return aRefrigerator.MaxWeight;
        }
    }
}
