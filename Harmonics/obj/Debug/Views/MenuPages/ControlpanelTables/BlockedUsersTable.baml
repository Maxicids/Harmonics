   M S B A M L   `   `   `  ����D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  5      ;"clr-namespace:Harmonics.ConvertersHarmonics.Converters  5      D    >Harmonics.Views.MenuPages.ControlPanelTables.BlockedUsersTable   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9
viewModels"clr-namespace:Harmonics.ViewModels     5      9
converters"clr-namespace:Harmonics.Converters     5        � DataContext  5
      0   *Harmonics.ViewModels.BlockedUsersViewModel  5   
    � 	Resources 5      -   'Harmonics.Converters.IdToLoginConverter   IdToLoginConverter4   .Harmonics.Converters.ReasonIdToStringConverter  ReasonIdToStringConverter��%:   &	        &	        5   
   6(     5   
   6/   5      .��5      � -   5        $��MainGrid��5      
���P��.+�5   
   &   System.Windows.Controls.DataGrid     CanUserAddRows .  $   HorizontalScrollBarVisibility$ Visible=�6*   $
��Left=�6R   $	��Top=�6m      AutoGenerateColumns .  ��6�   ��  �� Path$ ActualWidth� �� ElementName$ MainGrid����5      �� $ ActualWidth�$ MainGrid����6L   �� *BlockedUsers+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6<   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+6H     5      $
	 User��6p   
 .  6%   �� *	user_id+ �� 	Converter# [  6~     5      
 . $	 
Blocked at��6V    6%   �� *
blocked_at+6V     5      $	 Reason��6v   
 .  6%   �� *reason+# [ 6�   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �   6#   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" >�$ DataContext�.+�5   "   �� ��6)   �� *ForgiveCommand+��6L   �� $ IdTextBlock��$
 Text�.��6�   	Forgive6�   5      5      5!      5#      � 5$   
   $y�Hidden=�6     6#   �� *BlockedUsers+.+�5%      �� -   5        $��IdTextBlock��5%      ��6+   �� *id+6A   5&      5'      5(      