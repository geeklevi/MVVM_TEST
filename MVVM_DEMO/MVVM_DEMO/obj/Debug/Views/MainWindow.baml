   M S B A M L   `   `   `  ����D  @MVVM_DEMO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MVVM_DEMO	MVVM_DEMO  5   	        MVVM_DEMO.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MVVM_DEMO     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � $	��Top=�6   $��16q�6#    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   .��6    Customer Name6/   �� 5   
   $��1��6   ��6"   �� *Customer.Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5   
   $��2��6   ��6!   �� *UpdateCommand+.��6C   Update6K   5      5      