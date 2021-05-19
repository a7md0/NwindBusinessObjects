using System;

namespace NwindBusinessObjects {
    using Schema;

    [Table("Order Details", "OrderID", "ProductID")]
    public class OrderDetail : ItemJoin {

        private int orderID;    // null-able:	NO
        private int productID;  // null-able:	NO
        private decimal unitPrice;    // null-able:	NO
        private short quantity;  // null-able:	NO
        private float discount;	// null-able:	NO

        public OrderDetail(int orderID, int productID) : base() {
            this.orderID = orderID;
            this.productID = productID;
        }

        public OrderDetail() : base() { }

        public int OrderID {
            get {
                return this.orderID;
            }

            set {
                this.orderID = value;
            }
        }

        public int ProductID {
            get {
                return this.productID;
            }

            set {
                this.productID = value;
            }
        }

        public decimal UnitPrice {
            get {
                return this.unitPrice;
            }

            set {
                this.unitPrice = value;
            }
        }

        public short Quantity {
            get {
                return this.quantity;
            }

            set {
                this.quantity = value;
            }
        }

        public float Discount {
            get {
                return this.discount;
            }

            set {
                this.discount = value;
            }
        }

        public override object GetId() => this.orderID;
        public override void SetId(object id) => this.OrderID = (int) id;

        public override object GetJoinId() => this.productID;
        public override void SetJoinId(object joinId) => this.ProductID = (int) joinId;
    }
}
