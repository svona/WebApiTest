namespace WebApiTest.Models
{
    using System;
    using System.Collections.Generic;
    public class Order
    {
        public Order()
        {
            Order_Details = new List<OrderDetail>();
        }
        public int OrderID { get; set; }

        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderDetail> Order_Details { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
