using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesInventory.Shared
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string ClientName { get; set; } = string.Empty;
        public double? ProductPrice { get; set; }
        public double? CashReceived { get; set; }
        public double? CashBack { get; set; }
        public int Transfer { get; set; } = 0;
    }
}
