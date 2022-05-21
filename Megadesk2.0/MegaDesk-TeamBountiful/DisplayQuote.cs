using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_TeamBountiful
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
            fullname.Text = GeneralMembers.deskQuote.CustomerName;
            quotationDate.Text = GeneralMembers.deskQuote.QuoteDate.ToString("dd MMMM yyyy");
            widthValue.Text = GeneralMembers.deskQuote.Desk.Width.ToString() + " Inches";
            depthValue.Text = GeneralMembers.deskQuote.Desk.Depth.ToString() + " Inches";
            materialValue.Text = GeneralMembers.deskQuote.Desk.SurfaceMaterial.ToString();
            rushValue.Text = GeneralMembers.deskQuote.RushDays.ToString() + " Days";
            drawersValue.Text = GeneralMembers.deskQuote.Desk.NumberOfDrawers.ToString();
            total.Text = GeneralMembers.deskQuote.QuoteTotal.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = (MainMenu)Tag;
            mainForm.Show();
            Close();
        }
    }
}
