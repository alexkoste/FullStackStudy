namespace HW1.Models
{
    public class Car
    {
        public Car(string make, string model, int year, string country)
        {
            Make = make;
            Model = model;
            Year = year;
            Country = country;
        }

        public string Model { get; set; }

        public string Make { get; set; }

        public int Year { get; set; }

        public string Country { get; set; }

    }
}