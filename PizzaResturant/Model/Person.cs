namespace PizzaResturant.Model
{

    public class Person
    {
        public string Title { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }

        public virtual PaymentInfo PaymentInfo { get; set; }



    }
}
