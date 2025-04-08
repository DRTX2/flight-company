using System.Collections;

namespace Core;

public abstract class Passenger(string dni, List<Reservation> reservations, double wallet = 0)
{
    public string Dni { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Reservation> Reservations { get; private set; } = reservations ?? new List<Reservation>();
    public double Wallet { get; private set; }

    public void AddFlightReservation(Reservation reservation) => Reservations.Add(reservation);
    
    public void AddToWallet(double amount)
    {
        if (amount > 0)
            Wallet += amount;
    }

    public virtual double GetDiscountMultiplier() => 1;

    public abstract string GetPassengerType();
}