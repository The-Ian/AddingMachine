using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayWork
{
    public partial class Form1 : Form
    {
        double[] numberArray = new double[400];
        int i = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberEntryTB.Text != "")
                {
                    numberLB.Items.Add("+" + numberEntryTB.Text);
                    numberArray[i] = double.Parse(numberEntryTB.Text);
                    total = total + double.Parse(numberEntryTB.Text);
                    totalLabel.Text = total.ToString();
                    numberEntryTB.Clear();
                    numberEntryTB.Focus();
                }
                else
                {
                    MessageBox.Show("Enter a Valid Operation");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberEntryTB.Text != "")
                {
                    numberLB.Items.Add("-" + numberEntryTB.Text);
                    numberArray[i] = double.Parse(numberEntryTB.Text);
                    total = total - double.Parse(numberEntryTB.Text);
                    totalLabel.Text = total.ToString();
                    numberEntryTB.Clear();
                    numberEntryTB.Focus();
                }
                else
                {
                    MessageBox.Show("Enter a Valid Operation");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberEntryTB.Text != "")
                {
                    numberLB.Items.Add("*" + numberEntryTB.Text);
                    numberArray[i] = double.Parse(numberEntryTB.Text);
                    total = total * double.Parse(numberEntryTB.Text);
                    totalLabel.Text = total.ToString();
                    numberEntryTB.Clear();
                    numberEntryTB.Focus();
                }
                else
                {
                    MessageBox.Show("Enter a Valid Operation");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberEntryTB.Text != "")
                {
                    numberLB.Items.Add("/" + numberEntryTB.Text);
                    numberArray[i] = double.Parse(numberEntryTB.Text);
                    total = total / double.Parse(numberEntryTB.Text);
                    totalLabel.Text = total.ToString();
                    numberEntryTB.Clear();
                    numberEntryTB.Focus();
                }
                else
                {
                    MessageBox.Show("Enter a Valid Operation");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void numberEntryTB_Validating(object sender, CancelEventArgs e)
        {
            double numValue = 0;

            try
            {
               
                if (numberEntryTB.Text.Length > 0 && !double.TryParse(numberEntryTB.Text, out numValue))
                {
                    e.Cancel = true;
                    MessageBox.Show("This only allows numbers.");
                    numberEntryTB.Clear();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }



        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                total = 0;
                totalLabel.Text = 0.ToString();
                numberLB.Items.Clear();
                numberEntryTB.Clear();
                numberEntryTB.Focus();
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
