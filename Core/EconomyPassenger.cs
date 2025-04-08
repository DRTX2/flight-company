namespace Core;

public class EconomyPassenger: Passenger
{
    public EconomyPassenger(string dni, List<Reservation> reservations, double wallet = 0)
        : base(dni, reservations, wallet) { }
    
    public override double GetDiscountMultiplier() => 1.0; // wtf
    
    public override string GetPassengerType() => "Economy";
    
}