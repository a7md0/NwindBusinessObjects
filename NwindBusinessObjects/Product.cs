using System;

namespace NwindBusinessObjects {
    using Schema;

    [Table("Products", "ProductID")]
    public class Product : Item {

        private int productID;  // null-able:	NO
        private string productName;   // null-able:	NO
        private int? supplierID; // null-able:	YES
        private int? categoryID; // null-able:	YES
        private string quantityPerUnit;   // null-able:	YES
        private decimal? unitPrice;    // null-able:	YES
        private short? unitsInStock;  // null-able:	YES
        private short? unitsOnOrder;  // null-able:	YES
        private short? reorderLevel;  // null-able:	YES
        private bool discontinued;  // null-able:	NO

        public Product(int productID) : base() {
            this.productID = productID;
        }

        public Product() : base() { }

        public int ProductID {
            get {
                return this.productID;
            }

            set {
                this.productID = value;
            }
        }

        public string ProductName {
            get {
                return this.productName;
            }

            set {
                this.productName = value;
            }
        }

        public int? SupplierID {
            get {
                return this.supplierID;
            }

            set {
                this.supplierID = value;
            }
        }

        public int? CategoryID {
            get {
                return this.categoryID;
            }

            set {
                this.categoryID = value;
            }
        }

        public string QuantityPerUnit {
            get {
                return this.quantityPerUnit;
            }

            set {
                this.quantityPerUnit = value;
            }
        }

        public decimal? UnitPrice {
            get {
                return this.unitPrice;
            }

            set {
                this.unitPrice = value;
            }
        }

        public short? UnitsInStock {
            get {
                return this.unitsInStock;
            }

            set {
                this.unitsInStock = value;
            }
        }

        public short? UnitsOnOrder {
            get {
                return this.unitsOnOrder;
            }

            set {
                this.unitsOnOrder = value;
            }
        }

        public short? ReorderLevel {
            get {
                return this.reorderLevel;
            }

            set {
                this.reorderLevel = value;
            }
        }

        public bool Discontinued {
            get {
                return this.discontinued;
            }

            set {
                this.discontinued = value;
            }
        }

        public override object GetId() => this.productID;
        public override void SetId(object id) => this.ProductID = (int) id;
    }
}
