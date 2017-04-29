namespace PizzaResturant.Model
{
    public class Dessert : Food
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public Dessert()
        {
            FoodType = FoodType.Dessert;
        }

        public Dessert(Size size)
        {
            FoodType = FoodType.Beverage;
            Prices = GetPrices(size);
            Size = size.ToString();
        }

        private decimal GetPrices(Size size)
        {
            if (size == Model.Size.Large)
            {
                return 4;
            }
            else if (size == Model.Size.Meduim)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }
    }
}
