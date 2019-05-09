using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuote frmAddQuote = new AddQuote(this);
            frmAddQuote.Show();
            Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {

        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {

        }
    }
}
