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
                Console.Clear();
                return;
            }

            _films.Add(film);
            Console.WriteLine("> Film başarıyla eklendi!");
        }

        public void ListAll()
        {
            if (_films.Count == 0)
            {
                Console.WriteLine("X Listede film bulunmuyor");
                return;
            }
            foreach (var film in _films)
            {
                film.DisplayInfo();
            }
        }

        public void Search(string keyword)
        {
            var result = _films.Where(f => f.Name.ToLower().Contains(keyword.ToLower())).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("X Aradığınız kriterde film/filmler bulunamadı.");
                return;
            }
            foreach (var film in result)
            {
                film.DisplayInfo();
            }
        }

        public void SearchYear(string year)
        {
            var result = _films.Where(f => f.Year == year).ToList();
            if (result.Count == 0)
            {
                Console.WriteLine("X Aradığınız kriterde film/filmler bulunamadı.");
                return;
            }
            foreach (var film in result)
            {
                film.DisplayInfo();
            }
        }

        public void SearchType(string type)
        {
            var result = _films.Where(f => f.Type.ToLower().Contains(type.ToLower())).ToList();
            if (result.Count == 0)
            {
                Console.WriteLine("X Aradığınız kriterde film/filmler bulunamadı.");
                return;
            }
            foreach (var film in result)
            {
                film.DisplayInfo();
            }
        }

        public void SearchDirector(string director)
        {
            var result = _films.Where(f => f.Director.ToLower().Contains(director.ToLower())).ToList();
            if (result.Count == 0)
            {
                Console.WriteLine("X Aradığınız kriterde film/filmler bulunamadı.");
                return;
            }
            foreach (var film in result)
            {
                film.DisplayInfo();
            }
        }
        public void Delete(int id)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);

            if (film == null)
            {
                Console.WriteLine("X Silmek istedğiniz film listede bulunamadı.");
                return;
            }


            _films.Remove(film);
            Console.WriteLine($"> {film.Name} isimli film başarıyla silindi!");
        }

        public void MarkWatched(int id, bool isWatched)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);

            if (film == null)
            {
                Console.WriteLine("X Film listede bulunamadı.");
                return;
            }
            if (film.IsWatched == isWatched)
            {
                Console.WriteLine(
                    $"X {film.Name} filmi zaten \"{(isWatched ? "İzlendi" : "İzlenmedi")}\" durumunda!"
                );
                return;
            }

            film.IsWatched = isWatched;
            Console.WriteLine($"> {film.Name} filmi \"{(isWatched ? "İzlendi" : "İzlenmedi")}\" olarak işaretlendi.");
        }
    }
}
