
namespace AirCompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int PassengersCapacity { get; set; }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            this.PassengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PassengersCapacity == plane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            int hashCode = 751774561;
            int multiplier = -1521134295;
            hashCode = hashCode * multiplier + base.GetHashCode();
            hashCode = hashCode * multiplier + PassengersCapacity.GetHashCode();
            return hashCode;
        }

        public int Capacity()
        {
            return PassengersCapacity;
        }

       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    $", passengersCapacity={PassengersCapacity}}}");
        }       
        
    }
}
