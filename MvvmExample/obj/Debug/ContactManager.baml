   M S B A M L   `   `   `  ����F  BMvvmExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ContactMvvmContactMvvm  5   	   (    "ExceptionValidation.ContactManager   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /	viewModelclr-namespace:ContactMvvm     5   	     � Title$  ContactManager��5   	   $	��300��6    $	��300��6-    � 	Resources 5      )   #ContactMvvm.ContactManagerViewModel   contactViewModel��%   &	          5   
   6,   5      .��5	      �  � DataContext# [  6    � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��93* �6   �� 5      $	��29* �6   �� 5      $	��27* �6   �� 5      $	��30* �6   �� 5      $	��81* �6   .+�5   
   �� -   5         ��Name$ lstContacts��5   ;   $��2��6   $��2q�6'   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6P   # [  5      #��[  6P    �� DisplayMemberPath$ 	FirstName��6�   $��0,0,0,28q�6�   $��2��6�   �� 5   
   $��0��6   $��1��6$   $��
First name��61   �� 5   
   $��1��6   $��1��6"   ��6/   ��  �� Path$ 	FirstName��� 5   
   $��0��6   $��2��6$   $��	Last name��61   �� 5   
   $��1��6   $��2��6"   ��6/   �� $ LastName��� 5   
   $��0��6   $��3��6$   $��Email address��61   �� 5   
   $��1��6   $��3��6"   ��6/   �� $ EmailAddress��� 5!   
   $��0��6   $��4��6$   $��Telephone number��61   �� 5"   
   $��1��6   $��4��6"   ��6/   �� $ TelephoneNumber�5$      5%      