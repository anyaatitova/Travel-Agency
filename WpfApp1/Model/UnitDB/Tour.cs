using System;
using System.ComponentModel.DataAnnotations.Schema;
using WpfApp1.Model.Data;

namespace WpfApp1.Model.UnitDB
{
    public class Tour
    {
          public Tour()
          {
          }


        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PersonCount { get; set; }
        public int DaysCount { get; set; }
        public virtual Country Country { get; set; }
        public int IdCountry { get; set; }
        public virtual Hotel Hotel { get; set; }
        public int IdHotel { get; set; }
        public virtual TourType TourType { get; set; }
        public int IdTourType { get; set; }
        public virtual Nutrition Nutrition { get; set; }
        public int IdNutrition { get; set; }
        public virtual Client Client { get; set; }
        public int IdClient { get; set; }
        public virtual Discount Discount { get; set; }
        public int IdDiscount { get; set; }
        public bool Status { get; set; }

        [NotMapped]
        public Hotel TourHotel => DataWorker.GetHotelById(IdHotel);

        [NotMapped]
        public Country TourCountry => DataWorker.GetCountryHyId(IdCountry);

        [NotMapped]
        public TourType TourTourType => DataWorker.GetTourTypeById(IdTourType);

        [NotMapped]
        public Nutrition TourNutrition => DataWorker.GetNutritionById(IdNutrition);

        [NotMapped]
        public Client TourClient => DataWorker.GetClientById(IdClient);

        [NotMapped]
        public Discount TourDiscount => DataWorker.GetDiscountById(IdDiscount);

        public bool ChangeStatus() => !Status;
    }
}