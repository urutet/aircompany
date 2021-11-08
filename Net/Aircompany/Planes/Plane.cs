using System.Collections.Generic;

namespace AirCompany.Planes
{
    public abstract class Plane
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxFlightDistance { get; set; }
        public int MaxLoadCapacity { get; set; }

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MaxLoadCapacity = maxLoadCapacity;
        }

        public override string ToString()
        {
            return $"Plane{{model={Model}, maxSpeed={MaxSpeed}, maxFlightDistance={MaxFlightDistance}, maxLoadCapacity={MaxLoadCapacity}}}";
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   Model == plane.Model &&
                   MaxSpeed == plane.MaxSpeed &&
                   MaxFlightDistance == plane.MaxFlightDistance &&
                   MaxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            int hashCode = -1043886837;
            int multiplier  = -1521134295;
            hashCode = hashCode * multiplier + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * multiplier + MaxSpeed.GetHashCode();
            hashCode = hashCode * multiplier + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * multiplier + MaxLoadCapacity.GetHashCode();
            return hashCode;
        }        

    }
}
