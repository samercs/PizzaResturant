namespace PizzaResturant.Model
{
    public class Food
    {
        public int FoodId { get; set; }
        public decimal Prices { get; set; }
        public FoodType FoodType { get; set; }
    }

    public enum FoodType
    {
        Pizza,
        Beverage,
        Dessert
    }
}
