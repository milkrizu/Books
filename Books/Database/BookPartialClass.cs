using Books.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Books.Database
{

    public partial class Book
    {
        public SolidColorBrush DiscountColor
        {
            get
            {
                if (Classes.DatabaseConnectionClass.DataBaseConnection.MaxDiscount.Where(c => c.MaxDiscountId == MaxDiscountId).First().Value >= 15)
                    return Brushes.Chartreuse;
                else return Brushes.Transparent;
            }


        }

        public string NewPrice
        {
            get
            {
                if (ActiveDiscountId != null)
                    return Convert.ToString(Price - (Price / 100 * DatabaseConnectionClass.DataBaseConnection.ActiveDiscount.Where(c => c.ActiveDiscountId == ActiveDiscountId).First().Value));
                return null;
            }
        }
    }


}       
        


   

       

   
