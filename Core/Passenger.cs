using System.Collections;

namespace Core;

public class Passenger(string dni, List<Reservation> reservations, double wallet = 0)
{
    public string Dni { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Reservation> Reservations { get; private set; }
    // public string Type { get; private set; }
    public double Wallet { get; private set; }

    public void AddFlightReservation(Reservation reservation) => Reservations.Add(reservation);
    
    public void AddToWallet(double amount)
    {
        if (amount > 0)
            Wallet += amount;
    }
    
}