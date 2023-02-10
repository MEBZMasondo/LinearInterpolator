using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpolator
{
    public partial class FormInt : Form
    {
        public FormInt()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                // calc
                double varx1Double = Double.Parse(varx1TextBox.Text);
                double varx2Double = Double.Parse(varx2TextBox.Text);
                double varx3Double = Double.Parse(varx3TextBox.Text);

                double vary1Double = Double.Parse(vary1TextBox.Text);
                //double vary2Double = Double.Parse(vary2TextBox.Text);
                double vary3Double = Double.Parse(vary3TextBox.Text);

                // RESULT FOR y2
                double AnsDouble = -(((vary3Double - vary1Double) * (varx3Double - varx2Double) / (varx3Double - varx1Double)) - vary3Double);
                // RESULT FOR x2
                //AnsDouble = -(((vary3Double - vary2Double) * (varx3Double - varx1Double) / (vary3Double - vary1Double)) - varx3Double)
                vary2TextBox.Text = AnsDouble.ToString();

                String histString = "x1 = " + varx1Double   + "\ty1 = "   + vary1Double + 
                                    "\tx2 = " + varx2Double   + "\ty2 = [ "   + AnsDouble +  " ]" +
                                    "\tx3 = " + varx3Double   + "\ty3 = "   + vary3Double ; 
                historyListBox.Items.Add( histString);
                clearEntries();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearEntries();
        }

        public void clearEntries()
        {
            // clear
            varx1TextBox.Clear();
            varx2TextBox.Clear();
            varx3TextBox.Clear();

            vary1TextBox.Clear();
            vary2TextBox.Clear();
            vary3TextBox.Clear();

            varx1TextBox.Focus();
        }
    }
}
