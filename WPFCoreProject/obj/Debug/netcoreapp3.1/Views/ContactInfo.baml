   M S B A M L   `   `   `  ����K  GWPFCoreProjectUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFCoreProjectUI.ViewsWPFCoreProjectUI.Views  5   	   (    "WPFCoreProjectUI.Views.ContactInfo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WPFCoreProjectUI.Views     5   	     � Title$  ContactInfo��5   	   $	��250��6   $	��400��6*    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterOwner=�5
   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency$
 True��5   	   
������ .��5      �  � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��6* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.3* �6   .+�5   
   �� $��4��6   $��3��5       �� CornerRadius$ 	0,0,10,10��5      ��5       �� 5!      -   5        contactInfoBackgroundImage�� �� ImageSource$. (/Pictures/Auction_house_background_2.jpg��5!   A   5#      �� 5%   
   -   5        	 ��Name$	 contactInfoExitButton��5%      $��0��60   $��3��5&      ���	#FF770000���	#FFD38D0E$��X��5)      ���	#FFD38D0E$��22��5+      $��22��5,      $��2q�5-      $��	20,0,0,15q�5.      $
��Bold"�5/      
 � 	Resources
 50       �� 
TargetType �� Property �� Value��%h   '��       �� 51      " ��6   .�52      ��  �@��CornerRadius$ 20��65   54      55      56      58      �� 5:   
   -   5         ��Name$  contactInfoHeaderTextblock��5:      $��0��68   $��1��5;      $��2��5<      $��Contact��5=      
������ ���	#FFD38D0E$
��Bold"�5@      $��30(�5A      $
��Left=�5B      $��Center=�5C      5F      �� 5H   
   -   5         ��Name$ contactInfoStackPanel��5H      $��1��64   $��1��5I      $��2��5J      .+�5L      ]� $��35��6   $��0,25,0,0q�5M      .+�5N      �� -   5        $" contactInfoUsernameTextblock��5N      $	��120��6B   $��	Username:��5O      ���	#FFD38D0E �� TextAlignment$ Center=�5Q      $��Center=�5R      $
��Left=�5S      $
��Bold"�5T      $��20(�5U      $��0,0,0,0q�5V      5X      �� 5Z      ���	#FFD38D0E$ 8��5[      $��0q�5\      $��30��5]      $��0,0,0,0q�5^      ._�5_      �� -   5         ��Name$  contactInfoUsernameTextbox��5_      
������ ���	#FF770000$
��Bold"�5a      $��Center=�5b      $��15(�5c      
������  �� 
IsReadOnly$
 True��5e      .��60   5f      5g      5h      ]� 5j      $��35��6   $��0,10,0,0q�5k      .+�5l      �� -   5        $ contactInfoTextblock��5l      $	��120��6:   $��Email:��5m      ���	#FFD38D0E$ Center=�5o      $��Center=�5p      $
��Left=�5q      $
��Bold"�5r      $��20(�5s      $��0,0,0,0q�5t      5v      �� 5x      ���	#FFD38D0E$ 8��5y      $��0q�5z      $��30��5{      $��0,0,0,0q�5|      ._�5~      �� -   5        $ contactInfoEmailTextbox��5~      
������ ���	#FF770000$
��Bold"�5�      $��Center=�5�      $��15(�5�      
������ $
 True��5�      .��60   5�      5�      5�      ]� 5�      $��35��6   $��0,10,0,0q�5�      .+�5�      �� -	   5        $ contactInfoPhoneTextblock��5�      $	��120��6?   $��Phone:��5�      ���	#FFD38D0E$ Center=�5�      $��Center=�5�      $
��Left=�5�      $
��Bold"�5�      $��20(�5�      $��0,0,0,0q�5�      5�      �� 5�      ���	#FFD38D0E$ 8��5�      $��0q�5�      $��30��5�      $��0,0,0,0q�5�      ._�5�      �� -
   5        $ contactInfoPhoneTextbox��5�      
������ ���	#FF770000$
��Bold"�5�      $��Center=�5�      $��15(�5�      
������ $
 True��5�      .��60   5�      5�      5�      5�      5�      5�      