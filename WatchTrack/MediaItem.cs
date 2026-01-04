using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTrack
{
    public class MediaItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public bool IsWatched { get; set; }

        public MediaItem(int id, string name, string type, string year, string director, bool isWatched)
        {
            Id = id;
            Name = name;
            Type = type;
            Year = year;
            Director = director;
            IsWatched = isWatched;
        }
        public MediaItem()
        {

        }
        public void DisplayInfo()
        {
            var status = IsWatched ? "İzlendi" : "İzlenmedi";
            Console.WriteLine($"FİLM;\n" +
                $"ID : {Id}\n" +
                $"Adı : {Name}\n" +
                $"Türü : {Type}\n" +
                $"Yılı : {Year}\n" +
                $"Yönetmeni : {Director}\n" +
                $"İzlendi Mi? : {status}");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        }

    }
}
