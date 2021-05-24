using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwindBusinessObjects {
    public class OrderList : DataList<Order> {
        public OrderList() : base() { }

        public override bool Add(Order order) {
            if (order.ShipCountry == "USA" || order.ShipCountry == "Mexico") {
                order.Freight *= 1.1m;
            }

            if (!order.RequiredDate.HasValue) {
                order.RequiredDate = order.OrderDate.Value.AddDays(4 * 7);
            }

            return base.Add(order);
        }
    }
}
