using System.Collections.Generic;
using System.Security.AccessControl;
using System.Windows.Documents;

namespace WpfApp1.Model.UnitDB
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public double PriceByNight { get; set; }
        public List<Tour> Tours { get; set; }

        public Hotel() { }
    }
}