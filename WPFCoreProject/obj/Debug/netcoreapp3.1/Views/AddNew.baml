   M S B A M L   `   `   `  ����K  GWPFCoreProjectUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFCoreProjectWPFCoreProject  5   	   !    WPFCoreProject.Views.AddNew   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFCoreProject     5   	     � Title$  AddNew��5   	   $	��250��6   $	��200��6%    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency$
 True��5   	   
������ .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $
��0.6* �6   �� 5      $
��0.6* �6   �� 5      $
��0.6* �6   �� 5      $
��0.4* �6    � ColumnDefinitions 5   
   �� 5      $��0.03* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6   �� 5      $��0.03* �6   .+�5   
   �� $��5��6   $��4��5        �� CornerRadius$ 	0,0,10,10��5!      ��5"      �� 5#      -   5        addNewBackgroundImage�� j� Stretch$
 Fill=�5#   <   	 �� ImageSource$.	 (/Pictures/Auction_house_background_2.jpg��5$      5&      5(      �� 5*   
   $��1��6   $��4��5+      $��2��5,      $��30��5-      $	��120��5.      ._�50      �� -   5        
 ��Name$
 addNewAddButton��50      ���	#FF770000���	#FFD38D0E$��2q�53      $��Add New Item��54      ���	#FFBAACAC$��15(�56      $
��Bold"�57       � 	Resources 59       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   '��       �� 5:      " ��6   .�5;      ��  �@��CornerRadius$ 10��69    5<      P� 5=       �@J�IsMouseOver$
 True��6=   . �5>   "   ��  � ��$ 13(�6D   5?      5A      5B      5C      5D      �� 5F   
   $��2��6   $��1��5G      $��0��5H      $��Center=�5I      $��0,15,0,0q�5J      ._�5L      �� -   5         ��Name$ addNewTitleTextBlock��5L      $	��120��5M      $��20��5N      $��Create Auction��5O      ���	#FFD38D0E$��Times New Roman)�5Q      $
��Bold"�5R       �� TextAlignment$ Center=�5S      $��18(�5T      5W      5Y      �� 5[   
   $��2��5\      $��1��5]      $��1��5^      $ 15��5_      ���	#FFD38D0E$��40��5a      $	��160��5b      ._�5e      �� -   5         ��Name$ addNewCategoryTextBox��5e      $��Category��5f      
������ 
������ ���	#FF770000 �� TextAlignment$
 Left=�5j      $��Center=�5k      $��15(�5l      $��Microsoft YaHei UI)�5m      $��Italic$�5n      .��6S   5o      5p      �� 5r   
   $��2��5s      $��1��5t      $��2��5u      $ 15��5v      ���	#FFD38D0E$��40��5x      $	��160��5y      ._�5|      �� -   5        $ addNewNameTextBox��5|      $
��Name��5}      
������ 
������ ���	#FF770000$
 Left=�5�      $��Center=�5�      $��15(�5�      $��Microsoft YaHei UI)�5�      $��Italic$�5�      .��6O   5�      5�      �� 5�   
   $��1��6   $��2��5�      $��3��5�      $ 15��5�      ���	#FFD38D0E$��40��5�      $	��160��5�      ._�5�      �� -   5        $ addNewPriceTextBox��5�      $��Price��5�      
������ 
������ ���	#FF770000$
 Left=�5�      $��Center=�5�      $��15(�5�      $��Microsoft YaHei UI)�5�      $��Italic$�5�      .��6P   5�      5�      �� 5�   
   -   5        $
 addNewExitButton��5�      $��0��5�      $��2��5�      ���	#FF770000���	#FFD38D0E$��X��5�      ���	#FFD38D0E$��20��5�      $��20��5�      $��1q�5�      $
��Bold"�5�      $��8(�5�      $��Right=�5�      $��	0,0,-6,10q�5�       5�      ��%h   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 20��65   5�      5�      5�      5�      5�      5�      