using System;
using System.Collections.Generic;

namespace Day6ExeManageMovies
{
    internal class Program
    {
        static void Main()
        {
            List<string> movieList = new List<string>()
            {
                "Inception",
                "Titanic",
                "Avatar",
                "The Godfather",
                "Pulp Fiction"
            };

            MainMenu(movieList);
        }

        static void MainMenu(List<string> movieList)
        {
            bool isNotExit = true;
            while (isNotExit)
            {
                Console.Clear();
                Console.WriteLine("\n\n\tMain Menu:");
                Console.WriteLine("\t1. List all Movies");
                Console.WriteLine("\t2. Return Movie");
                Console.WriteLine("\t3. Update Movie");
                Console.WriteLine("\t4. Delete Movie");
                Console.WriteLine("\t5. Add Movie");
                Console.WriteLine("\t6. Exit");
                Console.Write("\n\tEnter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ListAllMovies(movieList);
                        break;
                    case "2":
                        ReturnMovie(movieList);
                        break;
                    case "3":
                        UpdateMovie(movieList);
                        break;
                    case "4":
                        DeleteMovie(movieList);
                        break;
                    case "5":
                        AddMovie(movieList);
                        break;
                    case "6":
                        Console.WriteLine("\n\tThank you for " +
                               "using the movie management system.");
                        isNotExit = false;
                        break;
                    default:
                        Console.WriteLine("\n\tInvalid choice. Please" +
                                " select a valid option (between 1 and 6).");
                        break;
                }
                Console.Write("\n\tPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void ListAllMovies(List<string> movieList)
        {
            Console.WriteLine("\n\tMovies List:\n\t------------");
            foreach (string movie in movieList)
            {
                Console.WriteLine($"\t- {movie}");
            }
        }

        static void ReturnMovie(List<string> movieList)
        {
            Console.Write("\n\tEnter movie index: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < movieList.Count)
            {
                Console.WriteLine($"\n\tMovie at index {index}: {movieList[index]}");
            }
            else
            {
                Console.WriteLine("\n\tInvalid index.");
            }
        }

        static void UpdateMovie(List<string> movieList)
        {
            Console.Write("\n\tEnter movie index to update: ");

            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < movieList.Count)
            {
                Console.Write("\tEnter new movie name: ");
                string newName = Console.ReadLine();
                movieList[index] = newName;
                Console.WriteLine("\n\tMovie updated successfully.");
            }
            else
            {
                Console.WriteLine("\n\tInvalid index.");
            }
        }

        static void DeleteMovie(List<string> movieList)
        {
            Console.Write("\n\tEnter movie index to remove: ");

            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < movieList.Count)
            {
                movieList.RemoveAt(index);
                Console.WriteLine("\n\tMovie removed successfully.");
            }
            else
            {
                Console.WriteLine("\n\tInvalid index.");
            }
        }

        static void AddMovie(List<string> movieList)
        {
            Console.Write("\n\tEnter new movie name: ");
            string newMovie = Console.ReadLine();

            if (!string.IsNullOrEmpty(newMovie) && !movieList.Contains(newMovie))
            {
                movieList.Add(newMovie);
                Console.WriteLine("\n\tMovie added successfully.");
            }
            else
            {
                Console.WriteLine("\n\tInvalid movie name or movie already exists.");
            }
        }
    }
}
