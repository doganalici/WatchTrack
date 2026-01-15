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

        public bool ShowFilm(int id)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);
            if (film == null)
            {
                Console.WriteLine("X Film listede bulunamadı.");
                return false;
            }
            film.DisplayInfo();
            return true;
        }

        public void UpdateFilmName(int id, string newName)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);
            if (film == null)
            {
                Console.WriteLine("X Film listede bulunamadı.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("X Film adı boş olamaz.");
                return;
            }

            if (film.Name.Equals(newName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("X Yeni film adı eski adıyla aynı!");
                return;
            }
            film.Name = newName;
            Console.WriteLine("> Film adı başarıyla güncellendi");
            Console.WriteLine("--------------------------------\n");
            film.DisplayInfo();
        }

        public void UpdateFilmType(int id, string newType)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);
            if (film == null)
            {
                Console.WriteLine("X Film listede bulunamadı.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newType))
            {
                Console.WriteLine("X Film türü boş olamaz.");
                return;
            }

            if (film.Type.Equals(newType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("X Yeni film türü eski türüyle aynı!");
                return;
            }
            film.Type = newType;
            Console.WriteLine("> Film türü başarıyla güncellendi");
            Console.WriteLine("---------------------------------\n");
            film.DisplayInfo();
        }

        public void UpdateFilmYear(int id, string newYear)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);
            if (film == null)
            {
                Console.WriteLine("X Film listede bulunamadı.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newYear))
            {
                Console.WriteLine("X Film yılı boş olamaz.");
                return;
            }

            if (film.Year.Equals(newYear, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("X Yeni film yılı eski yılıyla aynı!");
                return;
            }
            film.Year = newYear;
            Console.WriteLine("> Film yılı başarıyla güncellendi");
            Console.WriteLine("---------------------------------\n");
            film.DisplayInfo();
        }

        public void UpdateFilmDirector(int id, string newDirector)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);
            if (film == null)
            {
                Console.WriteLine("X Film listede bulunamadı.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newDirector))
            {
                Console.WriteLine("X Film yönetmeni boş olamaz.");
                return;
            }

            if (film.Director.Equals(newDirector, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("X Yeni film yönetmeni eski yönetmenle aynı!");
                return;
            }
            film.Director = newDirector;
            Console.WriteLine("> Film yönetmeni başarıyla güncellendi");
            Console.WriteLine("--------------------------------------\n");
            film.DisplayInfo();

        }
    }
}

