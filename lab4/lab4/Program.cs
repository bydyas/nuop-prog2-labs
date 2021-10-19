using System;
using System.Text.RegularExpressions;

namespace lab4
{
    class Film
    {
        private string title;
        private string genre;
        private string director;
        private string year;
        private string rating;

        public Film() { }

        public Film(string title, string genre, string director, string year, string rating)
        {
            this.title = title;
            this.genre = genre;
            this.director = director;
            this.year = year;
            this.rating = rating;
        }

        public string Title { get => this.title; set => this.title = value; }
        public string Genre { get => this.genre; set => this.genre = value; }
        public string Director { get => this.director; set => this.director = value; }
        public string Year { get => this.year; set => this.year = value; }
        public string Rating { get => this.rating; set => this.rating = value; }

        public void Write()
        {
            Console.Write("Enter the title: ");
            this.title = Console.ReadLine();
            Console.Write("Enter the genre: ");
            this.genre = Console.ReadLine();
            Console.Write("Enter the director: ");
            this.director = Console.ReadLine();
            Console.Write("Enter the released year: ");
            this.year = Console.ReadLine();
            Console.Write("Enter the IMDB rating: ");
            this.rating = Console.ReadLine();
        }

        public void Read()
        {
            Console.WriteLine("----------------------\n" +
                              $"Title: {this.title}\n" +
                              $"Genre: {this.genre}\n" +
                              $"Director: {this.director}\n" +
                              $"Release year: {this.year}\n" +
                              $"IMDB rating: {this.rating}\n"+
                              "----------------------");
        }

    }

    class FilmBase {
        private Film[] f_base;

        public FilmBase() {
            this.f_base = new Film[] {};
        }

        public void add(Film f)
        {
            Array.Resize(ref this.f_base, this.f_base.Length + 1);
            this.f_base[this.f_base.Length - 1] = f;
        }

        public void addByDefault()
        {
            Film f = new Film();
            Array.Resize(ref this.f_base, this.f_base.Length + 1);
            this.f_base[this.f_base.Length - 1] = f;
        }

        public void uploadDB()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\db.txt");
            foreach (string line in lines)
            {
                string[] temp = line.Split('|');
                Film f = new Film();
                f.Title = temp[0];
                f.Genre = temp[1];
                f.Director = temp[2];
                f.Year = temp[3];
                f.Rating = temp[4];
                this.add(f);
            }
        }

        public void byTitle()
        {
            Console.Write("Enter the title: ");
            string temp = Console.ReadLine();
            Regex regex = new Regex(temp);

            foreach (Film film in this.f_base)
            {
                if (regex.IsMatch(film.Title))
                {
                    film.Read();
                }
            }
        }

        public void byGenre()
        {
            Console.Write("Enter the genre: ");
            string temp = Console.ReadLine();
            Regex regex = new Regex(temp);

            foreach (Film film in this.f_base)
            {
                if (regex.IsMatch(film.Genre))
                {
                    film.Read();
                }
            }
        }

        public void byDirector()
        {
            Console.Write("Enter the director: ");
            string temp = Console.ReadLine();
            Regex regex = new Regex(temp);

            foreach (Film film in this.f_base)
            {
                if (regex.IsMatch(film.Director))
                {
                    film.Read();
                }
            }
        }

        public void byYear()
        {
            Console.Write("Enter the year: ");
            string temp = Console.ReadLine();

            foreach (Film film in this.f_base)
            {
                if (film.Year == temp)
                {
                    film.Read();
                }
            }
        }

        public void byRating()
        {
            Console.Write("Enter the rating: ");
            string temp = Console.ReadLine();

            foreach (Film film in this.f_base)
            {
                if (Convert.ToDouble(film.Rating) >= Convert.ToDouble(temp))
                {
                    film.Read();
                }
            }
        }

    }


    class Program
     {
        static void Main(string[] args)
        {
            FilmBase b = new FilmBase();
            b.uploadDB();
            b.byGenre();

            Console.ReadKey();
        }
     }
}
