namespace PizzaResturant.Model
{
    public class Order
    {
        public Person Person { get; set; }
        public Address Address { get; set; }
        public Pizza Pizza { get; set; }
        public Dessert Dessert { get; set; }
        public Beverage Beverage { get; set; }

        public decimal GetTotal()
        {
            return Pizza.Prices + Dessert.Prices + Beverage.Prices;
        }
    }
}
