namespace Core;

public class PremiumPassenger : Passenger
{
    public PremiumPassenger(string dni, List<Reservation> reservations, double wallet = 0)
        : base(dni, reservations, wallet) { }

    public override double GetDiscountMultiplier() => 0.9; // 10% de descuento

    public override string GetPassengerType() => "Premium";
}