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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            List<string> materialsList = new List<string> { "Laminate", "Oak", "Rosewood", "Veneer", "Pine"};
            searchComboBox.DataSource = materialsList;


            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Customer Name";
            dataGridView1.Columns[1].Name = "Date of Quote";
            dataGridView1.Columns[2].Name = "Desk Width";
            dataGridView1.Columns[3].Name = "Desk Depth";
            dataGridView1.Columns[4].Name = "Desk Material";
            dataGridView1.Columns[5].Name = "Desk Drawers";
            dataGridView1.Columns[6].Name = "Rush Order Number";
            dataGridView1.Columns[7].Name = "Total Quote Price";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string path = @"C:\Data\1 - BYUI\7 - CIT 365\Megadesk2.0\MegaDesk-TeamBountiful\quotes.json";
                 

            // Open the file to read from.
            string[] readQuote = File.ReadAllLines(path);
            foreach (string quote in readQuote)
            {
                // Convert json string object to an object
                DeskQuote Quote = JsonConvert.DeserializeObject<DeskQuote>(quote);

                if(searchComboBox.Text == Quote.Desk.SurfaceMaterial.ToString()) {
                    string[] quoteFound = new string[] {
                    Quote.CustomerName,
                    Quote.QuoteDate.ToString("dd MMMM yyyy"),
                    Quote.Desk.Width.ToString(),
                    Quote.Desk.Depth.ToString(),
                    Quote.Desk.SurfaceMaterial.ToString(),
                    Quote.Desk.NumberOfDrawers.ToString(),
                    Quote.RushDays.ToString(),
                    Quote.QuoteTotal.ToString()
                   };
                    dataGridView1.Rows.Add(quoteFound);
                }
            }
        }
    }
}
