namespace Core;

public static class PassengerFactory
{
    public static Passenger CreatePassenger(PassengerType type, string dni, List<Reservation> reservations,
        double wallet = 0)
    {
        return type switch
        {
            PassengerType.ECONOMY => new EconomyPassenger(dni, reservations, wallet),
            PassengerType.PREMIUM => new PremiumPassenger(dni, reservations, wallet),
            PassengerType.VIP => new VipPassenger(dni, reservations, wallet),
            _ => throw new ArgumentException("Invalid passenger type")
        };

    }
}