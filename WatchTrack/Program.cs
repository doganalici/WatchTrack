using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t FİLM TAKİP UYGULAMASI");
            Console.WriteLine("\t-----------------------");
            List<MediaItem> films = new List<MediaItem>()
            {
                new MediaItem{Id=1,Name="There Will Be Blood (Kan Dökülecek)",Type="Dram, Trajedi",Year="2007",Director="Paul Thomas Anderson",IsWatched=false},

                new MediaItem{Id=2,Name="Hutter Island (Zindan Adası)",Type="Gizem, Dram",Year="2010",Director="Martin Scorsese",IsWatched=false},

                new MediaItem{Id=3,Name="1917",Type="Tarihi Drama, Savaş, Aksiyon",Year="2019",Director="Sam Mendes",IsWatched=false},

                new MediaItem{Id=4,Name="Intouchables (Can Dostum)",Type="Gerçek Hikaye, Komedi, Drama",Year="2011",Director="Olivier Nakache, Éric Toledano",IsWatched=false},

            };

            bool state = true;
            while (state)
            {
                Console.WriteLine("Menüden 1-7 arasında bir  tuşlama yapınız");
                Console.Write("Seçiminiz : ");
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                }

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("YENİ FİLM EKLEME");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("FİLM SİLME");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("TÜM FİLMLERİ LİSTELEME");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("FİLM ARAMA");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("FİLMİ İZLENDİ OLARAK İŞARETLEME");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("FİLMİ İZLENMEDİ OLARAK İŞARETLEME");
                        break;
                    case 7:
                        Console.Write("Çıkış yapılıyor. Lütfen bir tuşa basınız");
                        state = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Menü dışındaki bir rakam tuşlaması yaptınız. Lütfen tekrar deneyin!!!\n");
                        break;
                }
            }
        }
    }
}
