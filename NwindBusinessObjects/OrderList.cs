using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwindBusinessObjects {
    public class OrderList : DataList<Order> {
        public OrderList() : base() { }

        public override void Add(Order order) {
            if (order.ShipCountry == "USA" || order.ShipCountry == "Mexico") {
                order.Freight *= 1.1m;
            }

            base.Add(order);
        }
    }
}
