   M S B A M L   `   `   `  ����D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  5      =    7Harmonics.Views.MenuPages.ControlPanelTables.UsersTable   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9
viewModels"clr-namespace:Harmonics.ViewModels     5        � DataContext  5	      (   "Harmonics.ViewModels.UserViewModel  5
   
   .��5      � -   5        $��MainGrid��5      
���   �.+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��Users��5   �      CanUserAddRows .  $   HorizontalScrollBarVisibility$ Visible=�5   *   "   VerticalScrollBarVisibility$ Visible=�6R   $
��Left=�6x   $	��Top=�6�      AutoGenerateColumns .  ��6�   ��  �� Path$ ActualWidth� �� ElementName$ MainGrid����5      �� $ ActualWidth�$ MainGrid����6L   �� *Users+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6<   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+6H     5      $	 Login��6?    6%   �� *login+6?     5      
 . $
	 Role��6P    6%   �� *role+6P     5      $	 Description��6E    6%   �� *description+6E     5      
 . $	 Settings id��6p    6%   �� *
settings+ �� ValidatesOnExceptions . 6p   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Profile Picture��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6B   
 .    CellTemplate 5      �� 5      .R�5      �� ��6$   �� *profile_Picture+5      5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      
 . $	 	is_Online��6Y    6)   �� *	is_Online+6Y     5      
 . $	 
is_Blocked��6Z    6)   �� *
is_Blocked+6Z     5      
 . $	 
created_At��6V    6%   �� *
created_At+6V   5       5!      5"      