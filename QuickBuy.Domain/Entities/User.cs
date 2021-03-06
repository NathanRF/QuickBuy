﻿using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            ClearMessages();
            if (string.IsNullOrEmpty(Email))
                AddCritical("Email not informed");
            if (string.IsNullOrEmpty(Password))
                AddCritical("Password not informed");
        }
    }
}
