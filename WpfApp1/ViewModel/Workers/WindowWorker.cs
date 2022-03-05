using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.View;
using WpfApp1.View.AddWindow;


namespace WpfApp1.ViewModel.Workers
{
    public static class WindowWorker
    {
        public static void OpenWindow(Window window)
        {
            if(window is AgentMainWindow)
                SetCenterPosAndOpen(window);

            if(window is AdminMainWindow)
                SetCenterPosAndOpen(window);

            if (window is AddHotelWindow)
                SetCenterPosAndOpen(window);

            if (window is MainWindow)
                SetCenterPosAndOpen(window);

            if (window is AddNewCountryWindow)
                SetCenterPosAndOpen(window);

            if (window is AddNutritionWindow)
                SetCenterPosAndOpen(window);

            if(window is AddClientWindow)
                SetCenterPosAndOpen(window);

            if(window is AddStaffWindow)
                SetCenterPosAndOpen(window);

            if(window is AddTourTypeWindow)
                SetCenterPosAndOpen(window);

            if(window is AddDiscountWindow)
                SetCenterPosAndOpen(window);

            if(window is AddTourWindow)
                SetCenterPosAndOpen(window);

        }

        public static void CloseWindow(Window window)
        {
            window.Close();
        }

        public static void Refresh(Window window)
        {
            window.DataContext = null;
            window.DataContext = new DataManage();
        }

        private static void SetCenterPosAndOpen(Window window)
        {
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }

    }
}
