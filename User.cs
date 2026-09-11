using System;

public class User
{
    private List<Movie> Movieslist;
    public User(List<Movie> movies)
    {
        Movieslist = movies;
    }

    public void AddMovie(int id, string title, double price, int availableSeats)
    {

  
        var x = Movieslist.Any(m => m.movieId == id);
        if (x == true) 
        {
        Console.WriteLine("Movie with this ID already exists.");

        }
        else
        {
            if (title != null && title != "")
            {
                Movie movie = new Movie(id, title, price, availableSeats);
                Movieslist.Add(movie);
                Console.WriteLine("Movie added successfully.");
            }

            else
            {
                Console.WriteLine("Movie title cannot be empty.");
            }
    
        }


    }


    public void ViewMovies()
    {
        foreach (var mo in Movieslist)
        {
            mo.DisplayMovieInfo();
        }
    }

    public void SearchMovie(int id)
    {
        var movieSearch = Movieslist.FirstOrDefault(m => m.movieId == id);
        if (movieSearch != null)
        {
            movieSearch.DisplayMovieInfo();
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }

    public void BookingTicket(int idSearch, int numberOfSeats)
    {
        if (numberOfSeats > 0)
        {
            var movie = Movieslist.FirstOrDefault(m => m.movieId == idSearch);
            if (movie != null)
            {
                Console.WriteLine("Movie Title: " + movie.movieTitle);
                Console.WriteLine("Available Seats: " + movie.availableSeats);
                if (numberOfSeats > 0 && numberOfSeats <= movie.availableSeats)
                {
                    movie.availableSeats = movie.availableSeats - numberOfSeats;
                    Console.WriteLine("Booking successful.");
                    Console.WriteLine("Total Ticket Pricing: " + (movie.ticketPrice * numberOfSeats));

                }
                else
                { Console.WriteLine("Not enough seats available."); }

            }
            else { Console.WriteLine("Movie not found."); }
        }
    }

    public void CancelBooking(int idSearch, int numberOfSeats)
    { if (numberOfSeats > 0) 
        {
            var moiveSe = Movieslist.FirstOrDefault(m => m.movieId == idSearch);
            if (moiveSe != null)
            {
                
                    moiveSe.availableSeats += numberOfSeats;
                    Console.WriteLine("Booking canceled successfully.");
                    Console.WriteLine("Total seats available: " + moiveSe.availableSeats);
               
              
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }

        }
   
    }
}
