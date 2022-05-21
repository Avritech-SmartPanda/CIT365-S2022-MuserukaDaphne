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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            quotesTable.ColumnCount = 8;
            quotesTable.Columns[0].Name = "Customer Name";
            quotesTable.Columns[1].Name = "Date of Quote";
            quotesTable.Columns[2].Name = "Desk Width";
            quotesTable.Columns[3].Name = "Desk Depth";
            quotesTable.Columns[4].Name = "Desk Material";
            quotesTable.Columns[5].Name = "Desk Drawers";
            quotesTable.Columns[6].Name = "Rush Order Number";
            quotesTable.Columns[7].Name = "Total Quote Price";


            string path = @"C:\Data\1 - BYUI\7 - CIT 365\Megadesk2.0\MegaDesk-TeamBountiful\quotes.json";


            // Open the file to read from.
            string[] readQuote = File.ReadAllLines(path);
            foreach (string quote in readQuote)
            {
                // Convert json string object to an object
                DeskQuote Quote = JsonConvert.DeserializeObject<DeskQuote>(quote);

                string[] quoteRow = new string[] {
                    Quote.CustomerName,
                    Quote.QuoteDate.ToString("dd MMMM yyyy"),
                    Quote.Desk.Width.ToString(),
                    Quote.Desk.Depth.ToString(),
                    Quote.Desk.SurfaceMaterial.ToString(),
                    Quote.Desk.NumberOfDrawers.ToString(),
                    Quote.RushDays.ToString(),
                    Quote.QuoteTotal.ToString()
                   };
                quotesTable.Rows.Add(quoteRow);
            }
        }
    }
}
