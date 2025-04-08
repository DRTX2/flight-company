namespace Core;

public class Reservation(int id, 
    Passenger passenger, 
    List<Flight> flights, 
    double price, 
    ReservationState reservationState, 
    FlightClass flightClass)
{
    private readonly int _id;
    public Passenger passenger { get; private set; }
    public List<Flight> Flights { get; set; }
    public double Price { get; set;  }
    public ReservationState ReservationState { get; set; }

    public FlightClass FlightClass { get; set; }
    
    
}