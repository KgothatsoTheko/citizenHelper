   M S B A M L   `   `   `  ����H  DcitizenHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:citizenHelpercitizenHelper  5   	        citizenHelper.ReportStatus   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:citizenHelper     5   	     � Title$  Report Status��5   	   $	��500��5	   	   $	��800��5
   	    � Icon$ 	/coat.png��5   	   ��5      �� 5   
    �� ImageSource$ 
/back.jpeg��6    �� Opacity$	 0.7Q�6.   .��5      � 
������� J� Opacity$	 0.9Q�6   .+�5   
   �� $��20q�6   .+�5      �� $��24(�6   $
��Bold"�6&   $��Report Status��68   $��Center=�6M   $��0,0,0,20q�6j   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0,0,0,20q�6O   .+�5      �� $��Search by ID:��6   $��Center=�61   $��0,0,10,0q�6L   �� 5      -   5        $��SearchTextBox��5      $	��200��6/   $��0,0,10,0q�6;   �� 5      -   5        $��Search��5      $	��100��6*   66   �� 5      -   5        $��Refresh��5      $	��100��6+   $��10,0,0,0q�67   6I   5      &   System.Windows.Controls.DataGrid  5      -   5        $��ReportsDataGrid��5         AutoGenerateColumns$ False��6.      
IsReadOnly$
 True��6J      SelectionMode$ Single=�6\   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Report ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
ReportID+6Y     5!      $
 Location��6)   $ * 6X    6;   �� *
Location+6X     5"      $
 Category��6)   $ * 6X    6;   �� *
Category+6X     5#      $
 Description��6)   $ 2* 6^    6>   �� *Description+6^     5$      $
 Status��6)   $ * 6T    69   �� *Status+6T     5%      $
 Submitted On��6)   $ * 6_    6?   �� *SubmittedOn+6_   5'      5(      5)      5*      