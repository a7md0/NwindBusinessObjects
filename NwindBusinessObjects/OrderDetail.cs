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

        public OrderDetail(int orderID, int productID) : base(orderID.ToString(), productID.ToString()) {
            this.orderID = orderID;
            this.productID = productID;
        }

        public OrderDetail() : base() { }

        public int OrderID {
            get {
                return this.orderID;
            }

            set {
                base.id = value.ToString();
                this.orderID = value;
            }
        }

        public int ProductID {
            get {
                return this.productID;
            }

            set {
                base.joinId = value.ToString();
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
    }
}
