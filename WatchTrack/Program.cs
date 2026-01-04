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
            MediaManager mediaManager = new MediaManager();
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
                Console.WriteLine("Menüden 1-7 arasında bir  tuşlama yapınız\n");
                Console.WriteLine("1 - Film Ekleme\n" +
                    "2 - Film Silme\n" +
                    "3 - Tüm Filmleri Listeleme\n" +
                    "4 - Film Arama\n" +
                    "5 - Filmi İzlendi Olarak İşaretleme\n" +
                    "6 - Filmi İzlenmedi Olarak İşaretleme\n" +
                    "7 - Çıkış");
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
                        Console.WriteLine("----------------");
                        Console.Write("ID : ");
                        int id;
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                        }

                        Console.Write("Film Adı : ");
                        string name = Console.ReadLine();

                        Console.Write("Film Türü : ");
                        string type = Console.ReadLine();

                        Console.Write("Film Yılı : ");
                        string year = Console.ReadLine();

                        Console.Write("Film Yönetmeni : ");
                        string director = Console.ReadLine();

                        var newFilm = new MediaItem
                        {
                            Id = id,
                            Name = name,
                            Type = type,
                            Year = year,
                            Director = director,
                            IsWatched = false
                        };

                        mediaManager.Add(newFilm);
                        Console.WriteLine("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("FİLM SİLME");
                        Console.WriteLine("----------");
                        Console.Write("Silmek istediğiniz filmin ID numarasını yazınız : ");
                        int deleteId;
                        while (!int.TryParse(Console.ReadLine(), out deleteId))
                        {
                            Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                        }
                        mediaManager.Delete(deleteId);
                        Console.WriteLine("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("TÜM FİLMLERİ LİSTELEME");
                        Console.WriteLine("----------------------");
                        mediaManager.ListAll();
                        Console.WriteLine("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("FİLM ARAMA");
                        Console.WriteLine("----------");
                        Console.Write("Filmin adını yazınız : ");
                        string keyword = Console.ReadLine();
                        mediaManager.Search(keyword);
                        Console.WriteLine("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("FİLMİ İZLENDİ OLARAK İŞARETLEME");
                        Console.WriteLine("-------------------------------");
                        Console.Write("Film ID numarasını giriniz : ");
                        int watchId;
                        while (!int.TryParse(Console.ReadLine(), out watchId))
                        {
                            Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                        }
                        mediaManager.MarkWatched(watchId, true);
                        Console.WriteLine("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("FİLMİ İZLENMEDİ OLARAK İŞARETLEME");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Film ID numarasını giriniz : ");
                        int watchId2;
                        while (!int.TryParse(Console.ReadLine(), out watchId2))
                        {
                            Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                        }
                        mediaManager.MarkWatched(watchId2, false);
                        Console.WriteLine("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                        Console.Clear();
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
