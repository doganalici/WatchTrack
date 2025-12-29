using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTrack
{
    public class MediaManager
    {
        private List<MediaItem> _films = new List<MediaItem>();
        public void Add(MediaItem film)
        {
            if (_films.Any(f => f.Id == film.Id))
            {
                Console.WriteLine($"X {film.Id} numaralı film zaten kayıtlı!");
                Console.WriteLine("Devam etmek için bir tuşa basınız...");
                Console.ReadKey();
                return;
            }

            _films.Add(film);
            Console.WriteLine("> Film başarıyla eklendi!");
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
