   M S B A M L   `   `   `  ���� K  GWPFCoreProjectUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFCoreProjectWPFCoreProject  !    WPFCoreProject.Views.AddNew   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:WPFCoreProject       � Title$  AddNew��$	��250��$	��200�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency$
 True��
������ .���  � RowDefinitions �� $
��0.4* ��� $
��0.6* ��� $
��0.6* ��� $
��0.6* ��� $
��0.4* � � ColumnDefinitions �� $��0.03* ��� $
��0.4* ��� $
��0.4* ��� $��0.03* �.+��� $��5��$��4�� �� CornerRadius$ 	0,0,10,10������ -   addNewBackgroundImage�� j� Stretch$
 Fill=�	 �� ImageSource$.	 (/Pictures/Auction_house_background_2.jpg���� $��1��$��4��$��2��$��30��$	��120��._��� -   
 ��Name$
 addNewAddButton�����	#FF770000���	#FFD38D0E$��2q�$��Add New Item�����	#FFBAACAC$��15(�$
��Bold"� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%{   '��       �� " ��.���  �@��CornerRadius$ 10�� P�  �@J�IsMouseOver$
 True��. ���  � ��$ 13(��� $��2��$��1��$��0��$��Center=�$��0,15,0,0q�._��� -    ��Name$ addNewTitleTextBlock��$	��120��$��20��$��Create Auction�����	#FFD38D0E$��Times New Roman)�$
��Bold"� �� TextAlignment$ Center=�$��18(��� $��2��$��1��$��1��$ 15�����	#FFD38D0E$��40��$	��160��._��� -    ��Name$ addNewCategoryTextBox��$��Category��
������ 
������ ���	#FF770000 �� TextAlignment$
 Left=�$��Center=�$��15(�$��Microsoft YaHei UI)�$��Italic$�.���� $��2��$��1��$��2��$ 15�����	#FFD38D0E$��40��$	��160��._��� -   $ addNewNameTextBox��$
��Name��
������ 
������ ���	#FF770000$
 Left=�$��Center=�$��15(�$��Microsoft YaHei UI)�$��Italic$�.���� $��1��$��2��$��3��$ 15�����	#FFD38D0E$��40��$	��160��._��� -   $ addNewPriceTextBox��$��Price��
������ 
������ ���	#FF770000$
 Left=�$��Center=�$��15(�$��Microsoft YaHei UI)�$��Italic$�.���� -   $
 addNewExitButton��$��0��$��2�����	#FF770000���	#FFD38D0E$��X�����	#FFD38D0E$��20��$��20��$��1q�$
��Bold"�$��8(�$��Right=�$��	0,0,-6,10q� ��%:   '��       �� " ��.���  �@��CornerRadius$ 20��