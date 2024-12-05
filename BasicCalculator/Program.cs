namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            do
            {
                Hesapla();
            } while (SorDevamMi());
        }

        private static bool SorDevamMi()
        {
            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            return (Console.ReadLine().ToLower() == "e");
        }

        private static void Hesapla()
        {
            double sayi1;
            double sayi2;
            string islem;

            Bilgi(); // output

            Console.WriteLine("Lutfen birinci sayiyi giriniz : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lutfen islemi giriniz : ");
            islem = Console.ReadLine();


            Console.WriteLine("Lutfen ikinci sayiyi giriniz : ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            if (islem == "+")
            {
                Console.WriteLine("Sonuc = " + Toplam(sayi1, sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine("Sonuc = " + Fark(sayi1, sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("Sonuc = " + Carp(sayi1, sayi2));
            }
            else if (islem == "/")
            {
                Console.WriteLine("Sonuc = " + Bolme(sayi1, sayi2));
            }
            else
                Console.WriteLine("Hatali secim");

        }
        private static double Bolme(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }

        private static double Carp(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }

        private static double Fark(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }

        private static double Toplam(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        private static void Bilgi()
        {
            Console.WriteLine("Basit Bir Hesap Makinasi");
            Console.WriteLine("Islem [Topla (+) Fark (-) Carp (*) Bolme (/)]");
        }
    }
}


