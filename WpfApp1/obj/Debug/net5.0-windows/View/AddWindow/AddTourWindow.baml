   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5	   	   *    $WpfApp1.View.AddWindow.AddTourWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.2.0.2581, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /	viewModelclr-namespace:WpfApp1.ViewModel  5	   	   -   5        $��
AddTourWin��5   	     � Title$  
MainWindow��5   	   $	��760��6   $	��680��6)      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      "   WpfApp1.ViewModel.DataManage  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5       �� 5!      $	��100 �6   .+�5$   
   �� .+�5%      ��  �� DisplayMemberPath$	 Fio��5'      -  'MaterialDesignThemes.Wpf.ComboBoxAssist	   ShowSelectedItem$
	 True��5(      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Клиент��5)      $��20 20 20 20q�5*       " MaterialDesignOutlinedComboBox#���  5,      ��5%      �� *
AllClients+ �� SelectedItem 5&      �� *Client+ �� SelectedValue 5+      ��  �� Path$ 	ClientFio�5-      �� 50      $
 Name��52      $
	 True��53      $
 Страна��54      $��20 20 20 20q�55      #���  57      ��50      �� *AllCountries+ 51      �� *	Country+ 56      �� $ CountryName�58      �� 5:      $
 Name��5;      $
	 True��5=      $
 
Отель��5>      $��20 20 20 20q�5?      #���  5A      ��5:      �� *	AllHotels+ 5<      �� *Hotel+ 5@      �� $ 	HotelName�5B      �� 5D      $
 Name��5E      $
	 True��5G      $
 Питание��5H      $��20 20 20 20q�5I      #���  5K      ��5D      �� *AllNutritions+ 5F      �� *	Nutrition+ 5J      �� $ NutritionName�5L      �� 5N      $
 Type��5O      $
	 True��5Q      $
 Тип тура��5R      $��20 20 20 20q�5S      #���  5U      ��5N      �� *AllTourTypes+ 5P      �� *
TourType+ 5T      �� $ TourTypeType�5V      �� 5X      $
 Name��5Y      $
	 True��5[      $
 Скидка��5\      $��20 20 20 20q�5]      #���  5_      ��5X      �� *AllDiscounts+ 5Z      �� *
Discount+ 5^      �� $ DiscountName�5`      (  "System.Windows.Controls.DatePicker  5c         IsDropDownOpen$ False��5d      $��20 20 20 20q�5e         SelectedDateFormat$ Short=�5f      $%
 Дата отправления��5g       $  MaterialDesignOutlinedDatePicker#���  5h      $��50��5i         IsTodayHighlighted$
 True��5k         FirstDayOfWeek$ Monday=�5l         SelectedDate 5j      �� *DepartureDate+5l      5n      �� 5p      $��1��5q   	   .+�5s   
   �� $)
 #Коливество человек��5t       ! MaterialDesignOutlinedTextBox#��[ 5u      $��50��5w      $��20 20 20 20q�5x       � Cursor$ IBeam��5y      ��5v      �� *PersonCount+5y      �� 5{   
   $#
 Количество дней��5|      #��[ 5}      $��50��5      $��20 20 20 20q�5�      $ IBeam��5�      ��5~      �� *	DaysCount+5�      5�      �� 5�   
   $��1��5�      $��1��5�      $��Добавить��5�      $��Bottom=�5�      $��Center=�5�      $	��176��5�      $��40��6      MaterialDesignOutlinedButton#���  5�      $��0,0,0,20q�5�      $
 Hand��5�      ��5�      �� *
AddNewTour+��5�      ��  �� ElementName$ 
AddTourWin��5�      �� 5�   
   $��1��5�      $��0��5�      $+��%Расчитать стоимость��5�      $��Bottom=�5�      $��Center=�5�      $	��176��5�      $��40��6   #���  5�      $��0,0,0,20q�5�      $
 Hand��5�      ��5�      �� *CalculatePrice+��5�      �� $ 
AddTourWin��5�      5�      5�      