using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        private Form _MainMenu;
        public AddQuote(Form MainMenu)
        {
            InitializeComponent();
            _MainMenu = MainMenu;
        }

        private void AddNewQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }

        private void AddNewQuote_Load(object sender, EventArgs e)
        {

        }

        private void GetQuoteButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
