   M S B A M L   `   `   `  ����H  DcitizenHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:citizenHelpercitizenHelper  5   	   (    "citizenHelper.Events_Announcements   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:citizenHelper     5   	     � Title$  Events_Announcements��5   	   $	��450��6&   $	��800��63    � Icon$ 	/coat.png��6@    � WindowStartupLocation$ CenterScreen=�5	   	   ��5      �� 5   
    �� ImageSource$ 
/back.jpeg��6    �� Opacity$	 0.7Q�6.   .��5      � 
������� J� Opacity$	 0.9Q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $$��Local Events and Announcements��6!   $��24(�5      $
��Bold"�6"   $��Center=�64   $��10q�6Q   �� 5!   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5"      �� $��	Category:��6   $��Center=�6(   �� 5#      -   5         ��Name$ CategoryComboBox��5#      $	��150��61   $	��5,0q�6=   �� 5%      $��Date:��6   $��Center=�6$   (  "System.Windows.Controls.DatePicker  5&      -   5        	  Name$	 
DatePicker��5&      $	��150��6-   $	��5,0q�69   �� 5(      -   5        $��Search��5(      $
��10,0q�6A   5)      �� 5,   
   -   5        
 ��Name$
 EventsListView��5,       $��2��6   $��10q�68    �� View 5-      �� 5.      .P�5/      �� $��Title��6%    �� Width$	 200��6[    �� DisplayMemberBinding 64   �� *Title+6[   �� 50      $��Category��6%   $	 100��6a    67   �� *
Category+6a   �� 51      $
��Date��6%   $	 150��6Y    63   �� *Date+6Y   �� 52      $��Description��6%   $	 300��6g    6:   �� *Description+6g   53      55      �� 58   
   $��3��6   $��10q�6"   .+�59      �� $��Recommended for You��6   $��18(�63   $
��Bold"�6A   $��0,10,0,5q�6S   �� 5:      -   5        $
 RecommendationsListView��5:      $	��150��68    5;      �� 5<      .P�5=      �� $��Title��6)   $	 200��6_    68   �� *Title+6_   �� 5>      $��Category��6)   $	 100��6e    6;   �� *
Category+6e   �� 5?      $
��Date��6)   $	 150��6]    67   �� *Date+6]   5@      5B      5C      5E      5F      