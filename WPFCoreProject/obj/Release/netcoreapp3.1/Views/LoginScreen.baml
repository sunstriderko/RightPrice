   M S B A M L   `   `   `  ���� K  GWPFCoreProjectUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFCoreProjectUI.ViewsWPFCoreProjectUI.Views  (    "WPFCoreProjectUI.Views.LoginScreen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:WPFCoreProjectUI.Views       � Title$  LoginScreen��$	��300��$	��400�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � AllowsTransparency$
 True��
������ .���  � RowDefinitions �� $
��1.5* ��� $��6* ��� $��5* ��� $
��2.5* ��� $��1* � � ColumnDefinitions �� $
��0.3* ��� $��1* ��� $��1* ��� $
��0.3* �.+��� $��5��$��4�� �� CornerRadius$ 	0,0,10,10������ -   loginScreenBackgroundImage�� j� Stretch$
 Fill=�	 �� ImageSource$.	 (/Pictures/Auction_house_background_2.jpg���� -   
 ��Name$
 loginScreenExitButton��$��0��$��3�����	#FF770000���	#FFD38D0E$��X�����	#FFD38D0E$��22��$��22��$��2q�$��20,0,0,0q�$
��Bold"� � 	Resources  �� 
TargetType �� Property �� Value��%:   '��       �� " ��.���  �@��CornerRadius$ 20���� $��1��$��1��$��2��$ 15������ $ UniformToFill=�$#	 /Pictures/logo_bazaar_new.jpg���� $��3��$��1��._��� -   $
 loginScreenLoginButton��$��Login��$	��100��$��35�����	#FF770000���	#FFD38D0E$	��2.5q����	#FFBAACAC$
��13.5(�$
��Bold"�$
��Left=�  �� Triggers P� Property P� Value��%{   '��       �� " ��.���  �@��CornerRadius$ 10�� P�  �@J�IsMouseOver$
 True��. ���  � ��$ 10(��� $��3��$��2��._��� -   $ 
 loginScreenCreateNewButton��$��
Create New��$	��100��$��35�����	#FF770000���	#FFD38D0E$	��2.5q����	#FFBAACAC$
��13.5(�$
��Bold"�$��Right=� ��%{   '��       �� " ��.���  �@��CornerRadius$ 10�� P�  �@J�IsMouseOver$
 True��. ���  � ��$ 10(��� $��2��$��1��$��60��.+��� $��	Username:�����	#FFD38D0E$	��Top=�$��20(�$
��Bold"��� $��	Password:�����	#FFD38D0E$��20(�$
��Bold"�$��0,10,0,0q��� $��2��$��1��$��70��$��2��$	��180��$��Right=�.+��� ���	#FFD38D0E$ 8��$��0q�$��30��$��0,3,0,0q�._��� -    ��Name$  loginScreenUsernameTextbox��
������ 
������ $��14(� �� TextAlignment$
 Left=�$��Center=����	#FF770000$��Calibri)�.���� $��30�����	#FFD38D0E$ 8��$��0q�$��0,7,0,0q�._�G� -    G�Name$$ loginScreenPasswordPasswordbox��
������ 
������ $��14(�$��Center=�