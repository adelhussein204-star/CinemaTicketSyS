using System.Linq.Expressions;

namespace CinemaTicketSyS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            User user = new User(movies);

            while (true)
            {
                /// ====== Console Output ======
                Console.WriteLine("=========== Cinema Ticket System ===========");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. View Movies");
                Console.WriteLine("3. Search Movie");
                Console.WriteLine("4. Book Ticket");
                Console.WriteLine("5. Cancel Booking");
                Console.WriteLine("============================================");

                /// ====== User Input ======
                var userInput = int.Parse(Console.ReadLine());
                user.AddMovie(1, "The Matrix", 10.0, 100);
                user.AddMovie(2, "Inception", 12.0, 80);
                user.AddMovie(3, "Interstellar", 15.0, 50);


                switch (userInput)
                {
                    case 1:
                        // Add Movie method
                        Console.Write("Enter Movie ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Movie Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Ticket Price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter Available Seats: ");
                        int seats = int.Parse(Console.ReadLine());

                        user.AddMovie(id, title, price, seats);
                        break;
                    case 2:
                        // View Movies method
                        Console.Write("Viewing all movies...\n");
                        user.ViewMovies();
                        break;
                    case 3:
                        // Search Movie method
                        Console.Write("Enter Movie ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        user.SearchMovie(searchId);
                        break;
                    case 4:
                        // Book Ticket method
                        Console.Write("Enter Movie ID to book: ");
                        int idSearch = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of seats to book: ");
                        int numberOfSeats = int.Parse(Console.ReadLine());
                        user.BookingTicket(idSearch, numberOfSeats);
                        break;
                    case 5:
                        // Cancel Booking method
                        Console.Write("Enter Movie ID to cancel booking: ");
                        int idSearchCancel = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of seats to cancel: ");
                        int numberOfSeatsCancel = int.Parse(Console.ReadLine());
                        user.CancelBooking(idSearchCancel, numberOfSeatsCancel);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }


                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
