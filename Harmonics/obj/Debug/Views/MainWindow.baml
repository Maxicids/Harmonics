   M S B A M L   `   `   `  ����D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ConvertersHarmonics.Converters  5   	   ;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  5   	        Harmonics.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   3
converters"clr-namespace:Harmonics.Converters  5   	   3
viewModels"clr-namespace:Harmonics.ViewModels  5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6,   $	��450��6;   $	��800��6H    � WindowStyle$
 None=�6T    � 
ResizeMode$ 	CanResize=�6g   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6   6+    � DataContext 5      .   (Harmonics.ViewModels.MainWindowViewModel  5   
    � 	Resources 5      4   .Harmonics.Converters.BoolToVisibilityConverter   ReportVisibilityConverter  
MenuButton �� Property �� Value��%�   &	        &	        5   
   6/   �� 5   
   .�5      ��  � ��$ 60��6/   �� 5       � ��$	 250��6.   �� 5       � ��$
 Left=�6<   5      5      .��5      � -   5        $��MainGrid��5   A   ���#0e1621.+�5   
   �� 	 �� Orientation$	 Vertical=�6   .+�5      � -   5        $��TopGrid��5      ���#242F3D$
��Left=�67   $��20��6R   $	��Top=�6^   ��6v   �� 
 �� Path$
 ActualWidth� �� ElementName$ MainGrid��.+�5      �� -   5        $��MinimizeButton��5      $��0q�6N   $��Right=�6Z   $��0, -5, 47, 0q�6v   $��20��5   F   ��6   Z� ��6/   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6.   
�������6D   5      �� 5       -   5        $��MaximizeButton��5       $��0q�6N   $��Right=�6Z   $��0, -5, 26, 0q�6v   $��20��5!   F   ��6   Z� ��6/   Z� .��5"        -   5        $��
ResizeIcon��5"   .   $ WindowMaximize=�6@   
�������6V   5#      �� 5$      -   5        $��CloseButton��5$      $��0q�6H   $��Right=�6T   $��0, -5, 5, 0q�6p   $��20��5%   F   ��6   Z� ��6/   Z� .��5&        $ Close=�6.   
�������6;   5'      5(      � 5)      -   5        $��ToolGrid��5)      ���#17212b$
��Left=�68   $��35��6S   $	��Top=�6_   ��6w   �� $
 ActualWidth�$ MainGrid��.+�5*      �� $	 
Horizontal=�6   .+�5+      �� $��0q�6   $��35��6*    � Cursor$ Arrow��66   ��5,      Z� ��6+   Z� .��5-        $ Account=�6.   ���#ffc107$
��29.5��6R   $
��39.5��6`   5.      �� 5/      -   5        $��TbAccountName��5/       ���#ffc107$��Center=�6K   $��22(�6|   $��Calibri Bold)�6�   ��6f   �� *Name+6�   50      �� 51      $��Right=�6   $	 
Horizontal=�69   .+�52      �� $��0q�6   $��25��53   J   ��6   Z� ��63   Z� .��54        -	   5        $��NotificationButton��54   2   $ Notifications=�6L   ���#ffc1076a   55      �� 56      -
   5        $��0q�56      $��25��57   J   ��6   Z� ��63   Z� .��58        $ Power=�62   ���#ffc1076?   59      5:      5;      �� 5<      -   5        $��ContentPanel��5<      $	 
Horizontal=�6-   $��Center=�6F   .+�5=      � -   5        $��MenuGrid��5=      ���#0d1521$	��250��6<   $
��Left=�6H   .+�5>      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ MenuTransition��5>   6    K� ZIndex$ 2��6N   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 5?   6   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5@      � -   5         �Name$ 
GridCursor��5@   E   $��0, 80, 0, 0q�6   ���#001250$��10��6Y   $��60��6d   $
��Left=�6p   $	��Top=�6�   5A      �� 5B      $	 Vertical=�6   .+�5C      �� -   5        $��0, 80, 0, 0q�5C   !   #��[ 66   $	 
Horizontal=�6Z   .+�5D        $��20,0,0,0q�6.   $ MessageBulleted=�6@   $��30��6W   $��30��6b   ���#ffc107$��Center=�6�   �� 5E      $��Center=�6$   ���#ffc107$��Chats��6T   $��26(�6a   $��10, 0, 0, 0q�6o   $��Calibri Bold)�6�   5F      �� 5G      -   5        #��[ 5G   !   $	 
Horizontal=�6E   .+�5H        $��20,0,0,0q�62   $ SettingsBox=�6D   $��30��6W   ���#ffc107$��30��6w   $��Center=�6�   �� 5I      $��Center=�6$   $��Settings��6?   $��26(�6O   ���#ffc107$��10, 0, 0, 0q�6r   $��Calibri Bold)�6�   5J      �� 5K      -   5        #��[ 5K   �   $	 
Horizontal=�6�   y�6!   �� *IsControlPanelVisible+ �� 	Converter# [  .+�5L        $��20,0,0,0q�62   $ ControllerSquare=�6D   ���#ffc107$��30��6q   $��30��6|   $��Center=�6�   �� 5M      $��Center=�6$   $��ControlPanel��6?   $��26(�6S   ���#ffc107$��10, 0, 0, 0q�6v   $��Calibri Bold)�6�   5N      5O      5P      � 5Q      -   5        $��ContentGrid��5Q      $	��540��6*   $	��Top=�5R      $	��100��65   5S      5T      5U      5V      5W      