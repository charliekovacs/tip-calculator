using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeTrackbar();
            InitializePeople();
            getUpdate();
            billErrorLabel.Visible = false;
            peopleUpDown.Minimum = 1;
        }

        private void InitializeTrackbar()
        {
            tipTrackBar.Minimum       = 0;
            tipTrackBar.Maximum       = 100;
            tipTrackBar.TickFrequency = 1;
            tipTrackBar.Value         = 15;
        }

        private void InitializePeople()
        {
            peopleUpDown.Value = 1;
        }

        private void billTextBox_TextChanged(object sender, EventArgs e)
        {
            billErrorLabel.Visible = false;
            getUpdate();
        }

        private void tipTrackBar_ValueChanged(object sender, EventArgs e)
        {
            tipTrackBarLabel.Text = tipTrackBar.Value.ToString() + "%";
            getUpdate();
        }

        private void peopleUpDown_ValueChanged(object sender, EventArgs e)
        {
            getUpdate();
        }

        private void getUpdate()
        {
            double billInput = 0;
            
            //validate billTextBox            
            try
            {
                if (billTextBox.Text != "")
                    billInput = Convert.ToDouble(billTextBox.Text);
            }
            catch
            {
                billErrorLabel.Visible = true;
                billTextBox.Focus();
                billTextBox.SelectAll();
            }
            
            //get form input values
            double tipInput = tipTrackBar.Value; //no validation needed
            int peopleInput = Convert.ToInt32(peopleUpDown.Value); //this control self-validates

            //calculate & display tip per person
            double tip = (billInput * (tipInput / 100)) / peopleInput;
            tipLabel.Text = tip.ToString("C");
            
            //calculate & display total per person
            double total = (billInput + (billInput * (tipInput / 100))) / peopleInput;         
            totalLabel.Text = total.ToString("C");
        }



    }
}
