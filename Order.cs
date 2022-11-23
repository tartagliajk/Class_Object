using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_och_objekt
{
    internal class Order
    {
        public string product;
        public int id;
        public int quantity;
        public int unitPrice;
        public int totalPrice;

        public Order(string product, int id, int quantity, int unitPrice, int totalPrice)
        {
            this.product = product;
            this.id = id;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.totalPrice = totalPrice;
        }
    }
}
