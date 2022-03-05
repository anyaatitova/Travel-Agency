using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model.UnitDB;

namespace WpfApp1.Model.Data
{
    public static class DataWorker
    {
        #region AddMethods

        //Add Client
        public static string AddNewClient(string fio, string passNum)
        {
            using (var db = new ApplicationContext())
            {
                if (!db.Clients.Any(el => el.PassNum == passNum))
                {
                    var newClient = new Client { Fio = fio, PassNum = passNum };
                    db.Clients.Add(newClient);
                    db.SaveChanges();
                    return "Клиент успешно добавлен";
                }

                return "Данный клиент уже существует";
            }
        }

        //Add County
        public static string AddNewCountry(string name, double flyprice)
        {
            using (var db = new ApplicationContext())
            {
                if (!db.Countries.Any(el => el.Name == name))
                {
                    var newCountry = new Country { Name = name, FlyPrice = flyprice};
                    db.Countries.Add(newCountry);
                    db.SaveChanges();
                    return "Страна успешно добавлена";
                }

                return "Данная страна уже существует";
            }
        }

        //Add Discount
        public static string AddNewDiscount(int discount, string name)
        {
            using (var db = new ApplicationContext())
            {
                if (!db.Discounts.Any(el => el.Name == name))
                {
                    var newDiscount = new Discount { Name = name, Percent = discount };
                    db.Discounts.Add(newDiscount);
                    db.SaveChanges();
                    return "Скидка успешно добавлена";
                }

                return "Данная скидка уже существует";
            }
        }

        //Add Hotel
        public static string AddNewHotel(string name, int hotelClass, double price)
        {
            using (var db = new ApplicationContext())
            {
                if (!db.Hotels.Any(el => el.Name == name))
                {
                    var newHotel = new Hotel { Name = name, Class = hotelClass, PriceByNight = price};
                    db.Hotels.Add(newHotel);
                    db.SaveChanges();
                    return "Отель успешно добавлена";
                }

                return "Данный отель уже существует";
            }
        }

        //Add Nutrition
        public static string AddNewNutrition(string name, double price)
        {
            using (var db = new ApplicationContext())
            {
                if (!db.Nutritions.Any(el => el.Name == name))
                {
                    var newNutrition = new Nutrition { Name = name, PriceByDay = price};
                    db.Nutritions.Add(newNutrition);
                    db.SaveChanges();
                    return "Тип питания успешно добавлена";
                }

                return "Данный тип питания уже существует";
            }
        }

        //Add Staff
        public static string AddNewStaff(string fio, double salary)
        {
            using (var db = new ApplicationContext())
            {
                if (!db.Staves.Any(el => el.Fio == fio))
                {
                    var newStaff = new Staff { Fio = fio, Salary = salary };
                    db.Staves.Add(newStaff);
                    db.SaveChanges();
                    return "Сотрудник успешно добавлена";
                }

                return "Cотрудник уже существует";
            }
        }

        //Add Tour type
        public static string AddNewTourType(string type, double price)
        {
            using (var db = new ApplicationContext())
            {
                if (!db.TourTypes.Any(el => el.Type == type))
                {
                    var newTourType = new TourType { Type = type, Price = price};
                    db.TourTypes.Add(newTourType);
                    db.SaveChanges();
                    return "Тип тура успешно добавлена";
                }

                return "Данный тип тура уже существует";
            }
        }

        //Add Tour
        public static string AddNewTour(DateTime departureTime, int personCount, int daysCount,
            Country country, Hotel hotel, TourType tourType, Nutrition nutrition, Client client, Discount discount)
        {
            using (var db = new ApplicationContext())
            {
                Tour tour = new Tour()
                {
                    DepartureDate = departureTime,
                    PersonCount =  personCount,
                    DaysCount =  daysCount,
                    IdCountry = country.Id,
                    IdHotel =  hotel.Id,
                    IdTourType = tourType.Id,
                    IdNutrition = nutrition.Id,
                    IdClient =  client.Id,
                    IdDiscount =  discount.Id
                };

                double temp = (hotel.PriceByNight * daysCount) + (nutrition.PriceByDay * daysCount) + (country.FlyPrice * 2) + tourType.Price;
                double agencyPrice = temp * 0.3 + temp;
                if (discount.Percent != 0)
                    agencyPrice = agencyPrice - (agencyPrice * (discount.Percent / 100.0));

                tour.Price = agencyPrice;
                tour.Status = true;
                db.Tours.Add(tour);
                db.SaveChanges();
                return "Тур успешно добавлен";
            }
        }

        public static string ChangeTourStatus(Tour tour)
        {
            tour.Status = tour.ChangeStatus();
            return $"Статус тура номер {tour.Id} изменён";
        }


        #endregion

        #region RemoveMethods

        //Remove Client
        public static string DeleteClient(Client client)
        {
            using (var db = new ApplicationContext())
            {
                if (client == null)
                    return "Невозможно удалить пустое значение";
                db.Clients.Remove(client);
                db.SaveChanges();
                return $"Клиент {client.Fio} удалён";

            }
        }

        //Remove Country
        public static string DeleteCountry(Country country)
        {
            using (var db = new ApplicationContext())
            {
                if (country == null)
                    return "Невозможно удалить пустое значение";
                db.Countries.Remove(country);
                db.SaveChanges();
                return $"Страна {country.Name} удалена";
            }
        }

        //Remove Discount
        public static string DeleteDiscount(Discount discount)
        {
            using (var db = new ApplicationContext())
            {
                if (discount == null)
                    return "Невозможно удалить пустое значение";
                db.Discounts.Remove(discount);
                db.SaveChanges();
                return $"Скидка {discount.Name} удалена";
            }
        }

        //Remove Hotel
        public static string DeleteHotel(Hotel hotel)
        {
            using (var db = new ApplicationContext())
            {
                if (hotel == null)
                    return "Невозможно удалить пустое значение";
                db.Hotels.Remove(hotel);
                db.SaveChanges();
                return $"Отель {hotel.Name} удалён";

            }
        }

        //Remove Nutrition
        public static string DeleteNutrition(Nutrition nutrition)
        {
            using (var db = new ApplicationContext())
            {
                if (nutrition == null)
                    return "Невозможно удалить пустое значение";
                db.Nutritions.Remove(nutrition);
                db.SaveChanges();
                return $"Питание {nutrition.Name} удалено";
            }
        }

        //Remove Staff
        public static string DeleteStaff(Staff staff)
        {
            using (var db = new ApplicationContext())
            {
                if (staff == null)
                    return "Невозможно удалить пустое значение";
                db.Staves.Remove(staff);
                db.SaveChanges();
                return $"Сотрудник {staff.Fio} удалён";
            }
        }

        //Remove TourType
        public static string DeleteToutType(TourType type)
        {
            using (var db = new ApplicationContext())
            {
                if (type == null)
                    return "Невозможно удалить пустое значение";
                db.TourTypes.Remove(type);
                db.SaveChanges();
                return $"Тип тура {type.Type} удалён";
            }
        }

        //Remove Tour
        public static string DeleteTour(Tour tour)
        {
            using (var db = new ApplicationContext())
            {
                if (tour == null)
                    return "Невозможно удалить пустое значение";
                db.Tours.Remove(tour);
                db.SaveChanges();
                return $"Запись тура под номером {tour.Id} удалена";
            }
        }

        #endregion

        #region GetMethods

        public static Hotel GetHotelById(int id)
        {
            using (var db = new ApplicationContext())
            {
                Hotel hotel = db.Hotels.FirstOrDefault(el => el.Id == id);
                return hotel;
            }
        }

        public static Country GetCountryHyId(int id)
        {
            using (var db = new ApplicationContext())
            {
                Country country = db.Countries.FirstOrDefault(el => el.Id == id);
                return country;
            }
        }
        public static TourType GetTourTypeById(int id)
        {
            using (var db = new ApplicationContext())
            {
                TourType type = db.TourTypes.FirstOrDefault(el => el.Id == id);
                return type;
            }
        }
        public static Nutrition GetNutritionById(int id)
        {
            using (var db = new ApplicationContext())
            {
                Nutrition nutrition = db.Nutritions.FirstOrDefault(el => el.Id == id);
                return nutrition;
            }
        }
        public static Client GetClientById(int id)
        {
            using (var db = new ApplicationContext())
            {
                Client client = db.Clients.FirstOrDefault(el => el.Id == id);
                return client;
            }
        }

        public static Discount GetDiscountById(int id)
        {
            using (var db = new ApplicationContext())
            {
                Discount discount = db.Discounts.FirstOrDefault(el => el.Id == id);
                return discount;
            }
        }

        public static List<Client> GetAllClients()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Clients.ToList();
            }
        }

        public static List<Country> GetAllCountries()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Countries.ToList();
            }
        }

        public static List<Hotel> GetAllHotels()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Hotels.ToList();
            }
        }

        public static List<Discount> GetAlDiscounts()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Discounts.ToList();
            }
        }

        public static List<Nutrition> GetAllNutritions()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Nutritions.ToList();
            }
        }

        public static List<Staff> GetAllStaves()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Staves.ToList();
            }
        }

        public static List<TourType> GetAllTourTypes()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.TourTypes.ToList();
            }
        }

        public static List<Tour> GetAllTours()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Tours.ToList();
            }
        }

        #endregion
    }
}