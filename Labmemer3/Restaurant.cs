using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labmemer3
{
    public class Restaurant
    {
        private static Random random = new Random();

        public RestaurantName Name { get; set; }
        public RestaurantType Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }
        public List<Dish> Menu { get; set; }

        public static List<string> Streets = new List<string>
        {
            "вул. Хрещатик",
            "вул. Басейна",
            "вул. Інститутська",
            "вул. Крещатик",
            "вул. Льва Толстого",
            "вул. Грушевського",
            "вул. Велика Васильківська",
            "вул. Саксаганського",
            "вул. Шевченка",
            "вул. Липська"
        };

        public Restaurant()
        {
            Name = GetRandomRestaurantName();
            Type = GetRandomRestaurantType();
            Address = GetRandomAddress();
            City = "Київ";
            Rating = GetRandomRating();
            Menu = new List<Dish>();
        }

        private RestaurantName GetRandomRestaurantName()
        {
            var values = Enum.GetValues(typeof(RestaurantName));
            return (RestaurantName)random.Next((int)values.GetValue(0), (int)values.GetValue(values.Length - 1) + 1);
        }

        private RestaurantType GetRandomRestaurantType()
        {
            var values = Enum.GetValues(typeof(RestaurantType));
            return (RestaurantType)random.Next((int)values.GetValue(0), (int)values.GetValue(values.Length - 1) + 1);
        }

        private string GetRandomAddress()
        {
            int houseNumber = random.Next(1, 151);
            string street = Streets[random.Next(0, Streets.Count)];
            return $"{houseNumber} {street}";
        }

        private int GetRandomRating()
        {
            return random.Next(1, 6);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва: {Name}, Тип: {Type}, Місто: {City}, Адреса: {Address}, Рейтинг: {Rating}");
        }
    }

    public enum RestaurantName
    {
        Puzata_hata = 1,
        Chornomorka = 2,
        BurgerKing = 3,
        GastroFamily = 4,
        Starbucks = 5,
        PizzaHut = 6,
        Dominos = 7,
        Sushiya = 8
    }
   
    public enum RestaurantType
    {
        FineDining = 1, CasualDining = 2, FastCasual = 3, FastFood = 4, CafeBistro = 5,
        EthnicInternational = 6, Buffet = 7, FoodTrucks = 8, VegetarianVegan = 9, FamilyStyle = 10
    }

}