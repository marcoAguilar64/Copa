using System;

namespace CopaRusia2018.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime  BornDate { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int CountryID { get; set; }

        public Country Country { get; set; }
    }
}