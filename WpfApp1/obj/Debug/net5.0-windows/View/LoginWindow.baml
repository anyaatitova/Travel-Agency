   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5	   	       WpfApp1.View.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.2.0.2581, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /	viewModelclr-namespace:WpfApp1.ViewModel  5	   	   -   5        $��	LogWindow��5   	     � Title$  
MainWindow��5   	   $	��720��6   $
��1280��6)      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      "   WpfApp1.ViewModel.DataManage  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      �� 5      $��70 �6   �� 5      $��70 �6   �� 5      $��70 �6   �� 5      $	��100 �6   .+�5!   
   �� $��1��6   $ ��Вход в систему��5"      $��Center=�5#      $��Center=�5$       $  MaterialDesignHeadline2TextBlock#��[ 5%      $��72��6N   $	��420��6Z   �� 5'   
   -   5         ��Name$ LoginBox��5(      $��3��5'      $��Center=�5)      $��Center=�5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��5+       % !MaterialDesignFloatingHintTextBox#��[ 5,      $��50��5.      $	��500��5/      ��5-      �� *Login+5/      �� 51   
   -   5        	 ��Name$	 DeliveryType��57      $��2��51      $��Center=�52      $��50��53      $	��500��54      -  'MaterialDesignThemes.Wpf.ComboBoxAssist
   ShowSelectedItem$

 True��55      $ Должность��56        MaterialDesignComboBox#��[ 59       �� Text 58      �� *
Position+.@�5:      ��  $  MaterialDesignSubtitle1TextBlock#��[ 6   Администратор6a   �� 5;      #��[ 6   Турагент6\   5<      �� 5>   
   -   5        $ PasswordBox��5?      $��4��5>      $��Center=�5@      $��Center=�5A      $ Пароль��5B      #��[ 5C      $	��500��5D      $��50��5F       � Cursor$ IBeam��6   ��5E      �� *
Password+5F      �� 5G   
   $��5��6   $��
Войти��5H      $��Center=�5I      $��Center=�5J      $	��500��5K      $��32��6    # MaterialDesignRaisedLightButton#���  5M      $
 Hand��5N   D   ��5L      �� *
OpenWindow+��5N      ��  �� ElementName$ 	LogWindow��6D   5O      5P      