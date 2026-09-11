using System;

public class Movie
{
    
	public int movieId { get; set; }
	public string movieTitle { get; set; }
	public double ticketPrice { get; set; }
	public int availableSeats { get; set ;}

	public Movie(int id, string title, double price, int seats)
    {
        movieId = id;
        movieTitle = title;
        ticketPrice = price;
        availableSeats = seats;
    }

    public void DisplayMovieInfo()
    {
        Console.WriteLine($"Movie ID: {movieId}");
        Console.WriteLine($"Title: {movieTitle}");
        Console.WriteLine($"Price: ${ticketPrice}");
        Console.WriteLine($"Available Seats: {availableSeats}");
    }



}
