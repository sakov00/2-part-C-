   M S B A M L   `   `   `  ����G  CSakov.laba11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Sakov.laba11Sakov.laba11  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	       Sakov.laba11.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Sakov.laba11     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � 
�������.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ApartmentsGrid��5         AutoGenerateColumns .  $	��520��6G   $��247,10,25,155q�6T    � 	Resources 5      ��%    5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ Id�6M     5      $ 	Id_Adress��6%   $ 60 6[    68   �� $ 	Id_Adress�6[     5      $ Metres��6%   $ 50 6U    65   �� $ Metres�6U     5      $ Value_Rooms��6%   $ 70 6_    6:   �� $ Value_Rooms�6_     5      $ Year_Building��6%   $	 140 6c    6<   �� $ Year_Building�6c     5      $ Type_Material��6%   $ 90 6c    6<   �� $ Type_Material�6c     5      $ Floor��6%   $ 60 6S    64   �� $ Floor�6S   5      �� 5   
   -   5        	 ��Name$	 Add_Apartment��5      $��Add Apartment��6(   $
��Left=�6@   $��	10,10,0,0q�6[   $	��Top=�6n   $	��105��6�   $��30��6�   �� 5   
   -   5        $	 Delete_Apartment��5      $��Delete Apartment��6+   $
��Left=�6F   $��	10,45,0,0q�6a   $	��Top=�6t   $	��105��6�   $��30��6�   6�   �� 5   
   -   5        $	 Modify_Apartment��5      $��Modify Apartment��6+   $
��Left=�6F   $��462,276,0,0q�6a   $	��Top=�6v   $	��105��6�   $��30��6�   6�   �� 5   
   -   5        
 ��Name$
 Delete_For_Id��5      $
��Left=�6)   $��30��6D    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��105��6|   $��
120,45,0,0q�6�   �� 5   
   -   5        $
 What_Atribut_Change��5      $
��Left=�6/   $��30��6J   $
 Wrap=�6V   $	��Top=�6j   $	��105��6�   $��352,310,0,0q�6�   �� 5   
   -   5        $
 Value_Change��5      $
��Left=�6(   $��30��6C   $
 Wrap=�6O   $	��Top=�6c   $	��105��6{   $��462,310,0,0q�6�   �� 5   
   -   5        $
 What_Change��5      $
��Left=�6'   $��30��6B   $
 Wrap=�6N   $	��Top=�6b   $	��105��6z   $��572,310,0,0q�6�   �� 5   
   -	   5        $	 Refresh��5      $��Refresh��6"   $
��Left=�64   $��	10,80,0,0q�6O   $	��Top=�6b   $	��105��6z   $��30��6�   6�   �� 5    
   -
   5        $
	 Sort��5       $
��Sort��6   $
��Left=�6.   $��
10,115,0,0q�6I   $	��Top=�6]   $	��105��6u   $��30��6�   6�   �� 5!   
   -   5        $
 Sort_For_Atribute��5!      $
��Left=�6-   $��30��6H   $
 Wrap=�6T   $	��Top=�6h   $	��105��6�   $��120,115,0,0q�6�   5"      5#      