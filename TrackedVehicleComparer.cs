using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatyshevaExcavator
{
    class TrackedVehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            // Реализовать метод сравнения для объектов
            if (x.GetType() != y.GetType())
            {
                if (x is TrackedVehicle && y is Excavator) return -1;
                else return 1;
            }
            if (x.GetType().Name.Equals("Excavator")) return ComparerExcavator((Excavator)x, (Excavator)y);
            if (x.GetType().Name.Equals("TrackedVehicle")) return ComparerTrackedVehicle((TrackedVehicle)x, (TrackedVehicle)y);
            return 0;
        }
        private int ComparerTrackedVehicle(TrackedVehicle x, TrackedVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerExcavator(Excavator x, Excavator y)
        {
            var res = ComparerTrackedVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Bucket != y.Bucket)
            {
                return x.Bucket.CompareTo(y.Bucket);
            }
            if (x.Handle != y.Handle)
            {
                return x.Handle.CompareTo(y.Handle);
            }
            if (x.Arrow != y.Arrow)
            {
                return x.Arrow.CompareTo(y.Arrow);
            }
            if (x.Сounterweight != y.Сounterweight)
            {
                return x.Сounterweight.CompareTo(y.Сounterweight);
            }
            return 0;
        }
    }
}
