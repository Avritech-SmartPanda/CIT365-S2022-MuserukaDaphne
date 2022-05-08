using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_Museruka.Desk;

namespace MegaDesk_Museruka
{
 
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void widthInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(widthInput.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MinWidth || WidthInput > Desk.MaxWidth)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MinWidth + " to " + Desk.MaxWidth + " inches");
                    //widthInput.Text = String.Empty;
                    widthInput.BackColor = Color.OrangeRed;
                    widthInput.Focus();
                }
            }
            else if (int.TryParse(widthInput.Text, out WidthInput) == false && widthInput.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                //widthInput.Text = String.Empty;
                widthInput.BackColor = Color.OrangeRed;
                widthInput.Focus();
            }
        }


        private void depthInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(depthInput.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MinDepth || DepthInput > Desk.MaxDepth)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MinDepth + " to " + Desk.MaxDepth + " inches");
                    //depthInput.Text = String.Empty;
                    depthInput.BackColor = Color.DarkOrange;
                    depthInput.Focus();
                }
            }
            else if (int.TryParse(depthInput.Text, out DepthInput) == false && depthInput.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                //depthInput.Text = String.Empty;
                depthInput.BackColor = Color.DarkOrange;
                depthInput.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = comboBox1.GetItemText(comboBox1.SelectedIndex);
            Global.selectedMaterial = text;
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            string material = Global.selectedMaterial;
            string RushOrder = "N/A";
            double Width = Convert.ToDouble(widthInput.Text);
            double Depth = Convert.ToDouble(depthInput.Text);
            double NumberOfDrawers = Convert.ToDouble(numericUpDown1.Text);
            double DeskDrawersPrice = 0;
            double DeskBasePrice = 200;
            double DeskRushOrderPrice = 0;
            double DeskArea = Width * Depth;


            //radioButton2

         
            if (NumberOfDrawers > 0)
            {
                DeskDrawersPrice = NumberOfDrawers * 50;
            }
           
            if(radioButton1.Checked == true)
            {
                RushOrder = "N/A";
            }
            else if (radioButton2.Checked == true)
            {
                RushOrder = "3 Days";
            } else if (radioButton3.Checked == true)
            {
                RushOrder = "5 Days";
            }
            else if (radioButton4.Checked == true)
            {
                RushOrder = "7 Days";
            }
           


            switch (RushOrder)
            {

                case "3 Days":
                    if (DeskArea < 1000)
                    {
                        DeskRushOrderPrice = 60;
                    }
                    if (DeskArea >= 1000 && DeskArea <= 2000)
                    {
                        DeskRushOrderPrice = 70;
                    }
                    if (DeskArea > 2000)
                    {
                        DeskRushOrderPrice = 80;
                    }
                    break;

                case "5 Days":
                    if (DeskArea < 1000)
                    {
                        DeskRushOrderPrice = 40;
                    }
                    if (DeskArea >= 1000 && DeskArea <= 2000)
                    {
                        DeskRushOrderPrice = 50;
                    }
                    if (DeskArea > 2000)
                    {
                        DeskRushOrderPrice = 60;
                    }
                    break;

                case "7 Days":
                    if (DeskArea < 1000)
                    {
                        DeskRushOrderPrice = 30;
                    }
                    if (DeskArea >= 1000 && DeskArea <= 2000)
                    {
                        DeskRushOrderPrice = 35;
                    }
                    if (DeskArea > 2000)
                    {
                        DeskRushOrderPrice = 40;
                    }
                    break;


                default:
                    DeskRushOrderPrice = 0;
                    break;
            }


            switch (Convert.ToInt32(material))
            {
                 
                case 0:
                    totalQuote.Text = null;
                    Global.total = DeskArea + DeskRushOrderPrice + DeskDrawersPrice + 100;
                    totalQuote.Text = "Quote total = $" + Global.total.ToString() ;
                    break;

                case 1:
                    totalQuote.Text = null;
                    var total = DeskArea + DeskRushOrderPrice + DeskDrawersPrice + 200;
                    totalQuote.Text = "Quote total = $" + Global.total.ToString();
                    break;

                case 2:
                    totalQuote.Text = null;
                    Global.total = DeskArea + DeskRushOrderPrice + DeskDrawersPrice + 300;
                    totalQuote.Text = "Quote total = $" + Global.total.ToString();
                    break;

                case 3:
                    totalQuote.Text = null;
                    Global.total = DeskArea + DeskRushOrderPrice + DeskDrawersPrice + 125;
                    totalQuote.Text = "Quote total = $" + Global.total.ToString();
                    break;

                case 4:
                    totalQuote.Text = null;
                    Global.total = DeskArea + DeskRushOrderPrice + DeskDrawersPrice + 50;
                    totalQuote.Text = "Quote total = $" + Global.total.ToString();
                    break;

                default:
                    totalQuote.Text = null;
                    totalQuote.Text = "Quote total = $" + DeskBasePrice;
                    break;
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


    public  class Global
    {
        // global int
        public static string selectedMaterial;
        public static double total = 0.0;

    }
}
