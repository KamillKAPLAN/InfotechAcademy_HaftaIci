﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newwww
{
    public class InfoTechOrnekler
    {
        public static void yazdir()
        {
            Console.WriteLine("Selam arkadaşlar nasılsınız");
        }

        void orn1()
        {
            /* 1-100 arasındaki çift sayıları  */
            for (int a = 1; a <= 100; a++)
            {
                if (a % 2 == 0)
                    Console.Write(a + ", ");
            }

            for (int i = 2; i <= 100; i += 2)
                Console.WriteLine(i);
        }

        void orn2()
        {
            /* 1-100 arasındaki çift sayıları 
             * 100 - 1 kadar olan sayıları listele
             * girilen sayının 1-100 arasında mı onu kontrol et
             */
            for (int j = 1; j <= 100; j++)
                Console.Write($"{j} ");

            Console.WriteLine("\n");

            for (int i = 100; i >= 1; i--)
                Console.Write(i + " ");

            Console.Write("\nDeğer Giriniz : ");
            int alinanDeger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dışarıdan alınan değer : {alinanDeger} {alinanDeger.GetType()}");
            for (int j = 1; j <= 100; j++)
            {
                if (j == alinanDeger)
                    Console.WriteLine($"{j} Değer AYNI");
                else
                    Console.WriteLine($"{j} Değer FARKLI");
            }
        }

        void orn3()
        {
            /* switch case */
            int s1 = 5, s2 = 6;
            Console.WriteLine("islemi gir");
            string islem = Console.ReadLine();

            if (islem == "+")
                Console.WriteLine(s1 + s2);
            else if (islem == "-")
                Console.WriteLine(s1 - s2);
            else if (islem == "*")
                Console.WriteLine(s1 * s2);
            else if (islem == "/")
                Console.WriteLine(s1 / s2);

            switch (islem)
            {
                case "+": Console.WriteLine(s1 + s2); break;
                case "-": Console.WriteLine(s1 - s2); break;
                case "*": Console.WriteLine(s1 * s2); break;
                case "/": Console.WriteLine(s1 / s2); break;
                default: Console.WriteLine("Geçersiz deger"); break;
            }
        }

        void orn4()
        {
            /* dışarıdan 2 tane sayı al, 1 tane dört işlem operatörü (+,-,*,/) al ve dört işlem yap */
            Console.Write("\nDeğer Giriniz : ");

            int time = 20;
            if (time < 18)
                Console.WriteLine("Good day.");
            else
                Console.WriteLine("Good evening.");

            /* (10>5) ? "büyük" : "küçük";
             * (5>10) ? 5 : 10
             */
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            int day = 0;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine(); break;
            }

            for (int j = 0; j < 5; j++)
                Console.WriteLine(j);

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (k > 5);
        }
    }
}
