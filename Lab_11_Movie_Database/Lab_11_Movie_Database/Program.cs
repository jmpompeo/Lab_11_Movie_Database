using System;
using System.Collections.Generic;

namespace Lab_11_Movie_Database
{
    class Program
    {
        static void Main(string[] args)
        {

            string response;

            Console.WriteLine("Welcome to the Movie List Application!" + "\r\n" + "There are 10 movies in this list.");

            do
            {
                GetPrintMovie();

                Console.WriteLine("Continue? (y/n) ");
                response = Console.ReadLine();

            } while (response.Equals("y", StringComparison.OrdinalIgnoreCase));
        }
        private static void GetPrintMovie()
        {

            var animated = new Movie();
            var drama = new Movie();
            var scifi = new Movie();
            var horror = new Movie();

            Console.WriteLine("What category are you interested in?");
            var input = Console.ReadLine();

            if (input.Equals("animated", StringComparison.OrdinalIgnoreCase))
            {
                animated.GetAnimated();
            }
            else if (input.Equals ("drama", StringComparison.OrdinalIgnoreCase))
            {
                drama.GetDrama();
            }
            else if (input.Equals("scifi", StringComparison.OrdinalIgnoreCase))
            {
                scifi.GetSciFi();
            }
            else if (input.Equals("horror", StringComparison.OrdinalIgnoreCase))
            {
                horror.GetHorror();
            }
        }
    }
}
