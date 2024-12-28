using System.Collections;

namespace restourant
{
    using System;
    using System.Collections;

    class Program
    {
        static void Main()
        {
            SortedList corbalar = new SortedList()
        {
            {"Mercimek", 40 },
            {"Yayla", 45 },
            {"Ezogelin", 54.5 },
            {"Kelle Paça", 60 },
            {"Tarator", 50 },
        };

            SortedList pilavlar = new SortedList()
        {
            {"Pirinç Pilavı", 30 },
            {"Bulgur Pilavı", 35 },
            {"Keşkek", 40 },
            {"Nohutlu Pilav", 38 },
            {"Sebzeli Pilav", 45 },
        };

            SortedList salatalar = new SortedList()
        {
            {"Çoban Salata", 25 },
            {"Mevsim Salata", 28 },
            {"Fettucini Salata", 35 },
            {"Kısır", 22 },
            {"Patates Salatası", 20 },
        };

            SortedList mesrubatlar = new SortedList()
        {
            {"Kola", 15 },
            {"Fanta", 15 },
            {"Ayran", 12 },
            {"Su", 8 },
            {"Limonata", 18 },
        };

            SortedList tatlılar = new SortedList()
        {
            {"Künefe", 45 },
            {"Dilim Baklava", 20 },
            {"Katmer", 40 },
            {"Tiramisu", 38 },
            {"Kazandibi", 30 },
        };

            int[] masa = new int[5];  
            string[] masaDurum = new string[5];  
            Array.Fill(masaDurum, "Boş");

            Console.WriteLine("******** RESTAURANT OTOMASYONU *********");
            while (true)
            {
                Console.WriteLine("Kaç müşteri var?");
                int gelen_musteri = Convert.ToInt32(Console.ReadLine());

                if (gelen_musteri <= 0)
                {
                    Console.WriteLine("Geçersiz müşteri sayısı.");
                    continue;
                }

               
                bool masayaYerleştirildi = false;
                for (int i = 0; i < 5; i++)
                {
                    if (masaDurum[i] == "Boş")
                    {
                        masaDurum[i] = "Dolu";
                        Console.WriteLine($"Müşteriler masa {i + 1}'e yerleştirildi.");
                        masayaYerleştirildi = true;
                        break;
                    }
                }

                if (!masayaYerleştirildi)
                {
                    Console.WriteLine("Bütün masalar dolu, yeni bir masa açılana kadar bekleyin.");
                    continue;
                }

                for (int i = 0; i < gelen_musteri; i++)
                {
                    bool devam = true;
                    while (devam)
                    {
                        Console.WriteLine($"Müşteri {i + 1}, Ne Arzu Edersiniz?");
                        ShowMenu(corbalar, "Çorbalar");
                        ShowMenu(pilavlar, "Pilavlar");
                        ShowMenu(salatalar, "Salatalar");
                        ShowMenu(mesrubatlar, "Meşrubatlar");
                        ShowMenu(tatlılar, "Tatlılar");

                        
                        string siparis = Console.ReadLine();
                        Console.WriteLine($"{siparis} siparişiniz alınmıştır.");

                        Console.WriteLine("Başka bir arzunuz var mı? (Evet/Hayır)");
                        string cevap = Console.ReadLine().ToLower();
                        if (cevap == "hayır")
                        {
                            devam = false;
                        }
                    }
                }

                Console.WriteLine("\nYeni müşteri var mı? (Evet/Hayır)");
                string yeniMusteri = Console.ReadLine().ToLower();

                if (yeniMusteri == "hayır")
                {
                    Console.WriteLine("\nHesap alınıyor...");
                    break;  
                }
            }
        }

        static void ShowMenu(SortedList menu, string kategori)
        {
            Console.WriteLine($"*** {kategori} ***");
            foreach (DictionaryEntry item in menu)
            {
                Console.WriteLine($"{item.Key}: {item.Value} TL");
            }
        }
    }

}
