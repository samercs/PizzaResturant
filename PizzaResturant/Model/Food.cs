namespace PizzaResturant.Model
{
    public class Food
    {
        public decimal Prices { get; set; }
        public FoodType FoodType { get; set; }
    }

    public enum FoodType
    {
        Pizza,
        Beverage,
        Dessert
    }

    public enum Size
    {
        Large = 3,
        Meduim = 2,
        Small = 1
    }
}
