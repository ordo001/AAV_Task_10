using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAV_Task_10.Models
{
    public class TypeItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public override string ToString()
        {
            return Name;
        }
    }
}
