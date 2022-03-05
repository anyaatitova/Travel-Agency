using System.Collections.Generic;

namespace WpfApp1.Model.UnitDB
{
    public class Discount
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Percent { get; set; }
        public List<Tour> Tours { get; set; }

        public Discount() { }
    }
}