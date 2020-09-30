using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Abraham
{
    public partial class AddQuote : Form
    {
        string baseCharge = "200";
        
        public AddQuote()
        {
            InitializeComponent();
            // Show today's date
            currentDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            baseChargePrice.Text = baseCharge;
        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
            Close();
        }

        // Display customer's name in summary box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerName.Text = customerNameBox.Text;
        }

        // Check if customer's name is empty or null
        public void validateCustomer(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                errorLabel.Text = "Please enter you name";
                customerNameBox.BackColor = Color.Tomato;
                customerNameBox.Text = "";
                this.ActiveControl = customerNameBox;
            }
            else
            {
                errorLabel.Text = "";
            }
        }

        private void customerNameBox_Validating(object sender, CancelEventArgs e)
        {
            customerNameBox.BackColor = default(Color);
            string value = customerNameBox.Text;
            validateCustomer(value);
        }

        /* -----------------------------------------------------*/

        // Validating width of the desktop
        public void validateWidth(string input)
        {
            Desk desk = new Desk();
            int minWidth = desk.minWidth;
            int maxWidth = desk.maxWidth;
            bool newInput = input.All(char.IsDigit);
            if (newInput != true || String.IsNullOrEmpty(input))
            {
                errorLabel.Text ="Please enter a valid number using numeric button!";
                widthBox.BackColor = Color.Tomato;
                widthBox.Text = "";
                this.ActiveControl = widthBox;
            }
            else
            {
                errorLabel.Text = "";
            }
            int parseValue;
            if (Int32.TryParse(widthBox.Text, out parseValue))
            {

                if (parseValue < minWidth || parseValue > maxWidth)
                {
                    errorLabel.Text = "Width size has to be between 24 and 96!";
                    widthBox.BackColor = Color.Tomato;
                    widthBox.Text = "";
                    this.ActiveControl = widthBox;
                }
                else
                {
                    errorLabel.Text = "";
                }
            }
 
        }

        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            widthBox.BackColor = default(Color);
            string value = widthBox.Text;
            validateWidth(value);
        }


        /* -----------------------------------------------------*/
        // Validate depth with KeyPress event
        private void depthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false || char.IsControl(e.KeyChar))
            {
                errorLabel.Text = "Please enter a valid number using numeric button!";
                depthBox.BackColor = Color.Tomato;
                depthBox.Text = "";
                this.ActiveControl = depthBox;
            }
            else
            {
                errorLabel.Text = "";
            }
        }

        // Validate depth value
        public void validateDepth(string input)
        {
            Desk desk = new Desk();
            int minDepth = desk.minDepth;
            int maxDepth = desk.maxDepth;
            bool newInput = input.All(char.IsDigit);
            if (newInput != true || String.IsNullOrEmpty(input))
            {
                errorLabel.Text = "Please enter a valid number using numeric button!";
                depthBox.BackColor = Color.Tomato;
                depthBox.Text = "";
                this.ActiveControl = depthBox;
            }
            else
            {
                errorLabel.Text = "";
            }
            int parseValue;
            if (Int32.TryParse(depthBox.Text, out parseValue))
            {

                if (parseValue < minDepth || parseValue > maxDepth)
                {
                    errorLabel.Text = "Width size has to be between 12 and 48!";
                    depthBox.BackColor = Color.Tomato;
                    depthBox.Text = "";
                    this.ActiveControl = depthBox;
                }
                else
                {
                    errorLabel.Text = "";
                }
            }
        }

        private void depthBox_Validating(object sender, CancelEventArgs e)
        {
            depthBox.BackColor = default(Color);
            string value = depthBox.Text;
            validateDepth(value);
        }

        /* -----------------------------------------------------*/

        // Validate drawers
        public void validateDrawer(string input)
        {
            bool newInput = input.All(char.IsDigit);
            if (newInput != true)
            {
                errorLabel.Text = "Please enter a valid number using numeric button or choose one from dropdown menu!";
                drawerBox.BackColor = Color.Tomato;
                drawerBox.Text = "";
                this.ActiveControl = drawerBox;
            }
            else
            {
                errorLabel.Text = "";
            }
            int parseValue;
            if (Int32.TryParse(drawerBox.Text, out parseValue))
            {

                if (parseValue < 0 || parseValue > 7)
                {
                    errorLabel.Text = "Drawer has to be between 0 and 7!";
                    drawerBox.BackColor = Color.Tomato;
                    drawerBox.Text = "";
                    this.ActiveControl = drawerBox;
                }
                else
                {
                    errorLabel.Text = "";
                }
            }
        }

        private void drawerBox_Validating(object sender, CancelEventArgs e)
        {
            drawerBox.BackColor = default(Color);
            string value = drawerBox.Text;
            validateDrawer(value);
        }
        /* -----------------------------------------------------*/

        // Validate material
        public void validateMaterial(string input)
        {
            if (materialBox.SelectedIndex < 0 || materialBox.SelectedIndex > 5 || materialBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Please select one of the options below";
                materialBox.SelectedIndex = 0;
                materialBox.BackColor = Color.Tomato;
                this.ActiveControl = materialBox;
            }
            else
            {
                materialBox.BackColor = default(Color);
                errorLabel.Text = "";
            }
        }
        private void materialBox_Validating(object sender, CancelEventArgs e)
        {
            materialBox.BackColor = default(Color);
            string value = materialBox.Text;
            validateMaterial(value);
        }

        /* -----------------------------------------------------*/
        // Validate shipping

        public void validateShipping(string input)
        {
            if (shippingBox.SelectedIndex < 0 || shippingBox.SelectedIndex > 3 || shippingBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Please select one of the options below";
                shippingBox.SelectedIndex = 0;
                shippingBox.BackColor = Color.Tomato;
                this.ActiveControl = shippingBox;
            }
            else
            {
                shippingBox.BackColor = default(Color);
                errorLabel.Text = "";
            }
        }

        private void shippingBox_Validating(object sender, CancelEventArgs e)
        {
            shippingBox.BackColor = default(Color);
            string value = shippingBox.Text;
            validateShipping(value);
        }

        // Add default index value to material text box to show command to select
        private void AddQuote_Load(object sender, EventArgs e)
        {
            materialBox.SelectedIndex = 0;
            //shippingBox.SelectedIndex = 0;
        }


    }
}
