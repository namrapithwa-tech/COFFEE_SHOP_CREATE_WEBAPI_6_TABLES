using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_Create_WebAPI_6_Tables.Models
{
    public class OrderDetailsModel
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public int UserID { get; set; }
    }
}
