using QuickBuy.Domain.Valueables;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    class Order //Pedido
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CompleteAddress { get; set; }
        public int AddressNumber { get; set; }

        public int PaymentOptionId { get; set; }
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// An order must have at least one OrderItem
        /// or many OrderItems
        /// </summary>
        public ICollection<OrderItem> OrderItens { get; set; }
    }
}
