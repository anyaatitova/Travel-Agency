using System.Collections.Generic;
using System.Security.AccessControl;

namespace WpfApp1.Model.UnitDB
{
    public class Nutrition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PriceByDay { get; set; }
        public List<Tour> Tours { get; set; }

        public Nutrition() { }

    }
}