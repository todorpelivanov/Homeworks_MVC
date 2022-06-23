namespace SEDC.PizzaApp.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string? NameOfOrder { get; set; }
        public int Price { get; set; }
        public int RecipientPhoneNumber { get; set; }
        public string RecipientName { get; set; }
        public string RecipientAdress { get; set; }
    }
}