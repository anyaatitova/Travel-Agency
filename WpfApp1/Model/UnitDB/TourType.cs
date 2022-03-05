using System.Collections.Generic;
using System.Security.AccessControl;

namespace WpfApp1.Model.UnitDB
{
    public class TourType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public List<Tour> Tours { get; set; }
        public TourType() { }
    }
}