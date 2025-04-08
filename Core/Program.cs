namespace Core;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🚀 Airline Reservation System");

        // Crear pasajero usando Factory
        Passenger passenger = PassengerFactory.CreatePassenger(
            PassengerType.ECONOMY,
            "1850656065",
            new List<Reservation>(),
            500
        );

        // Crear vuelo
        var flight = new Flight(
            "V01",
            "Ecuador",
            "USA",
            DateTime.Now.AddDays(1),
            DateTime.Now.AddDays(1).AddHours(5),
            120,
            FlightState.Available,
            450
        );

        // Crear reserva
        var reservation = new Reservation(
            1,
            passenger,
            new List<Flight> { flight },
            340,
            ReservationState.COMMITED,
            FlightClass.BUSINESS
        );

        // Asociar reserva al pasajero
        passenger.AddFlightReservation(reservation);

        // Mostrar información
        Console.WriteLine($"Pasajero: {passenger.Name ?? "Sin nombre"} ({passenger.GetPassengerType()})");
        Console.WriteLine($"Vuelo reservado: {flight.FlightCode} de {flight.Origin} a {flight.Destination}");
        Console.WriteLine($"Precio pagado: {reservation.Price} USD");
    }
}