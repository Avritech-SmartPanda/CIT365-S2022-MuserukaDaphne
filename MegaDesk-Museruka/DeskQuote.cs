using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Museruka
{
    public class DeskQuote
    {
        //Desk, rush days, customer name, and quote date. This class will also hold the logic in determining the desk quote total.
        public string CustomerName { get; set; }
        public int RushDays { get; set; }
        public double QuoteTotal { get; set; }
        public Desk Desk { get; set; }
        public DateTime QuoteDate { get; set; }

        // Constructor of class
        public DeskQuote()
        {
            CustomerName = this.CustomerName;
            RushDays = this.RushDays;
            QuoteDate = this.QuoteDate;
            Desk = this.Desk;
            QuoteTotal = 0;
        }

        public double CalculateDeskQuoteTotal()
        {

            double QuoteTotal = 0;
            double DeskDrawersPrice = 0;
            double DeskBasePrice = 200;
            double DeskRushOrderPrice = 0;
            double DeskArea = Desk.Width * Desk.Depth;

            if (Desk.NumberOfDrawers > 0)
            {
                DeskDrawersPrice = Desk.NumberOfDrawers * 50;
            }
            if (DeskArea > 1000)
            {
                DeskBasePrice = 200 + DeskArea;
            }
            

            switch (RushDays)
            {
                case 3:
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

                case 5:
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

                case 7:
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


            switch (Desk.SurfaceMaterial)
            {
                case Desk.Material.Laminate:
                    QuoteTotal = DeskBasePrice + DeskRushOrderPrice + DeskDrawersPrice + 100;                   
                    break;

                case Desk.Material.Oak:
                    QuoteTotal = DeskBasePrice + DeskRushOrderPrice + DeskDrawersPrice + 200;                   
                    break;

                case Desk.Material.Rosewood:
                    QuoteTotal = DeskBasePrice + DeskRushOrderPrice + DeskDrawersPrice + 300;
                    break;

                case Desk.Material.Veneer:
                    QuoteTotal = DeskBasePrice + DeskRushOrderPrice + DeskDrawersPrice + 125;
                    break;

                case Desk.Material.Pine:
                    QuoteTotal = DeskBasePrice + DeskRushOrderPrice + DeskDrawersPrice + 50;
                    break;

                default:
                    QuoteTotal = DeskBasePrice;
                    break;
            }
            return QuoteTotal;
        }
    }
}
