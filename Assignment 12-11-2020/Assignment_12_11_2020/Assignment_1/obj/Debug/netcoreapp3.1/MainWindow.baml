   M S B A M L   `   `   `  ����G  CAssignment_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Assignment_1Assignment_1  5   	       Assignment_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Assignment_1     5   	      vm  � DataContext#  [  5   	    � Title$ 
MainWindow��5	   	   $	��450��5
   	   $	��550��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �� ���	#FF366C99.+�5   
   �� $��Registered Employees��6   $��0 0 0 25q�6/   $��segoe ui light)�6A   
�������$��45(�6p   $��Center=�6~   �� 5   
   -   5        $��Edit Employee��5      $��0��5      $	��120��5      $��30��5      $��Right=�5      $��10q�5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
EmployeeDG��5         AutoGenerateColumns$ False��6{   $��14(�6�      CanUserAddRows$ False��6�      
IsReadOnly$
 True��6�   ��6'   �� *	Employees+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+$ TwoWay=�$ PropertyChanged=�6�     5      $

 Name��6%   $ 2* 6~    63   �� *Name+$ TwoWay=�$ PropertyChanged=�6�     5      $
 Contact Number��6%   $ 2* 6�    6=   �� *	Contact+$ TwoWay=�$ PropertyChanged=�6�     5      $
 Email��6%   $ 2* 6�    64   �� *Email+$ TwoWay=�$ PropertyChanged=�6�   5      5      5       