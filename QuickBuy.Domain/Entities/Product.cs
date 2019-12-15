namespace QuickBuy.Domain.Entities
{
    class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            ClearMessages();
            if (Price <= 0)
                AddCritical("Price cannot be lower than 1");
        }
    }
}
