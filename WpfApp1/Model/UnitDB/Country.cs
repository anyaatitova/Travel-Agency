using System.Collections.Generic;

namespace WpfApp1.Model.UnitDB
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double FlyPrice { get; set; }
        public List<Tour> Tours { get; set; }

        public Country() { }

    }
}