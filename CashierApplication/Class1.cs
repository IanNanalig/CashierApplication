namespace ItemNamespace
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual double CalcuTotal()
        {
            return Price * Quantity;
        }
    }

    public class DiscountedItem : Item
    {
        public double Discount { get; set; }

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            Discount = discount;
        }

        public override double CalcuTotal()
        {
            double discountDecimal = Discount * 0.01;
            double discountAmount = Price * discountDecimal;
            double discountedPrice = Price - discountAmount;
            return discountedPrice * Quantity;
        }
    }
}
