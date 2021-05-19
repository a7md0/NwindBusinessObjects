namespace NwindBusinessObjects {
    public class OrderDetailList : DataListJoin<OrderDetail> {
        public OrderDetailList() : base() { }

        public override bool Add(OrderDetail orderDetail) {
            if (orderDetail.Quantity > 25) {
                orderDetail.UnitPrice *= 0.9m;
                orderDetail.Discount = 0.9f;
            }

            return base.Add(orderDetail);
        }
    }
}
