namespace Core;

public class Flight
{
    public string FlightCode { get; private set; }
    public string Origin { get; private set; }
    public string Destination { get;  set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArivalTime { get; set; }
    public int MaxCapacity { get; set; }
    public FlightState State { get; set; }
    public double Price { get; private set; }

    public Flight(string flightCode, string origin, string destination, DateTime departureTime, DateTime arivalTime, int maxCapacity, FlightState state, double price)
    {
        FlightCode = flightCode;
        Origin = origin;
        Destination = destination;
        DepartureTime = departureTime;
        ArivalTime = arivalTime;
        MaxCapacity = maxCapacity;
        State = state;
        Price = price;
    }

    public double calculatePrice()
    {
        return 0;
    }
}