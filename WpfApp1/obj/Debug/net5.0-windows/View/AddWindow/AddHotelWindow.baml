   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5	   	   +    %WpfApp1.View.AddWindow.AddHotelWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.2.0.2581, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /	viewModelclr-namespace:WpfApp1.ViewModel  5	   	   -   5        $��AddHotelWin��5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��408��6)      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      "   WpfApp1.ViewModel.DataManage  5   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      $��* �6   .+�5!   
   �� -   5         ��Name$ LoginBox��5#      $��0��5"      $��Center=�5$      $��Center=�5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Название��5&       % !MaterialDesignFloatingHintTextBox#��[ 5'      $��50��5)      $	��332��5*      ��5(      �� *	HotelName+5*      �� 5,   
   -   5        	 ��Name$	 DeliveryType��52      $��1��5,      $��Center=�5-      $��50��5.      $	��332��5/      -  'MaterialDesignThemes.Wpf.ComboBoxAssist
   ShowSelectedItem$

 True��50      $ 
Класс��51        MaterialDesignComboBox#��[ 54       �� Text 53      �� *
HotelClass+.@�55      ��  $  MaterialDesignSubtitle1TextBlock#��[ 6   16U   �� 56      #��[ 6   26U   �� 57      #��[ 6   36U   �� 58      #��[ 6   46U   �� 59      #��[ 6   56U   5:      �� 5=   
   -   5        $ PriceBox��5?      $��2��5>      $��Center=�5@      $��Center=�5A      $ Цена��5B      #��[ 5C      $��50��5E      $	��332��5F       � Cursor$ IBeam��6   ��5D      �� *
HotelPrice+5F      �� 5H   
   $��3��6   $��Добавить��5I      $��Center=�5J      $��Center=�5K      $	��332��5L      $��98��6    # MaterialDesignRaisedLightButton#���  5O      $
 Hand��6K   ��5M      ��  �� ElementName$ AddHotelWin����5N      �� *AddNewHotel+5O   K   5P      5Q      