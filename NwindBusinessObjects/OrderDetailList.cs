namespace NwindBusinessObjects {
    public class OrderDetailList : DataListJoin<OrderDetail> {
        public OrderDetailList() : base() { }

        public override void Add(OrderDetail orderDetail) {
            if (orderDetail.Quantity > 25) {
                orderDetail.UnitPrice *= 0.9m;
                orderDetail.Discount = 0.9f;
            }

            base.Add(orderDetail);
        }
    }
}
