using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthwindApp
{
    public partial class Product
    {
        public Product() 
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int Quantity { get; set; }

       
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
