namespace PizzaResturant.Model
{
    public class Beverage : Food
    {
        public int BeverageId { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public bool Cold { get; set; }
        public bool Diet { get; set; }

        public Beverage()
        {
            FoodType = FoodType.Beverage;
        }

        public Beverage(Size size)
        {
            FoodType = FoodType.Beverage;
            Prices = GetPrices(size);
            Size = size.ToString();
        }

        private decimal GetPrices(Size size)
        {
            if (size == Model.Size.Large)
            {
                return 3;
            }
            else if (size == Model.Size.Meduim)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
