using WinkelkarProject.Model;

namespace Winkelkar {
    internal class Program {
        static void Main(string[] args) {
            VoedingsProduct product1 = new("Big Mac Deluxe Meal", 100, Nutriscore.A);
            double prijsMetKorting = product1.GeefPrijsMetKorting();
            Console.WriteLine($"De prijs zonder korting is {product1.GeefPrijsZonderKorting()}");
            Console.WriteLine($"De prijs met korting is {prijsMetKorting}");

            VoedingsProduct product2 = new("Appel", 100, Nutriscore.A);
            Console.WriteLine($"De prijs zonder korting is {product2.GeefPrijsZonderKorting()}");
            Console.WriteLine($"De prijs met korting is {product2.GeefPrijsMetKorting()}");
        }
    }
}
