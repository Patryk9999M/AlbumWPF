   M S B A M L   `   `   `  ����@  <Album, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Album.PhotoWindow.DziecinstwoAlbum.PhotoWindow.Dziecinstwo  5   	   1    +Album.PhotoWindow.Dziecinstwo.PierwszeKroki   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Album.PhotoWindow.Dziecinstwo     5   	   -   5          � Title$  Pierwsze Kroki��5	   	   $	��800��6    $
��1200��6-    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   	Direction	   Color
   Opacity   
BlurRadius �� Triggers P� Property P� Value��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 30(�6)   �� 5       � ��
 �����6+   �� 5       � ��
 ���� 6+   �� 5       � ��$	 250��6&   �� 5       � ��$ 70��6'   �� 5       � ��$ 10,10,10,10q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 20��6K   $��5q�5   !   
�������._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      �� 5        �@J�Effect 5!        5"      $ 5Q�5#      $	 330Q�5$      $	 Black��5%      $	
 0.5Q�5&      $ 40Q�5'      5)       5-      P� 5.       �@J�IsMouseOver$  True��61   . �5/      ��  � ��
 �����63   �� 50       �@J�Opacity$	 0.4Q�60   �� 51       � �� �#f083da63   52      P� 53       �@J�IsMouseOver$
 True��61   . �54      ��  �@�Cursor$
 Hand��6/   55      57      5<      .��5=      � ��5>   
   �� 5?      .��5@      �  � Color$ #7be9f6��6    � Offset$	 0.0Q�6/   � 5A      $ #f083da��6   $ 1Q�6/   5B       � ColumnDefinitions 5D   
   �� 5E      $��* �6   �� 5F      $��6* �6    � RowDefinitions 5H   
   �� 5I      $
��auto �6   �� 5J      $
��auto �6   �� 5K      $��* �6   .+�5N   
   �� $��1��6   $��3��6'   .��5O      �� -   5        $��	ImageList��5O      $��	0,10,0,10q�6N   ��6,   �� *	ImageList+��5Q      �� 5R      .R�5S      � 5T      ��5W      �� 5X      .R�5Y      �� $��	10,0,0,10q�6%   .+�5Z      �� $	��250��6<   $	��250��6H   $��Uniform=�6U   ��6$   �� *Path+6U   �� 5[      $��	ImageName��6&   $��1q�67   ���	#FF787878��6Y   �� *
FileName+5\      5]      5_      5a      �� 5b   
   -   5        $��Pokaż/��5b      $��0��6#   $	��120��60   $��50��6<   $��10,100,10,10q�6H   6^   �� 5d   
   -   5        $��Dodaj��5d      $��1��6!   $	��120��6.   $��50��6:   $��10,100,10,10q�6F   6\   5e      5f      