using System;
using System.Collections.Generic;

namespace RestaurantOtomasyon.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public int RestaurantTableId { get; set; }
        public RestaurantTable RestaurantTable { get; set; } = null!;

        public int? UserId { get; set; }
        public User? User { get; set; }

        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsCompleted { get; set; } = false;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
