   M S B A M L   `   `   `  ���� D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  ;"clr-namespace:Harmonics.ConvertersHarmonics.Converters  D    >Harmonics.Views.MenuPages.ControlPanelTables.BlockedUsersTable   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9
viewModels"clr-namespace:Harmonics.ViewModels     9
converters"clr-namespace:Harmonics.Converters       � DataContext  0   *Harmonics.ViewModels.BlockedUsersViewModel   � 	Resources -   'Harmonics.Converters.IdToLoginConverter   IdToLoginConverter4   .Harmonics.Converters.ReasonIdToStringConverter  ReasonIdToStringConverter��%   &	        &	          .��� -   $��MainGrid��
���P��.+�&   System.Windows.Controls.DataGrid  $��Visible=�$��Visible=�   CanUserAddRows .  $   HorizontalScrollBarVisibility$ Visible=�$
��Left=�$	��Top=�   AutoGenerateColumns .  ����  �� Path$ ActualWidth� �� ElementName$ MainGrid������ $ ActualWidth�$ MainGrid������ *BlockedUsers+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *id+  $
	 User��
 .  �� *	user_id+ �� 	Converter# [    
 . $	 
Blocked at�� �� *
blocked_at+  $	 Reason��
 .  �� *reason+# [ 4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" >�$ DataContext�.+��� ���� *ForgiveCommand+���� $ IdTextBlock��$
 Text�.��	Forgive� $y�Hidden=�  �� *BlockedUsers+.+��� -   $��IdTextBlock������ *id+