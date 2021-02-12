using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_Movie_Database
{
    public class Movie
    {
        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public Movie()
        {

        }

        private string _category;
        private string _title;

        public void GetHorror()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "horror")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        public void GetAnimated()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "animated")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        public void GetSciFi()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "sci-fi")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        public void GetDrama()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "drama")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        private List<Movie> InitializeList()
        {
            var list = new List<Movie>();

            list.Add(new Movie("Spirited Away", "animated"));
            list.Add(new Movie("Frozen", "animated"));
            list.Add(new Movie("Rambo", "drama"));
            list.Add(new Movie("Django Unchained", "drama"));
            list.Add(new Movie("Texas Chainsaw Massacre", "horror"));
            list.Add(new Movie("Saw", "horror"));
            list.Add(new Movie("Star Wars", "sci-fi"));
            list.Add(new Movie("Jurassic", "sci-fi"));
            list.Add(new Movie("Annabelle", "horror"));
            list.Add(new Movie("The Conjouring", "horror"));

            return list;
        }
    }
}
