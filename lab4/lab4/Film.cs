using System;

namespace lab4
{
    internal class Film
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
                              $"IMDB rating: {this.rating}\n" +
                              "----------------------");
        }
    }
}