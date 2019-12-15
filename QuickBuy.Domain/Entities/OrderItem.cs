namespace QuickBuy.Domain.Entities
{
    class OrderItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public override void Validate()
        {
            ClearMessages();
            if (ProductId == 0)
                AddCritical("Product reference not identified");
            if (Amount == 0)
                AddCritical("Amount not informed");
        }
    }
}
