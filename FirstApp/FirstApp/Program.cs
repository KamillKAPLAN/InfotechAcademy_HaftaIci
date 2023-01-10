using newwww;

namespace FirstApp
{
    public class Program
    {
        public static void Main()
        {
            string strValue = "Infotech";
            int intValue = 15;
            string result = string.Empty;

            Console.WriteLine("Merhaba Sınıf");

            Console.WriteLine("String Value : " + strValue + " İntValue : " + intValue);
            Console.WriteLine($"String Value : {strValue} İntValue : {intValue}");
            Console.WriteLine("String Value : {0} İntValue : {1}", strValue, intValue);

            Console.WriteLine(result);

            InfoTech.yazdir();

            /* Ürün Adı : Elma
             * Ürün Adı : Karpuz
             * Ürün Adı : Vişne
             */
        }
    }
}