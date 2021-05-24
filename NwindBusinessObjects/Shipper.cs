using System;

namespace NwindBusinessObjects {
    using Schema;

    [Table("Shippers", "ShipperID")]
    public class Shipper : Item {

        private int shipperID;  // null-able:	NO
        private string companyName;   // null-able:	NO
        private string phone;	// null-able:	YES

        public Shipper(int shipperID) : base() {
            this.shipperID = shipperID;
        }

        public Shipper() : base() { }

        public int ShipperID {
            get {
                return this.shipperID;
            }

            set {
                this.shipperID = value;
            }
        }

        public string CompanyName {
            get {
                return this.companyName;
            }

            set {
                this.companyName = value;
            }
        }

        public string Phone {
            get {
                return this.phone;
            }

            set {
                this.phone = value;
            }
        }

        public override object GetId() => this.shipperID;
        public override void SetId(object id) => this.ShipperID = (int) id;
    }
}
