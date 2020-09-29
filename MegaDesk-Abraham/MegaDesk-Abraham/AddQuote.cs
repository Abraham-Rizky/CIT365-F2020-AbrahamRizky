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
        public AddQuote()
        {
            InitializeComponent();
            // Show today's date
            currentDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
            Close();
        }




    }
}
