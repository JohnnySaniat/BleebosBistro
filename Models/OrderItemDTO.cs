﻿namespace BleebosBistro.Models
{
    public class OrderItemDTO
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }

        public int Quantity { get; set; }
    }
}
