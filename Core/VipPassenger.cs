namespace Core;

public class VipPassenger: Passenger
{
    public VipPassenger(string dni, List<Reservation> reservations, double wallet = 0)
        : base(dni, reservations, wallet) { }

    public override double GetDiscountMultiplier() => 0.75; // 25% de descuento

    public override string GetPassengerType() => "VIP";
}