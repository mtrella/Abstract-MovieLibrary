using System;
using System.Collections.Generic;
using NLog;

namespace MovieLibrary
{
    class Program
    {
        //class  logger
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            string mfile = "movies.csv";
            string sFile = "shows.csv";
            string vFile = "videos.csv";
            logger.Info("Program started");

            MovieFile movieFile = new MovieFile(mfile);
            
            string choice = "";
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Display All Movies");
                Console.WriteLine("3. Enter to quit");
                //input
                choice = Console.ReadLine();
                logger.Info("User choice: {Choice}", choice);
                if (choice == "1")
                {
                    // Add movie 
                    Movie movie = new Movie();
                    Console.WriteLine("Enter movie title");
                    movie.title = Console.ReadLine();

                    if (movieFile.isUniqueTitle(movie.title)){
                        string input;
                        do
                        {
                            //enter genre
                            Console.WriteLine("Enter genre (or type 'finished' to quit)");
                            //input
                            input = Console.ReadLine();
                            // asks for additional genres until "finished" is typed
                            if (input != "finished" && input.Length > 0)
                            {
                                movie.genres.Add(input);
                            }
                        } while (input != "finished");

                        if (movie.genres.Count ==0)
                        {
                            movie.genres.Add("(no genres listed)");
                        }
                        // add movie
                        movieFile.AddMovie(movie);
                    }
                    else
                    {
                        Console.WriteLine("Movie title already exists\n");
                    }
                } else if (choice == "2")
                {
                    // Display ALL movies
                    foreach(Movie m in movieFile.Movies)
                    {
                        Console.WriteLine(m.DisplayMovie());
                    }
                }
            } while (choice == "1" || choice == "2");

            logger.Info("Program ended");
        }
    }
}
