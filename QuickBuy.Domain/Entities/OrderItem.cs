namespace QuickBuy.Domain.Entities
{
    class OrderItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
