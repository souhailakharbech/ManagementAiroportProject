using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IServicesFlight
    {
        //List<DateTime> GetFlightDates(string destination);
        void GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        public IEnumerable<DateTime> GetFlightdates(string destination);
        public IEnumerable<Flight> OrderedDurationFlights();
        public IEnumerable<Traveller> SeniorTravellers(Flight flight);
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
}
