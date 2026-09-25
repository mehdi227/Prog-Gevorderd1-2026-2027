using WinkelkarProject.Model;

namespace Winkelkar {
    internal class Program {
        static void Main(string[] args) {
            VoedingsProduct product1 = new("Big Mac Deluxe Meal", 100, Nutriscore.A);
            double prijsMetKorting1 = product1.GeefPrijsMetKorting();
            Console.WriteLine($"De prijs van {product1.Omschrijving} zonder korting is {product1.GeefPrijsZonderKorting()}");
            Console.WriteLine($"De prijs van {product1.Omschrijving} met korting is {prijsMetKorting1}");

            VoedingsProduct product2 = new("Appel", 100, Nutriscore.B);
            double prijsMetKorting2 = product2.GeefPrijsMetKorting();
            Console.WriteLine($"De prijs van {product2.Omschrijving} zonder korting is {product2.GeefPrijsZonderKorting()}");
            Console.WriteLine($"De prijs van {product2.Omschrijving} met korting is {prijsMetKorting2}");

            VoedingsProduct product3 = new("Peer", 100, Nutriscore.C);
            double prijsMetKorting3 = product3.GeefPrijsMetKorting();
            Console.WriteLine($"De prijs van {product3.Omschrijving} zonder korting is {product3.GeefPrijsZonderKorting()}");
            Console.WriteLine($"De prijs van {product3.Omschrijving} met korting is {prijsMetKorting3}");

            VoedingsProduct product4 = new("Oreo", 100, Nutriscore.D);
            double prijsMetKorting4= product4.GeefPrijsMetKorting();
            Console.WriteLine($"De prijs van {product4.Omschrijving} zonder korting is {product4.GeefPrijsZonderKorting()}");
            Console.WriteLine($"De prijs van {product4.Omschrijving} met korting is {prijsMetKorting4}");

            VoedingsProduct product5 = new("Pizza", 100, Nutriscore.E);
            double prijsMetKorting5 = product5.GeefPrijsMetKorting();
            Console.WriteLine($"De prijs van {product5.Omschrijving} zonder korting is {product5.GeefPrijsZonderKorting()}");
            Console.WriteLine($"De prijs van {product5.Omschrijving} met korting is {prijsMetKorting5}");
        }
    }
}
