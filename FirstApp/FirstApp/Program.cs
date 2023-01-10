using newwww;

namespace FirstApp
{
    public class Program
    {
        public static void Main()
        {
            string[] meyveler = { "Elma", "Karpuz", "Vişne", "Kivi" };
            for (int i = 0; i < meyveler.Length; i++)
                Console.WriteLine($"{i+1}. Ürün Adı : " + meyveler[i]);

            Console.WriteLine("--------------");

            foreach (var item in meyveler)
                Console.WriteLine("Ürün Adı : " + item);

            Console.WriteLine("--------------");

            List<string> listMeyveler = new List<string>();
            listMeyveler.Add("Vişne");
            listMeyveler.Add("Elma");
            listMeyveler.Add("Kivi");
            listMeyveler.Add("Karpuz");
            foreach (var item in listMeyveler)
                Console.WriteLine("List Meyve Ürün Adı : " + item);

            Console.WriteLine("--------------");


            /* Ürün Adı : Elma
             * Ürün Adı : Karpuz
             * Ürün Adı : Vişne
             */
        }

    }
}