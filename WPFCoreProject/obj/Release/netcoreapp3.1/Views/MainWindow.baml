   M S B A M L   `   `   `  ���� K  GWPFCoreProjectUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFCoreProjectWPFCoreProject  %    WPFCoreProject.Views.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:WPFCoreProject       � Title$  MainMenu��$	��600��$	��700�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency$
 True��
������ .���  � RowDefinitions �� $��1* ��� $��6* ��� $��1* ��� $��1* ��� $��1* � � ColumnDefinitions �� $
��0.3* ��� $��2* ��� $��2* ��� $
��0.3* �.+��� $��5��$��4�� �� CornerRadius$ 	0,0,10,10������ -   mainWindowBackgroundImage�� j� Stretch$
 Fill=�	 �� ImageSource$.	 (/Pictures/Auction_house_background_2.jpg���� -   
 ��Name$
 mainMenuSearchButton��$��4��$��1�����	#FF770000���	#FFD38D0E$��55��$	��200��$��4q�$��Search�����	#FFBAACAC$��22(�$
��Bold"�$
��Left=� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%{   '��       �� " ��.���  �@��CornerRadius$ 10�� P�  �@J�IsMouseOver$
 True��. ���  � ��$ 20(��� -   $
 mainWindowContactButton��$��4��$��1�����	#FF770000���	#FFD38D0E$��55��$	��100��$��4q�$��Contact�����	#FFBAACAC$��22(�$
��Bold"�$��Right=� ��%{   '��       �� " ��.���  �@��CornerRadius$ 10�� P�  �@J�IsMouseOver$
 True��. ���  � ��$ 20(��� -   $
 mainMenuAddNewButton��$��4��$��2�����	#FF770000���	#FFD38D0E$��55��$	��200��$��4q�$��Add New�����	#FFBAACAC$��22(�$
��Bold"�$
��Left=� ��%{   '��       �� " ��.���  �@��CornerRadius$ 10�� P�  �@J�IsMouseOver$
 True��. ���  � ��$ 20(��� -   $
 mainMenuRemoveButton��$��4��$��2�����	#FF770000���	#FFD38D0E$��55��$	��100��$��4q�$��Remove�����	#FFBAACAC$��22(�$
��Bold"�$��Right=� ��%{   '��       �� " ��.���  �@��CornerRadius$ 10�� P�  �@J�IsMouseOver$
 True��. ���  � ��$ 20(�]� $��2��$��1��$��Center=�$��60��.+��� -    ��Name$ mainMenuAvgValueTextBlock��$��AVG. VALUE:��$��35��$	��140��
������  �� TextAlignment$ Center=�$��Calibri)�$��26(�$��Center=����	#FFD38D0E$
��Bold"�$��1,0,0,0q��� $��55��$	��140�����	#FFD38D0E$ 15��$��Right=�$��0,0,0,0q�._��� -    ��Name$ mainMenuAvgValueTextbox��
������ 
������  �� TextAlignment$ Center=�$��Center=�$��22(�$��Microsoft YaHei UI)����	#FF770000 �� 	MaxLength$ 6�� �� 
IsReadOnly$
 True��.��]� $��2��$��2��$��Center=�$��60��.+��� -   $ mainMenuMinValueTextBlock��$��MIN. VALUE:��$��35��$	��140��
������ $ Center=�$��Calibri)�$��26(�$��Center=����	#FF5FD118$
��Bold"�$��10,0,0,0q��� $��55��$	��140�����	#FFD38D0E$ 15��$��Right=�._��� -	   $ mainMenuMinValueTextbox��
������ 
������ $ Center=�$��Center=�$��22(�$��Microsoft YaHei UI)����	#FF770000$ 6��$
 True��.��]� $��3��$��2��$��Center=�$��60��.+��� -
   $ mainMenuMaxValueTextBlock��$��MAX. VALUE:��$��35��$	��140��
������ $ Center=�$��Calibri)�$��26(�$��Center=����	#FFD11F18$
��Bold"�$��10,0,0,0q��� $��55��$	��140�����	#FFD38D0E$ 15��$��Right=�._��� -   $ mainMenuMaxValueTextbox��
������ 
������ $ Center=�$��Center=�$��22(�$��Microsoft YaHei UI)����	#FF770000$ 6��$
 True��.��]� $��1��$��3��.+��� $ 15�����	#FFD38D0E$
��Left=�$	��150��$��55��._��� -   $" mainMenuEnterNameHereTextBox��$
��Name��
������ 
������ ���	#FF770000$
 Left=�$��Center=�$��22(�$��Microsoft YaHei UI)�$��Italic$�.������ " �� P�  �@J�IsMouseOver$
 True��. ���  � ��$	 000��.���� $ 15�����	#FFD38D0E$��Right=�$	��150��$��55��._��� -   $&  mainMenuEnterCategoryHereTextBox��$��Category��
������ 
������ ���	#FF770000$
 Left=�$��Center=�$��22(�$��Microsoft YaHei UI)�$��Italic$�.������ " �� P�  �@J�IsMouseOver$
 True��. ���  � ��$	 000��.���� $��1��$��1��._��� -    ��Name$ mainMenuListBoxOne��$	��290�����	#FFECBF6D
������ 
���   �$��15(��� $��2��$��1��._��� -   $ mainMenuListBoxTwo��$	��290�����	#FFECBF6D
���   �$��15(��� -   $
 mainMenuExitButton��$��0��$��3�����	#FF770000���	#FFD38D0E$��X�����	#FFD38D0E$��25��$��25��$��2q�$��	10,0,0,24q�$
��Bold"� ��%:   '��       �� " ��.���  �@��CornerRadius$ 20���� $��1��$��2��._��� -   $ mainMenuGreetTextBlock��$��Welcome to Auction House�����	#FFD38D0E
������ $��Times New Roman)�$��25(�$��Center=�$��10,0,0,0q�$
��Bold"��� $��0��$��2��$��30��$	��150�����	#FFD38D0E$ 15��$��Right=�._��� -   $ mainMenuLoggedUserTextbox��
������ 
������ $ Center=�$��Center=�$��15(�$��Microsoft YaHei UI)����	#FF770000$ 6��$
 True��.��