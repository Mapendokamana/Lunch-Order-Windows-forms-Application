using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LunchOrderApplication

    
{
    public partial class LunchOrder : Form
    {
        private object pictureBox;

        public LunchOrder()
        {
            InitializeComponent();
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Burger;

            //Displays label in the checkbox - Text Change
            grpBox3.Text = "Add-on items($0.75/each)";
            chkBox1.Text = "Lettuce, tomato, and onions";
            chkBox2.Text = "Ketch-up, Mustard, and Mayo";
            chkBox3.Text = "French Fries";
            chkBox4.Text = "Sweet Potatoes";
            

            //Remove the Chkbox
            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            chkBox4.Checked = false;
            chkBox5.Checked = false;

            //clears the SubTotal,Tax and Order Total
            txtTotal.Clear();
            txtTax.Clear();
            txtSubTotal.Clear();


        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Pizza;


            //Labels for Chkbox
            grpBox3.Text = "Add-on items($0.50/each)";
            chkBox1.Text = "Pepperoni";
            chkBox2.Text = "Sausage";
            chkBox3.Text = "Olives";
            chkBox4.Text = "Extra Sauce";
            chkBox5.Text = "Chilli";

            //Removes the checkbox
            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            chkBox4.Checked = false;
            chkBox5.Checked = false;

            //Clears the subtotal, Tax and Ordr Total
            txtSubTotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();

        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Salad;

            //Labels for ChkBox
            grpBox3.Text = "Add-on items($0.25/each)";
            chkBox1.Text = "Croutons";
            chkBox2.Text = "Bacon bits";
            chkBox3.Text = "Bread sticks";
            chkBox4.Text = "Shredded Chicken";
            chkBox5.Text = "Extra Mayonnaise";

            //Removes the chkBox
            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            chkBox4.Checked = false;
            chkBox5.Checked = false;

            //Clears the Subtotal, Tax and Total
            txtSubTotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset text boxes
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            // Reset check boxes
            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            chkBox4.Checked = false;
            chkBox5.Checked = false;

            // Reset radio buttons
            rdoHamburger.Checked = false;
            rdoPizza.Checked = false;
            rdoSalad.Checked = false;


            //Reset Picture box
            pictureBox1.Image = null;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Calculating each Add-On items in the grpBox2
            decimal add = 0m;
            if (chkBox1.Checked)
            {
                add++;
            }
            if (chkBox2.Checked)
            {
                add++;
            }

            if (chkBox3.Checked)
            {
                add++;
            }

            if (chkBox4.Checked)
            {
                add++;
            }
            if (chkBox5.Checked)
            {
                add++;
            }

            if (rdoHamburger.Checked)
            {
                decimal Hamburger =
                    Convert.ToDecimal(rdoHamburger.Checked);
                Hamburger = 6.95m;
                // Calculate the subtotal
                decimal BoxSubTotal = Hamburger + (add * 0.75m);

                // Calculate the tax @5%
                decimal BoxTax = BoxSubTotal * 0.05m;

                // Calculate the total cost of order (Tax Inclusive)
                decimal BoxTotal = BoxTax + BoxSubTotal;

                // Display the results in the output TextBox
                txtSubTotal.Text = BoxSubTotal.ToString("C");
                txtTax.Text = BoxTax.ToString("C");
                txtTotal.Text = BoxTotal.ToString("C");

            }

            else if (rdoPizza.Checked)
            {
                decimal Pizza =
                    Convert.ToDecimal(rdoPizza.Checked);
                Pizza = 5.95m;
                // Calculate the subtotal
                decimal BoxSubTotal = Pizza + (add * 0.50m);

                // Calculate the tax @5%
                decimal BoxTax = BoxSubTotal * 0.05m;

                // Calculate the total cost of order (Tax Inclusive)
                decimal BoxTotal = BoxTax + BoxSubTotal;

                // Display the results in the output TextBox
                txtSubTotal.Text = BoxSubTotal.ToString("C");
                txtTax.Text = BoxTax.ToString("C");
                txtTotal.Text = BoxTotal.ToString("C");
            }
            else if (rdoSalad.Checked)
            {
                decimal Salad =
                    Convert.ToDecimal(rdoSalad.Checked);
                Salad = 4.95m;
                // Calculate the subtotal
                decimal BoxSubTotal = Salad + (add * 0.25m);

                // Calculate the tax @5%
                decimal BoxTax = BoxSubTotal * 0.05m;

                // Calculate the total cost of order (Tax Inclusive)
                decimal BoxTotal = BoxTax + BoxSubTotal;

                // Display the results in the output TextBox
                txtSubTotal.Text = BoxSubTotal.ToString("C");
                txtTax.Text = BoxTax.ToString("C");
                txtTotal.Text = BoxTotal.ToString("C");

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //configuring the Exit button
            string message = "Thank you for your order!\n Would you like visit us again?";
            DialogResult button = MessageBox.Show(message, "Hello",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //exiting the app for non-returning customers
            if (button == DialogResult.No) 
            {
                this.Close();
            }
            if (button == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
