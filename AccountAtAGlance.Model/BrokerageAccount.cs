using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAtAGlance.Model
{
    //Track all the data about a given account for a customer
    public class BrokerageAccount
    {
        public BrokerageAccount()
        {
            Positions = new HashSet<Position>();
            Orders = new HashSet<Order>();
        }

        // Primitive Properties
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("[A-Z][0-9]*")]
        public string AccountNumber { get; set; }
        [StringLength(100)]
        public string AccountTile { get; set; }
        public decimal MarginBalance { get; set; }
        public bool IsRetirement { get; set; }
        public int CustomerId { get; set; }
        public decimal CashTotal { get; set; }
        public decimal PositionsTotal { get; set; }
        public int WishListId { get; set; }

        // Navigation Properties
        public ICollection<Position> Positions { get; set; }
        public ICollection<Order> Orders { get; set; }
        public WatchList WatchList { get; set; }
    }
}
