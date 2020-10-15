using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApiEF.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public virtual Order Orders { get; set; } = null;//default null to change the foreign key without changing primary key
        public int ProductId { get; set; }
        public virtual Product Products { get; set; } = null;

        public OrderLine()
        {

        }
    }
}
