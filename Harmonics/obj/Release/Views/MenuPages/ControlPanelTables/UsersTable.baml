   M S B A M L   `   `   `  ���� D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  =    7Harmonics.Views.MenuPages.ControlPanelTables.UsersTable   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9
viewModels"clr-namespace:Harmonics.ViewModels       � DataContext  (   "Harmonics.ViewModels.UserViewModel  .��� -   $��MainGrid��
���   �.+�&   System.Windows.Controls.DataGrid     CanUserAddRows .  $   HorizontalScrollBarVisibility$ Visible=�"   VerticalScrollBarVisibility$ Visible=�$
��Left=�$	��Top=�   AutoGenerateColumns .  ����  �� Path$ ActualWidth� �� ElementName$ MainGrid������ $ ActualWidth�$ MainGrid������ *Users+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *id+  $	 Login�� �� *login+  
 . $
	 Role�� �� *role+  $	 Description�� �� *description+  
 . $	 Settings id�� �� *
settings+ �� ValidatesOnExceptions . 4  .System.Windows.Controls.DataGridTemplateColumn  $	 Profile Picture��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 
 .    CellTemplate �� .R��� ���� *profile_Picture+4  .System.Windows.Controls.DataGridCheckBoxColumn  
 . $	 	is_Online�� �� *	is_Online+  
 . $	 
is_Blocked�� �� *
is_Blocked+  
 . $	 
created_At�� �� *
created_At+