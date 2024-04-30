﻿using System.ComponentModel.DataAnnotations;

namespace EShopAdminLab.Models
{
    public class Ticket
    {
       
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Rating { get; set; }
        public virtual EShopApplicationUser? CreatedBy { get; set; }
        public virtual ICollection<TicketInShoppingCart>? ProductsInShoppingCart { get; set; }

        public ICollection<TicketInOrder>? ProductInOrders { get; set; }
    }
}
