using System;

namespace lab4
{
    delegate void DellFilmsBase();
    internal class DellSearch
    {
        private static FilmBase storage_all;
        private FilmBase storage_search;
        private DellFilmsBase dfb;

        public DellSearch() { }

        public void DisplayOptions()
        {
            Console.WriteLine($"FilmBase Options:\n" +
                              $"---------------------\n" +
                              $"- [0] - upload DB\n" +
                              $"- [1] - search by title\n" +
                              $"- [2] - search by genre\n" +
                              $"- [3] - search by director\n" +
                              $"- [4] - search by year\n" +
                              $"- [5] - search by rating\n" +
                              $"---------------------\n");

            this.CallOption();
        }

        private void CallOption()
        {
            Console.Write("Choose the option: ");
            int num = Convert.ToInt32(Console.ReadLine());
            storage_search = new FilmBase();

            switch (num)
            {
                case 0:
                    this.dfb = storage_search.uploadDB;
                    this.dfb();
                    this.Ask();
                    break;
                case 1:
                    this.dfb = storage_search.byTitle;
                    this.dfb();
                    this.Ask();
                    break;
                case 2:
                    this.dfb = storage_search.byGenre;
                    this.dfb();
                    this.Ask();
                    break;
                case 3:
                    this.dfb = storage_search.byDirector;
                    this.dfb();
                    this.Ask();
                    break;
                case 4:
                    this.dfb = storage_search.byYear;
                    this.dfb();
                    this.Ask();
                    break;
                case 5:
                    this.dfb = storage_search.byRating;
                    this.dfb();
                    this.Ask();
                    break;
                default:
                    this.Ask();
                    break;

            }
        }

        private void Ask()
        {
            Console.Write("Continue? [Y/N]: ");
            string res = Console.ReadLine();
            if (res == "Y" || res == "y")
                this.CallOption();
            return;
        }
    }
}
