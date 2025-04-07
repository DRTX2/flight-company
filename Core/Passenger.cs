using System.Collections;

namespace Core;

public class Passenger
{
    private readonly string _dni;
    private List<Flight> _flights;
    private string type;
    private double _wallet;

    public Passenger(string dni, List<Flight> flights, string type, double wallet=0)
    {
        _dni = dni;
        _flights = flights ?? new List<Flight>();
        this.type = type;
        _wallet = wallet;
    }
    
    
}