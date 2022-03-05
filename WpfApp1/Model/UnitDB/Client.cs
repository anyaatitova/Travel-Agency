using System.Collections.Generic;

namespace WpfApp1.Model.UnitDB
{
    public class Client
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string PassNum { get; set; }
        public List<Tour> Tours { get; set; }
        public Client() { }
    }
}