   M S B A M L   `   `   `  ����H  DcitizenHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:citizenHelpercitizenHelper  5   	       citizenHelper.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:citizenHelper     5   	     � Title$  	Main Menu��5   	   $	��500��6   $	��800��6+    � Icon$ 	/coat.png��6:    � WindowStartupLocation$ CenterScreen=�5	   	   ��5      �� 5   
    �� ImageSource$ 
/back.jpeg��6    �� Opacity$	 0.7Q�6.   .��5      � 
������� J� Opacity$	 0.9Q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"   $
��Left=�62   $��10q�6M   .+�5      �� $��Select Language:��6   $��14(�60   �� 5      -   5        .@�5      �� $��English��6   
 � Tag$ en��61   �� 5      $��	Afrikaans��6   $ af��63   �� 5      $
��Zulu��6   $ zu��6.   �� 5      $��Xhosa��6   $ xh��6/   5       5!      �� 5$   
   $��0��6   $��0��6"   $��2��62   $��Center=�6F   $��20q�6c   .+�5%      �� $��24(�6   $��Center=�6&   $
��Wrap=�6C      Welcome#���   6W   �� 5&      6   5'      5(      �� 5+   
   $��1��6   $��0��6"   $��20q�62   .+�5,      ��   ListOfReports#���  6   $��18(�6?   $��Center=�6M   $
��Wrap=�6j   $��0,0,0,10q�6~   �� 5-      6   5.      �� 5/      $
��Auto=�6   $��Disabled=�6>   $	��205��6g   .��50      �� -   5        $��ReportsListBox��50      $��10q�60   ��51      �� 52      .R�53      �� .+�54   "   �� $
��Bold"�6F   ��6,   �� *
Location+6F   �� 55   "   ��6,   �� *
Category+�� 56   "   $
��Wrap=�6I   ��6,   �� *Description+6I   �� 57   "   $	��200��6E   $	��100��6Q   $��10q�6^   ��6(   �� *	ImagePath+6^   58      59      5;      5<      5=      �� 5@   
   $��1��6   $��1��6$   $��20q�64   $��Hidden=�6@   .��5A      � $��Stretch=�6   $	��Top=�66   .+�5C      �� -   5        $	��150��5C      $��10q�6)   .+�5D      �� $��/undraw_News_re_6uub.png��6   $	��150��6>   $
��Auto��6J   �� 5E        ReportIssue#���  6    $��16(�6E   $��Center=�6S   $
��Wrap=�6p   �� 5F      6!   5G      5H      �� 5K      -   5        $	��150��5K      $��10q�6)   .+�5L      �� $ ��/undraw_Events_re_98ue.png��6   $	��150��6@   $
��Auto��6L   �� 5M        AnnouncementsEvents#���  6    $��16(�6M   $��Center=�6[   $
��Wrap=�6x   �� 5N      6!   5O      5P      �� 5S      -   5        $	��150��5S      $��10q�6)   .+�5T      �� $#��/undraw_online_stats_0g94.png��6   $	��150��6C   $
��Auto��6O   �� 5U        RequestStatus#���  6    $��16(�6G   $��Center=�6U   $
��Wrap=�6r   �� 5V      6!   5W      5X      5Y      5Z      5[      5\      