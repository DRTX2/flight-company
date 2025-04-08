namespace Core;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Reservation Application");
        
        Passenger passenger = new Passenger("1850656065",new List<Reservation>(), 500);
        var flights = new List<Flight>();
        flights.Add(new Flight("V01","Ecuador","USA", DateTime.Now, DateTime.Now, 120,FlightState.Available,450));
        
        var beachReservation = new Reservation(1,passenger,flights,340,ReservationState.COMMITED,FlightClass.BUSINESS);
        
    }
}