   M S B A M L   `   `   `  ����H  DGuySerializer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GuySerializerGuySerializer  5   	       GuySerializer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -localclr-namespace:GuySerializer     5   	     � Title$  Guy Serializer��5   	   $	��275��5   	   $	��525��5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5	         GuySerializer.GuyManager   
guyManager��%   &	          5
   
   6   5      .��5      �  � DataContext# [  6   $��5q�5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��3* �6   .+�5   
   �� .+�5      �� -   5         ��Name$ WriteJoe��5      $��	Write Joe��5      $
��Left=�5      5      �� 5      $��	0,0,10,20q�5      $
��Wrap=�5      ��5      �� *Joe+5      5      �� 5    
   $��1��6   .+�5!      �� -   5        $ WriteBob��5!      $��	Write Bob��5"      $
��Left=�5#      5$      �� 5%      $��0,0,0,20q�5&      $
��Wrap=�5'      ��5%      �� *Bob+5'      5(      �� 5)   
   $��2��6   $��10,0,0,0q�5*      .+�5+      �� -   5        $ WriteEd��5+      $��Write Ed��5,      $
��Left=�5-      5.      �� 5/      $��0,0,0,20q�50      $
��Wrap=�51      ��5/      �� *Ed+51      52      �� 53   
   $��1��6   $��2��54      $��0,0,20,0q�55      .+�56      �� Last filename written6/   �� 57       �� TextWrapping$
 Wrap=�58      $��60��59      $��0,0,0,20q�5:      ��57      �� *	GuyFile+ �� Mode$ TwoWay=�5:      5;      �� 5<   
   $��1��6   $��2��5=      $��10,0,0,0q�5>      .+�5?      �� -   5        $ 
ReadNewGuy��5?      $��Read a new Guy��5@      $
��Left=�5A      5B      �� 5C      .+�5D      �� $��New guy:��6   �� 5E      $
��Wrap=�6   ��5F      �� *NewGuy+5G      5H      5I      5J      