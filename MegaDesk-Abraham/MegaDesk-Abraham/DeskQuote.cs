using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Abraham
{
    class DeskQuote
    {
        public decimal area;
        public decimal oversizeCost { get; set; }
        public decimal drawerCost;
        public decimal materialCost;
        public decimal shippingCost;
        public decimal totalPrice;
        public const decimal BASE_PRICE = 200.00M;
        public const decimal DRAWER_RATE = 50.00M;
        public Desk desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        public decimal CalcOversizeCost(decimal width, decimal depth)
        {
            Desk desk = new Desk();
            area = width * depth;
            if (area > 1000)
            {
                oversizeCost = Convert.ToDecimal( area - 1000) ;
                desk.OversizeCost = oversizeCost;
                return desk.OversizeCost;
            }
            else
            {
                oversizeCost = 0.00M;
                return oversizeCost;
            }
        }

        public decimal CalcDrawerCost( int count)
        {
            Desk desk = new Desk();
            drawerCost = count * DRAWER_RATE;
            desk.DrawerCost = drawerCost;
            return desk.DrawerCost;
        }

        public decimal CalcMaterialCost(int index)
        {
           
            switch (index)
            {
                case 1:
                    materialCost = 200.00M;
                    return materialCost;
                case 2:
                    materialCost = 100.00M;
                    return materialCost;
                case 3:
                    materialCost = 50.00M;
                    return materialCost;
                case 4:
                    materialCost = 300.00M;
                    return materialCost;
                case 5:
                    materialCost = 125.00M;
                    return materialCost;
                default:
                    materialCost = 0.00M;
                    return materialCost;
            }

        }

        public decimal CalcShipping(int index)
        {
            Desk desk = new Desk();
            int width = desk.Width;
            int depth = desk.Depth;
            area = width * depth;
            if (index == 0)
            {
                shippingCost = 0;
                return shippingCost;
            }
            else if (index == 1)
            {
                if(area < 1000)
                {
                    shippingCost = 60;
                    return shippingCost;
                }
                else if (area > 1000 && area < 2000)
                {
                    shippingCost = 70;
                    return shippingCost;
                }
                else
                {
                    shippingCost = 80;
                    return shippingCost;
                }
            }
            else if( index == 2)
            {
                if (area < 1000)
                {
                    shippingCost = 40;
                    return shippingCost;
                }
                else if (area > 1000 && area < 2000)
                {
                    shippingCost = 50;
                    return shippingCost;
                }
                else
                {
                    shippingCost = 60;
                    return shippingCost;
                }
            }
            else if(index == 3)
            {
                if (area < 1000)
                {
                    shippingCost = 30;
                    return shippingCost;
                }
                else if (area > 1000 && area < 2000)
                {
                    shippingCost = 35;
                    return shippingCost;
                }
                else
                {
                    shippingCost = 40;
                    return shippingCost;
                }
            } else
            {
                shippingCost = 0;
                return shippingCost;
            }
        }


        public decimal GetTotalPrice()
        {
            Desk desk = new Desk();
            totalPrice = BASE_PRICE;
            //totalPrice = desk.Depth;
            totalPrice += desk.OversizeCost;
            //totalPrice += CalcDrawerCost();
            //totalPrice += materialCost;
            //totalPrice += shippingCost;
            desk.TotalPrice = totalPrice;
            return desk.TotalPrice;
        }

        public string ShowDate()
        {
            String date = DateTime.Now.ToString("dd MMMM yyyy");
            return date;
        }
    }
}
