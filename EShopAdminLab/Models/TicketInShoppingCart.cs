﻿using System.ComponentModel.DataAnnotations;

namespace EShopAdminLab.Models
{
    public class TicketInShoppingCart
    {
  
        public Guid TicketId { get; set; }
        public Ticket? Ticket { get; set; }
        public Guid ShoppingCartId { get; set; }

        public int Quantity { get; set; }
      
    }
}
