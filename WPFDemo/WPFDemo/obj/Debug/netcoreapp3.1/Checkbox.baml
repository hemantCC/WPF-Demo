   M S B A M L   `   `   `  ����B  >WPFDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFDemoWPFDemo  5   	       WPFDemo.Checkbox   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFDemo     5   	     � Title$  Checkbox��5   	   $	��450��6   $	��800��6'   .��5	      �� .+�5
   
   �� $��Subway��6   $��Center=�6#   
��� � �$��40(�6S   $��segoe UI light)�6a   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      :� 5       :� RoutedEvent$ 
MouseEnter��6'   [�5      �� 5   "   .��5   &   �� .��5   *   W�  g� Duration$ 	0:0:0.500D�6:    �� TargetProperty$ FontSize�6O   	 W� To 726t   5   '   5   #   5      :� 5      $ 
MouseLeave��6'   [�5      �� 5   "   .��5   &   �� .��5   *   W� $ 	0:0:0.500D�6:   $ FontSize�6O    406t   5   '   5   #   5      5!      5#      �� 5$   
   $��Customize you order:��6   $
��Bold"�60   $��
50 30 0 30q�6B   ��5%      �� 5&      " ��6   .�5'      ��  �� Property � �� �� Value
 � � �6C    5(      P� 5)      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��69   . �5*      ��  � ��
 �  ��6I   �� 5+       � ��$ 	underline{�6@   6T   5,      5.      50      �� 52   
   -   5        $��AllCheck��52       d� IsThreeState$
 True��6#   $��50 0 0 0q�67   .��6�   	Check All6�   �� 53   
   $��	70 20 0 0q�6   .+�55      �� -   5        $��Jalapeno��55      $��5q�6'   .��6j   
Jalapeno6t   �� 56      -   5        $��Olives��56      $��5q�6%   .��6h   Olives6p   �� 57      -   5        $��Cucumber��57      $��5q�6'   .��6j   
Cucumber6t   �� 58      -   5        $��Pickel��58      $��5q�6%   .��6h   Pickel6p   59      �� 5:   
   -   5        $��Go Back��5:      $��segoe UI light)�6#   $��30��6?   $	��120��6K   6W   5;      5<      