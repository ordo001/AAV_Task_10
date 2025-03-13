using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAV_Task_10.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int TypeItemId { get; set; }
        public TypeItem? TypeItem { get; set; }
        public DateTime? DateCreate { get; set; }
        public int OwnerItemId { get; set; }
        public User? OwnerItem { get; set; }
        public double EstimatedPrice { get; set; }

        

    }
}
