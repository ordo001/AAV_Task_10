using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAV_Task_10.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public DateTime StartSale { get; set; }
        public double StartPrice { get; set; }
        public double EndPrice { get; set; }
        public bool isSold { get; set; } = false;
        public int BuyerId { get; set; }
        public User? Buyer { get; set; }
    }
}
