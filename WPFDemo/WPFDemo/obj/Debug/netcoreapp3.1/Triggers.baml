   M S B A M L   `   `   `  ����B  >WPFDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFDemoWPFDemo  5   	       WPFDemo.Triggers   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFDemo     5   	     � Title$  Triggers��5   	   $	��450��6   $	��800��6'   .��5	      �� .+�5   
   �� $��This is Event Trigger��6   $��Center=�62   
��� � �$��40(�6b   $��segoe UI light)�6p   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      :� 5       :� RoutedEvent$ 
MouseEnter��6'   [�5      �� 5   "   .��5   &   �� .��5   *   W�  g� Duration$ 	0:0:0.500D�6:    �� TargetProperty$ FontSize�6O   	 W� To 726t   5   '   5   #   5      :� 5      $ 
MouseLeave��6'   [�5      �� 5   "   .��5   &   �� .��5   *   W� $ 	0:0:0.500D�6:   $ FontSize�6O    406t   5   '   5   #   5!      5#      5%      �� 5&   
   $��This is Property Trigger��6   $��Center=�64   $��40(�6Q   $��segoe UI light)�6_   ��5'      �� 5(      " ��6   .�5)      ��  �� Property � �� �� Value
 � � �6C    5*      P� 5+      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��69   . �5,      ��  � ��
 �  ��6I   �� 5-       � ��$ 	underline{�6@   6T   5.      50      52      �� 55   
   $��Center=�6   $��20q�62   .+�56   
   �� -   5        $	��trg��56      $��Center=�6   $'��!Check the box to see Data Trigger��6@   $��segoe UI light)�6l   $��28(�6�   6�   �� 57   
   ��58      �� 59      " ��6   .�5:      ��  � ��$ Normal Text��6-   6C   �� 5;       � ��
 �  ��6A   �� 5<       � ��$ 30(�61   6>    5=      �� 5>       �� Binding 6&   ��  �� ElementName$	 trg�� �� Path$ 	IsChecked� �� Value True6\   .a�5?      ��  � ��$ Text from Data Trigger��65   6V   �� 5@       � ��
 � � �6K   �� 5A       � ��$ 30(�69   6F   5B      5D      5F      �� 5H      $&�� Is controlled by external source��6   ��5I      �� 5J      " ��6   .�5K      ��  � y�$ Hidden=�67   �� 5L       � ��$ 23(�65    5M      �� 5N       6*   �� $	 trg��$ 	IsChecked� True6^   .a�5O   "   ��  � y�$ Visible=�6?   5P      5R      5T      5U      �� 5V   
   -   5        $��Go Back��5V      $��segoe UI light)�6#   $��30��6?   $	��120��6K   6W   5W      5X      