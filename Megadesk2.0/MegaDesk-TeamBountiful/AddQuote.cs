using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_TeamBountiful
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            List<string> materialsList = new List<string> { "Laminate", "Oak", "Rosewood", "Veneer", "Pine" };
            materialsInput.DataSource = materialsList;

            List<string> rushOrderList = new List<string> { "14 Days", "3 Days", "5 Days", "7 Days" };
            rushOrder.DataSource = rushOrderList;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = (MainMenu)Tag;
            mainForm.Show();
            Close();
        }

        private void widthInput_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (int.TryParse(widthInput.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MinWidth || WidthInput > Desk.MaxWidth)
                {
                    widthError.Text = "Please enter a width from " + Desk.MinWidth + " to " + Desk.MaxWidth + " inches";
                    widthInput.ForeColor = Color.Red;
                    widthInput.Focus();
                }
                else
                {
                    widthInput.ForeColor = Color.Green;
                    widthError.Text = null;
                }
            }
            else if (int.TryParse(widthInput.Text, out WidthInput) == false && widthInput.Text.Length != 0)
            {
                widthError.Text = "Please enter a number";
                widthInput.ForeColor = Color.Red;
                widthInput.Focus();
            }
            else
            {
                widthInput.ForeColor = Color.Green;
                widthError.Text = null;
            }

        }
        private void widthInput_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerName.Text))
            {
                nameError.Text = "Please enter customer name";
            }
            else
            {
                nameError.Text = null;
                customerName.ForeColor = Color.Green;
            }

        }


        private void depthInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(depthInput.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MinDepth || DepthInput > Desk.MaxDepth)
                {
                    depthError.Text = "Please enter a width from " + Desk.MinDepth + " to " + Desk.MaxDepth + " inches";
                    depthInput.ForeColor = Color.Red;
                    depthInput.Focus();
                }
                else
                {
                    depthInput.ForeColor = Color.Green;
                    depthError.Text = null;
                }
            }
            else if (int.TryParse(depthInput.Text, out DepthInput) == false && depthInput.Text.Length != 0)
            {
                depthError.Text = "Please enter a number";
                depthInput.ForeColor = Color.Red;
                depthInput.Focus();
            }
            else
            {
                depthError.Text = null;
                depthInput.ForeColor = Color.Green;
            }
        }


        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                depthError.Text = "Please enter a number";
                depthInput.ForeColor = Color.Red;
                depthInput.Focus();
            }
            else
            {
                depthError.Text = null;
                depthInput.ForeColor = Color.Green;
            }
        }

 

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.CustomerName = customerName.Text;
            deskQuote.QuoteDate = DateTime.Now;
            deskQuote.Desk = new Desk();
            deskQuote.Desk.Depth = Convert.ToDouble(depthInput.Text);
            deskQuote.Desk.Width = Convert.ToDouble(widthInput.Text);
            deskQuote.Desk.NumberOfDrawers = Convert.ToDouble(numericUpDown1.Text);
            deskQuote.Desk.SurfaceMaterial = (Desk.Material)Enum.Parse(typeof(Desk.Material), materialsInput.Text);


            switch (rushOrder.GetItemText(rushOrder.SelectedIndex))
            {
                case "3 Days":
                    deskQuote.RushDays = 3;
                    break;

                case "5 Days":
                    deskQuote.RushDays = 5;
                    break;

                case "7 Days":
                    deskQuote.RushDays = 7;
                    break;

                default:
                    deskQuote.RushDays = 14;
                    break;
            }

            deskQuote.QuoteTotal = deskQuote.CalculateDeskQuoteTotal();
            GeneralMembers.deskQuote = deskQuote;
            var jsonData = JsonConvert.SerializeObject(deskQuote);
            string path = @"C:\Data\1 - BYUI\7 - CIT 365\Megadesk2.0\MegaDesk-TeamBountiful\quotes.json";
            File.AppendAllText(path, jsonData + Environment.NewLine);
             
            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            this.Hide();
        }

               
        private void customerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (String.IsNullOrEmpty(customerName.Text))
            {
                nameError.Text = "Please enter customer name.";
            }
            else
            {
                nameError.Text = null;
                customerName.ForeColor = Color.Green;
            }
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerName.Text))
            {
                nameError.Text = "Please enter customer name.";
            }
            else
            {
                nameError.Text = null;
                customerName.ForeColor = Color.Green;
            }
        }       
    }
}
