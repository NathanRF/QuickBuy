﻿using QuickBuy.Domain.Valueables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Order : Entity//Pedido
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CompleteAddress { get; set; }
        public int AddressNumber { get; set; }

        public int PaymentOptionId { get; set; } = 0;
        public virtual PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// An order must have at least one OrderItem
        /// or many OrderItems
        /// </summary>
        public virtual ICollection<OrderItem> OrderItens { get; set; }

        public override void Validate()
        {
            ClearMessages();
            if (!OrderItens.Any())
                AddCritical("Order cannot be without order items");
            if (string.IsNullOrEmpty(ZipCode))
                AddCritical("Zip Code must be informed");
            if (PaymentOptionId == 0)
                AddCritical("Payment option not informed");
        }
    }
}
