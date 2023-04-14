using HW2.Interfaces;

namespace HW2.Realizations
{
    public class ManagementCars : IManagementCars
    {
        public int GetCarAge()
        {
            return 10;
        }

        public string GetCarEngine()
        {
            return "Disel";
        }

        public string GetCarName()
        {
            return "Honda";
        }

    }
}
