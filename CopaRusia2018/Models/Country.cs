using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CopaRusia2018.Models
{
    public enum Continent
    {
        America, Europe, Asia, Africa, Oceania
    }
    public class Country
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Continent{ get; set; }
        public DateTime Foundation { get; set; }
        public List<Player> Players{ get; set; }

    }
}
