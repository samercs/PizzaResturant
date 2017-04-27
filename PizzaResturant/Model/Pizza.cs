namespace PizzaResturant.Model
{
    public class Pizza : Food
    {
        public string Size { get; set; }
        public string Thickness { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public bool ExtraCheese { get; set; }

        public Pizza()
        {
            FoodType = FoodType.Pizza;
        }

        public Pizza(Size size)
        {
            FoodType = FoodType.Pizza;
            Prices = GetPrices(size);
            Size = size.ToString();
        }

        private decimal GetPrices(Size size)
        {
            if (size == Model.Size.Large)
            {
                return 5;
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
