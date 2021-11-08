using System;
using System.Collections.Generic;
using System.Linq;
using AirCompany.Planes;
using AirCompany.Models;

namespace AirCompany
{
    public class Airport
    {
        public List<Plane> Planes { get; }

        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public List<PassengerPlane> GetPassengerPlanes()
        {
            return Planes.OfType<PassengerPlane>().ToList();
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            return Planes.OfType<MilitaryPlane>().ToList();
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            List<PassengerPlane> passengerPlanes = GetPassengerPlanes();
            return passengerPlanes.Aggregate((first, second) => first.Capacity() > second.Capacity() ? first : second);             
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return Planes.OfType<MilitaryPlane>().Where(plane => plane.Type == MilitaryType.Transport).ToList();

        }

        public Airport SortByMaxDistance()
        {
            return new Airport(Planes.OrderBy(plane => plane.MaxFlightDistance));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(Planes.OrderBy(plane => plane.MaxSpeed));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(Planes.OrderBy(plane => plane.MaxLoadCapacity));
        }

        public override string ToString()
        {
            return $"Airport{{planes={string.Join(", ", Planes.Select(plane => plane.Model))}}}";
        }
    }
}
