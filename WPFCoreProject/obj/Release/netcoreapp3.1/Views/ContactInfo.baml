   M S B A M L   `   `   `  ���� K  GWPFCoreProjectUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFCoreProjectUI.ViewsWPFCoreProjectUI.Views  (    "WPFCoreProjectUI.Views.ContactInfo   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:WPFCoreProjectUI.Views       � Title$  ContactInfo��$	��250��$	��400�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ NoResize=� � AllowsTransparency$
 True��
������ .���  � RowDefinitions �� $
��1.5* ��� $��6* ��� $��1* � � ColumnDefinitions �� $
��0.3* ��� $��1* ��� $��1* ��� $
��0.3* �.+��� $��4��$��3�� �� CornerRadius$ 	0,0,10,10������ -   contactInfoBackgroundImage�� �� ImageSource$. (/Pictures/Auction_house_background_2.jpg���� -   	 ��Name$	 contactInfoExitButton��$��0��$��3�����	#FF770000���	#FFD38D0E$��X�����	#FFD38D0E$��22��$��22��$��2q�$��	20,0,0,15q�$
��Bold"�
 � 	Resources
  �� 
TargetType �� Property �� Value��%:   '��       �� " ��.���  �@��CornerRadius$ 20���� -    ��Name$  contactInfoHeaderTextblock��$��0��$��1��$��2��$��Contact��
������ ���	#FFD38D0E$
��Bold"�$��30(�$
��Left=�$��Center=��� -    ��Name$ contactInfoStackPanel��$��1��$��1��$��2��.+�]� $��35��$��0,25,0,0q�.+��� -   $" contactInfoUsernameTextblock��$	��120��$��	Username:�����	#FFD38D0E �� TextAlignment$ Center=�$��Center=�$
��Left=�$
��Bold"�$��20(�$��0,0,0,0q��� ���	#FFD38D0E$ 8��$��0q�$��30��$��0,0,0,0q�._��� -    ��Name$  contactInfoUsernameTextbox��
������ ���	#FF770000$
��Bold"�$��Center=�$��15(�
������  �� 
IsReadOnly$
 True��.��]� $��35��$��0,10,0,0q�.+��� -   $ contactInfoTextblock��$	��120��$��Email:�����	#FFD38D0E$ Center=�$��Center=�$
��Left=�$
��Bold"�$��20(�$��0,0,0,0q��� ���	#FFD38D0E$ 8��$��0q�$��30��$��0,0,0,0q�._��� -   $ contactInfoEmailTextbox��
������ ���	#FF770000$
��Bold"�$��Center=�$��15(�
������ $
 True��.��]� $��35��$��0,10,0,0q�.+��� -	   $ contactInfoPhoneTextblock��$	��120��$��Phone:�����	#FFD38D0E$ Center=�$��Center=�$
��Left=�$
��Bold"�$��20(�$��0,0,0,0q��� ���	#FFD38D0E$ 8��$��0q�$��30��$��0,0,0,0q�._��� -
   $ contactInfoPhoneTextbox��
������ ���	#FF770000$
��Bold"�$��Center=�$��15(�
������ $
 True��.��