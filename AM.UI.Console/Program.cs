// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Plane p1 = new Plane();
            //p1.Capacity = 10;
            //p1.ManifactureDate = new DateTime(2023, 02, 05);
            //p1.PlaneType = PlaneType.Airbus;


            ////signature du cons paramétré : instancation 
            //Plane p2 = new Plane(PlaneType.Airbus, 200, DateTime.Now); 

            //intialiseur d'objet : pour éviter de créer * const
            Plane p3 = new Plane()
            {
                PlaneType = PlaneType.Boing,
                Capacity = 12,
                ManifactureDate = new DateTime(2023, 02, 05)
            };

            //Passenger passenger = new Passenger()
            //{
            //    FirstName = "Steve",
            //    LastName = "Foxx",
            //    EmailAddress = "boxingUK@gmail.com",
            //};
            //Console.WriteLine(passenger.CheckProfile("Steve", "Foxx", "boxingUK@gmail.com"));
            //Traveller traveller = new Traveller()
            //{
            //    FirstName="Touhemi",
            //    LastName="Toukebri",
            //    EmailAddress = "boxingUK@gmail.com",
            //    HealthInformation = "Gucci",
            //    Nationality="Disney"
            //};
            //Staff staff = new Staff()
            //{
            //    FirstName = "Miguel",
            //    LastName = "Foxx",
            //    EmailAddress = "boxingUK@gmail.com",
            //};
            //Console.WriteLine("uno");
            //staff.PassengerType();
            //Console.WriteLine("duo");
            //traveller.PassengerType();
            //Console.WriteLine("trio");
            //passenger.PassengerType();

            ServiceFlight serviceFlight = new ServiceFlight();
            serviceFlight.Flights = TestData.listFlights;
            //foreach (var item in serviceFlight.GetFlightDates("Paris"))
            serviceFlight.DestinationGroupedFlights();
        }
    }
}