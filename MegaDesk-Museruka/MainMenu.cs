using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Museruka
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }   

        private void newQuote_Click(object sender, EventArgs e)
        {
            AddQuote quoteForm = new AddQuote();
            quoteForm.Tag = this;
            quoteForm.Show(this);
            this.Hide();
        }
        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotesForm = new ViewAllQuotes();
            viewQuotesForm.Tag = this;
            viewQuotesForm.Show(this);
            this.Hide();
        }

        private void mainPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
