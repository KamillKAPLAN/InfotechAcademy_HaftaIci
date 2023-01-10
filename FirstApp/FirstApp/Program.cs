using newwww;

namespace FirstApp
{
    public class Program
    {
        public static void Main()
        {
            string adi = "Afife";
            string soyadi = "Çimen";
            int yas = 23;
            double kilo = 24.2;

            Console.WriteLine("Adı : {0}\nSoyadı :  {1} {2} {3}", adi,soyadi,yas, kilo);
            Console.Write("Adı : " + adi + "Soyadı : " + soyadi + "Yaş : " + yas + "Kilo : " + kilo);
            Console.WriteLine($"Adı : {adi} Soyadı : {soyadi} Yaş : {yas} Kilo : {kilo}");

            /* Ürün Adı : Elma
             * Ürün Adı : Karpuz
             * Ürün Adı : Vişne
             */
        }
    }
}