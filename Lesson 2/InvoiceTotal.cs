using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class InvoiceTotalForm : Form
    {
        public InvoiceTotalForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Calculate button event handle
        /// it does some cool things
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //This gonna do all that math and stuf
            const double Discount = 0.1;
            double SubTotal;
            double DiscountAmount;
            double Total;

            try
            {
                SubTotal = Convert.ToDouble(textBoxSubTotal.Text);
                DiscountAmount = SubTotal * Discount;
                Total = SubTotal - DiscountAmount;

                textBoxDiscountAmount.Text = DiscountAmount.ToString("C2");
                textBoxTotal.Text = Total.ToString("C2");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Put in a number, dude", "input error");
                Debug.WriteLine(exception.Message);
                textBoxSubTotal.Focus();
                textBoxSubTotal.SelectAll();
            }

        }
    }
}
