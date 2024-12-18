using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_Create_WebAPI_6_Tables.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public string PaymentMode { get; set; }
        public decimal? TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderNumber { get; set; }
        public int UserID { get; set; }
    }
}