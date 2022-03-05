using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Annotations;
using WpfApp1.Model.Data;
using WpfApp1.Model.UnitDB;
using WpfApp1.View;
using WpfApp1.View.AddWindow;
using WpfApp1.ViewModel.Workers;

namespace WpfApp1.ViewModel
{
    public class DataManage : INotifyPropertyChanged
    {
        private const string FIO_REGEX = @"([А-ЯЁ][а-яё]+[\-\s]?){3,}";
        private const string PASS_REGEX = @"[A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9]";

        #region DataProp

        private List<Hotel> allHotels = DataWorker.GetAllHotels();
        public List<Hotel> AllHotels
        {
            get => allHotels;
            set
            {
                allHotels = value;
                OnPropertyChanged("AllHotels");
            }
        }

        private List<Client> allClients = DataWorker.GetAllClients();
        public List<Client> AllClients
        {
            get => allClients;
            set
            {
                allClients = value;
                OnPropertyChanged("AllClients");
            }
        }

        private List<Staff> allStaves = DataWorker.GetAllStaves();
        public List<Staff> AllStaves
        {
            get => allStaves;
            set
            {
                allStaves = value;
                OnPropertyChanged("AllStaves");
            }
        }

        private List<Country> allCountries = DataWorker.GetAllCountries();
        public List<Country> AllCountries
        {
            get => allCountries;
            set
            {
                allCountries = value;
                OnPropertyChanged("AllCountries");
            }
        }

        private List<Discount> allDiscounts = DataWorker.GetAlDiscounts();
        public List<Discount> AllDiscounts
        {
            get => allDiscounts;
            set
            {
                allDiscounts = value;
                OnPropertyChanged("AllDiscounts");
            }
        }

        private List<Nutrition> allNutritions = DataWorker.GetAllNutritions();
        public List<Nutrition> AllNutritions
        {
            get => allNutritions;
            set
            {
                allNutritions = value;
                OnPropertyChanged("AllNutritions");
            }
        }

        private List<TourType> allTourTypes = DataWorker.GetAllTourTypes();
        public List<TourType> AllTourTypes
        {
            get => allTourTypes;
            set
            {
                allTourTypes = value;
                OnPropertyChanged("AllTourTypes");
            }
        }

        private List<Tour> allTours = DataWorker.GetAllTours();
        public List<Tour> AllTours
        {
            get => allTours;
            set
            {
                allTours = value;
                OnPropertyChanged("AllTours");
            }
        }

        #endregion

        #region Command prop
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string HotelName { get; set; }
        public string HotelClass { get; set; }
        public string HotelPrice { get; set; }
        public string CountryName { get; set; }
        public string FlyPrice { get; set; }
        public string NutritionName { get; set; }
        public string NutritionPrice { get; set; }
        public string ClientFio { get; set; }
        public string ClientPassNum { get; set; }
        public string StaffFio { get; set; }
        public string StaffSalary { get; set; }
        public string DiscountName { get; set; }
        public string DiscountPercent { get; set; }
        public string TourTypeType { get; set; }
        public string TourTypePrice { get; set; }


        public Country Country { get; set; }
        public Client Client { get; set; }
        public Discount Discount { get; set; }
        public Hotel Hotel { get; set; }
        public Nutrition Nutrition { get; set; }
        public TourType TourType { get; set; }
        public DateTime DepartureDate { get; set; }
        public string PersonCount { get; set; }
        public string DaysCount { get; set; }
        public object SelectedItem { get; set; }
        public TabItem TabItem { get; set; }
        #endregion

        #region Command to open windows

        private RelayCommand openWindow;
        public RelayCommand OpenWindow
        {
            get => openWindow ?? new RelayCommand(obj =>
            {
                Window window = obj as Window;
                if (Login == null || Password == null || Position == null || Login == "" || Password == "" ||
                    Position == "")
                    MessageBox.Show("Заполните поля");
                else
                {
                    if (Login == "root" && Password == "root" && Position == "Турагент")
                    {
                        WindowWorker.OpenWindow(new AgentMainWindow());
                        WindowWorker.CloseWindow(window);
                    }
                        
                    else
                    {
                        if (Login == "admin" && Password == "admin" && Position == "Администратор")
                        {
                            WindowWorker.OpenWindow(new AdminMainWindow());
                            WindowWorker.CloseWindow(window);
                        }
                        
                        else
                            MessageBox.Show("Заполните поля корректно");
                    }
                }
            });
        }


        private RelayCommand openAddHotelWindow;
        public RelayCommand OpenAddHotelWindow
        {
            get => openAddHotelWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddHotelWindow());
            });
        }


        private RelayCommand openAddCountruWindow;
        public RelayCommand OpenAddCountruWindow
        {
            get => openAddCountruWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddNewCountryWindow());
            });
        }


        private RelayCommand openAddnutrutionWindow;
        public RelayCommand OpenAddnutrutionWindow
        {
            get => openAddnutrutionWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddNutritionWindow());
            });
        }


        private RelayCommand openAddClientWindow;
        public RelayCommand OpenAddClientWindow
        {
            get => openAddClientWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddClientWindow());
            });
        }


        private RelayCommand openAddStaffWindow;
        public RelayCommand OpenAddStaffWindow
        {
            get => openAddStaffWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddStaffWindow());
            });
        }


        private RelayCommand openAddTourTypeWindow;
        public RelayCommand OpenAddTourTypeWindow
        {
            get => openAddTourTypeWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddTourTypeWindow());
            });
        }

        private RelayCommand openAddDiscountWindow;
        public RelayCommand OpenAddDiscountWindow
        {
            get => openAddTourTypeWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddDiscountWindow());
            });
        }

        private RelayCommand openAddNewTourWindow;

        public RelayCommand OpenAddNewTourWindow
        {
            get => openAddNewTourWindow ?? new RelayCommand(obj =>
            {
                WindowWorker.OpenWindow(new AddTourWindow());
            });
        }


        private RelayCommand addDiscount;
        public RelayCommand AddDiscount
        {
            get => addDiscount ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(DiscountName) && !string.IsNullOrEmpty(DiscountPercent) &&
                    int.TryParse(DiscountPercent, out int discountResult) &&
                    (discountResult >= 0 && discountResult <= 50))
                {
                    MessageBox.Show(DataWorker.AddNewDiscount(discountResult, DiscountName));
                    WindowWorker.Refresh(new AdminMainWindow());
                }
                else
                {
                    MessageBox.Show("Заполните поля корректными данными (Скидка от 0 до 50)");
                }
            });
        }


        private RelayCommand addTourType;
        public RelayCommand AddTourType
        {
            get => addTourType ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(TourTypePrice) && !string.IsNullOrEmpty(TourTypeType) &&
                    double.TryParse(TourTypePrice, out double priceResult) && priceResult > 0)
                {
                    MessageBox.Show(DataWorker.AddNewTourType(TourTypeType, priceResult)); 
                    WindowWorker.Refresh(new AdminMainWindow());
                }
                else
                {
                    MessageBox.Show("Заполните поля корректными данными");
                }
            });
        }


        private RelayCommand addNewStaff;
        public RelayCommand AddNewStaff
        {
            get => addNewStaff ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(StaffFio) && !string.IsNullOrEmpty(StaffSalary) &&
                    double.TryParse(StaffSalary, out double salaryResult) && Regex.IsMatch(StaffFio, FIO_REGEX)
                    && (salaryResult > 400))
                {
                    MessageBox.Show(DataWorker.AddNewStaff(StaffFio, salaryResult));
                    WindowWorker.Refresh(new AdminMainWindow());
                }
                else
                {
                    MessageBox.Show("Заполните поля корректными данными (Зарплата не ниже 400)");
                }
            });
        }


        private RelayCommand addNewClient;
        public RelayCommand AddNewClient
        {
            get => addNewClient ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(ClientFio)
                    && !string.IsNullOrEmpty(ClientPassNum)
                    && Regex.IsMatch(ClientFio, FIO_REGEX)
                    && Regex.IsMatch(ClientPassNum, PASS_REGEX))
                {
                    MessageBox.Show(DataWorker.AddNewClient(ClientFio, ClientPassNum));
                    WindowWorker.Refresh(new AdminMainWindow());
                }
                else
                    MessageBox.Show("Заполните поля корректными данными");
            });
        }


        private RelayCommand addNewHotel;
        public RelayCommand AddNewHotel
        {
            get => addNewHotel ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(HotelName) 
                    && !string.IsNullOrEmpty(HotelClass) 
                    && !string.IsNullOrEmpty(HotelPrice) 
                    && int.TryParse(HotelClass, out int cResult) 
                    && double.TryParse(HotelPrice, out double pResult)
                    && pResult > 0)
                {
                    MessageBox.Show(DataWorker.AddNewHotel(HotelName, cResult, pResult));
                    WindowWorker.Refresh(new AdminMainWindow());
                }
                else
                    MessageBox.Show("Заполните поля корректными данными");

            });
        }


        private RelayCommand addNewNutrition;
        public RelayCommand AddNewNutrition
        {
            get => addNewNutrition ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(NutritionName) && !string.IsNullOrEmpty(NutritionPrice) &&
                    double.TryParse(NutritionPrice, out double priceResult) && priceResult >= 0)
                {
                    MessageBox.Show(DataWorker.AddNewNutrition(NutritionName, priceResult));
                    WindowWorker.Refresh(new AdminMainWindow());
                }
                  
                else
                    MessageBox.Show("Заполните поля корректными данными");
            });
        }


        private RelayCommand addNewCountry;
        public RelayCommand AddNewCounty
        {
            get => addNewCountry ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(CountryName) && !string.IsNullOrEmpty(FlyPrice) &&
                    double.TryParse(FlyPrice, out double priceResult) && priceResult > 0)
                {
                    MessageBox.Show(DataWorker.AddNewCountry(CountryName, priceResult));
                    WindowWorker.Refresh(new AdminMainWindow());
                }
                    
                else
                    MessageBox.Show("Заполните поля корректными данными");

            });
        }

        private RelayCommand addNewTour;

        public RelayCommand AddNewTour
        {
            get => addNewTour ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(ClientFio)
                    && !string.IsNullOrEmpty(CountryName)
                    && !string.IsNullOrEmpty(HotelName)
                    && !string.IsNullOrEmpty(NutritionName)
                    && !string.IsNullOrEmpty(TourTypeType)
                    && !string.IsNullOrEmpty(DiscountName)
                    && !string.IsNullOrEmpty(PersonCount)
                    && !string.IsNullOrEmpty(DaysCount)
                    && int.TryParse(PersonCount, out int personResult)
                    && int.TryParse(DaysCount, out int daysResult)
                    && personResult > 0
                    && daysResult > 0)
                {
                    MessageBox.Show(DataWorker.AddNewTour(DepartureDate, personResult, daysResult, Country, Hotel, TourType, Nutrition,
                        Client, Discount));
                }
                else
                {
                    MessageBox.Show("Заполните все поля корректными данными");
                }
            });
        }

        private RelayCommand deleteItem;
        public RelayCommand DeleteItem
        {
            get => deleteItem ?? new RelayCommand(obj =>
            {
                Window window = obj as Window;
                string result = "Ничего не выбрано";
                if ((TabItem != null && SelectedItem != null))
                {
                    if (TabItem.Name == "HotelTab")
                    {
                       
                        result = DataWorker.DeleteHotel(SelectedItem as Hotel);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }

                    if (TabItem.Name == "ClientTab")
                    {
                        result = DataWorker.DeleteClient(SelectedItem as Client);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }

                    if (TabItem.Name == "StaffTab")
                    {
                        result = DataWorker.DeleteStaff(SelectedItem as Staff);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }

                    if (TabItem.Name == "TourTypeTab")
                    {
                        result = DataWorker.DeleteToutType(SelectedItem as TourType);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }

                    if (TabItem.Name == "CountryTab")
                    {
                        result = DataWorker.DeleteCountry(SelectedItem as Country);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }


                    if (TabItem.Name == "DiscountTab")
                    {
                        result = DataWorker.DeleteDiscount(SelectedItem as Discount);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }

                    if (TabItem.Name == "NutrutionTab")
                    {
                        result = DataWorker.DeleteNutrition(SelectedItem as Nutrition);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }

                    if (TabItem.Name == "ToursTab")
                    {
                        result = DataWorker.DeleteTour(SelectedItem as Tour);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }


                }
                else
                    MessageBox.Show(result);
            });
        }


        private RelayCommand refresh;
        public RelayCommand Refresh
        {
            get => refresh ?? new RelayCommand(obj =>
            {
                Window window = obj as Window;
                WindowWorker.Refresh(window);
            });
        }


        private RelayCommand exit;
        public RelayCommand Exit
        {
            get => exit ?? new RelayCommand(obj =>
            {
                Window window = obj as Window;
                WindowWorker.OpenWindow(new MainWindow());
                WindowWorker.CloseWindow(window);
            });
        }

        private RelayCommand print;
        public RelayCommand Print
        {
            get => print ?? new RelayCommand(obj =>
            {
                Window window = obj as Window;
                PrintDialog dialog = new PrintDialog();
                if (dialog.ShowDialog() == true)
                {
                    if (TabItem != null)
                    {
                        if (TabItem.Name == "ClientTab")
                            dialog.PrintVisual(window.FindName("ClientGrid") as Visual, "Отчёт");

                        if (TabItem.Name == "StaffTab")
                            dialog.PrintVisual(window.FindName("StaffGrid") as Visual, "Отчёт");

                        if (TabItem.Name == "HotelTab")
                            dialog.PrintVisual(window.FindName("HotelGrid") as Visual, "Отчёт");

                        if (TabItem.Name == "TourTypeTab")
                            dialog.PrintVisual(window.FindName("TypeGrid") as Visual, "Отчёт");

                        if (TabItem.Name == "CountryTab")
                            dialog.PrintVisual(window.FindName("CountyGrid") as Visual, "Отчёт");

                        if (TabItem.Name == "NutrutionTab")
                            dialog.PrintVisual(window.FindName("NutrGrid") as Visual, "Отчёт");

                        if (TabItem.Name == "DiscountTab")
                            dialog.PrintVisual(window.FindName("DiscGrid") as Visual, "Отчёт");

                        if (TabItem.Name == "ToursTab")
                            dialog.PrintVisual(window.FindName("ToursGrid") as Visual, "Отчёт");
                    }
                    else
                    {
                        MessageBox.Show("Ничего не выбрано");
                    }
                   
                }
            });
        }

        private RelayCommand changeStatus;

        public RelayCommand ChangeStatus
        {
            get => changeStatus ?? new RelayCommand(obj =>
            {
                Window window = obj as Window;
                string result = "Выберите тур из списка";
                if ((TabItem != null && SelectedItem != null))
                {
                    if (TabItem.Name == "ToursTab")
                    {
                        result = DataWorker.ChangeTourStatus(SelectedItem as Tour);
                        MessageBox.Show(result);
                        WindowWorker.Refresh(window);
                    }
                }
                else
                {
                    MessageBox.Show(result);
                }
            });
        }

        private RelayCommand calculatePrice;
        public RelayCommand CalculatePrice
        {
            get => calculatePrice ?? new RelayCommand(obj =>
            {
                if (!string.IsNullOrEmpty(ClientFio)
                    && !string.IsNullOrEmpty(CountryName)
                    && !string.IsNullOrEmpty(HotelName)
                    && !string.IsNullOrEmpty(NutritionName)
                    && !string.IsNullOrEmpty(TourTypeType)
                    && !string.IsNullOrEmpty(DiscountName)
                    && !string.IsNullOrEmpty(PersonCount)
                    && !string.IsNullOrEmpty(DaysCount)
                    && int.TryParse(PersonCount, out int personResult)
                    && int.TryParse(DaysCount, out int daysResult)
                    && personResult > 0
                    && daysResult > 0)
                {


                    double temp = (Hotel.PriceByNight * int.Parse(DaysCount)) + (Nutrition.PriceByDay * int.Parse(DaysCount)) + (Country.FlyPrice * 2) + TourType.Price;
                    double agencyPrice = temp * 0.3 + temp;
                    if (Discount.Percent != 0)
                        agencyPrice = agencyPrice - (agencyPrice * (Discount.Percent / 100.0));

                    MessageBox.Show($"Чистая стоимость: {Math.Round(temp, 2) }\nНаценка компании: {Math.Round(temp * 0.3, 2)}\nИтоговая стоимость: {Math.Round(agencyPrice, 2)}");
                }
                else
                {
                    MessageBox.Show("Заполните все поля корректными данными");
                }
            });
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}