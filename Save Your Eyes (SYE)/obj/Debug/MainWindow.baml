   M S B A M L   `   `   `  ����>  :LAP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LAPLAP  5   	   H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	      /clr-namespace:LAP.PropertiesLAP.Properties  5          LAP.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:LAP     5   	   OMetroUI;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	      U QMaterialDesignThemes.Wpf, Version=2.3.1.931, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullD
MaterialUI1http://materialdesigninxaml.net/winfx/xaml/themes   5
      /
propertiesclr-namespace:LAP.Properties   5      -   5        $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5         MaterialDesignBody#���   5      $��Medium"�5      $��14(�5      $	��971��5      $	��600��5        � WindowStartupLocation$  CenterOwner=�5      ���	#FF158576$��1q�5      (  "MahApps.Metro.Controls.MetroWindow   SaveWindowPosition .    ShowIconOnTitleBar .  !   ShowSystemMenuOnRightClick .     ShowTitleBar .     	GlowBrush �	#FF34AC86 � Icon$ Media/icon.ico��5   -    � WindowState$ 	Maximized=�6C       NonActiveWindowTitleBrush 5      Z� 	 � TaskbarItemInfo	 5"      *  $System.Windows.Shell.TaskbarItemInfo  5#   
   
   WindowTitleBrush
 5&      �� 5'   
     
Foreground �� Color# �  6      TitleForeground 5*      �� 5+   
   # �  6   ��5.      �� 5/   
   # �  6   ��52      �� 53   
   $ 	#FFECECEC��6   .��56      � -   5        $��grdMain��56      ��57   
   �� 58       �� ImageSource$ Media/3.png��6    � RowDefinitions 5:   
   �� 5;      $��30 �6   �� 5<      �� 5=      $��40 �6    � ColumnDefinitions 5?   
   �� 5@      $��50 �6   �� 5A      �� 5B      �� 5C      $��50 �6   .+�5F   
   �� $��MarkoDev Studio��5G      $��2��5H      $��	0,0,10,10q�5I      $��2��5J      $��2��5K      $��17��5L      $��Bottom=�5M      $��Right=�5N      $	��112��5O      $��Normal"�5P      '  !MaterialDesignThemes.Wpf.PopupBox  5R   
   $
��Left=�5S      $	��150��5T      ���#3e3e3e   PopupContent. 5V      �� .+�5W      m� $��Language��6    m� Icon 5X      '  !MaterialDesignThemes.Wpf.PackIcon  5Y      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.931, Culture=neutral, PublicKeyToken=null]]   Kind$ 	Translate=�6.   .@�5\      m� $��English��6   m� 5]      $��Русский��6   m� 5^      $��Українська��6   5_      m� 5a      $��Settings��6    5b        5c      $ Settings=�6.   5e      m� 5g      -   5        $��Log Out��5g       5h        5i      $ Logout=�6.   5k      5l      5m      �� 5o   
   -   5        $��txtHello��5o      $��Normal"�6$   $��1��68   $��1��6H   
�������$��38(�6h   $
��Wrap=�6v   $��100, 0, 0, 0q�5p      $��Center=�6*    � 5r   
   -   5          �Name$ LoginPageUI��5s        � Source$ UI/LoginPage.xaml?�5t      $��
0, 0, 0, 0q�5u      $y�Visible=�5v      {�. $��Center=�5x      $��2��5y      $��1��5z       � 5|   
   -   5        $ 
MainPageUI��5}      $ UI/MainPage.xaml?�5~      $y�Hidden=�5      {�.  $��Center=�5�      $��0��5�      $��4��5�      $��1��5�      $��2��5�      5�      5�      