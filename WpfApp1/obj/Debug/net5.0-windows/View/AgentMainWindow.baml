   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5	   	   "    WpfApp1.View.AgentMainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.2.0.2581, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /	viewModelclr-namespace:WpfApp1.ViewModel  5	   	   -   5        $��AgentMianWin��5   	     � Title$  
MainWindow��5   	   $	��720��6   $	��600��6)      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignDarkBackground#���  5   	     MaterialDesignFont#���  5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      "   WpfApp1.ViewModel.DataManage  5   
   .��5      � .+�5   
   �� $��Добавить тур��5      $	��Top=�5      $��Center=�5      $	��478��5      $	��149��6      MaterialDesignOutlinedButton#���  5       $��
10,20,10,0q�6D    � Cursor$
 Hand��6X   ��5      �� *OpenAddNewTourWindow+��5      ��  �� ElementName$ AgentMianWin��5    X   �� 5"   
   $��
Выйти��5#      $��Bottom=�5$      $��Center=�5%      $	��176��5&      $��40��6   #���  5)      $��0,0,0,20q�6H   $
 Hand��6Z   ��5'      �� *Exit+��5(      �� $ AgentMianWin��5)   Z   5*      5+      