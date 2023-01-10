using newwww;

namespace FirstApp
{
    public class Program
    {
        public static void Main()
        {
            string[] strings = { "", "", "" };
            List<string> list = new List<string>();

            List<InfotechPeople> infotechPersons = new List<InfotechPeople>();
            infotechPersons.Add(new InfotechPeople() { Id = 0, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age =30 });
            infotechPersons.Add(new InfotechPeople() { Id = 1, TC = "12345678912", Ad = "Melih", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 2, TC = "12345678912", Ad = "Ece", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 3, TC = "12345678912", Ad = "Kübra", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 4, TC = "12345678912", Ad = "Süleyman", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 5, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 6, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 7, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 8, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 9, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 10, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age = 30 });
            infotechPersons.Add(new InfotechPeople() { Id = 11, TC = "12345678912", Ad = "Kamil", Soyad = "Kaplan", Age = 30 });

            for (int i = 0; i < infotechPersons.Count; i++)
            {
                Console.WriteLine($"Id : {infotechPersons[i].Id + 1}\nTc : {infotechPersons[i].TC}\nAd : {infotechPersons[i].Ad}\n");
            }

            /* Id     : 1
             * Tc     : 12345678912
             * Adı    : Kamil
             * Soyadı : Kaplan
             * Age    : 30
             * 
             * Id     : 2
             * Tc     : 98765412365
             * Adı    : Melih
             * Soyadı : Kaplan
             * Age    : 24
             */
        }
    }
}