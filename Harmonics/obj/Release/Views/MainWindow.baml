   M S B A M L   `   `   `  ���� D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ConvertersHarmonics.Converters  ;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels       Harmonics.Views.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  3
converters"clr-namespace:Harmonics.Converters  3
viewModels"clr-namespace:Harmonics.ViewModels    � Title$  
MainWindow��$	��450��$	��800��$	��450��$	��800�� � WindowStyle$
 None=� � 
ResizeMode$ 	CanResize=�'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 0Q� � DataContext .   (Harmonics.ViewModels.MainWindowViewModel   � 	Resources 4   .Harmonics.Converters.BoolToVisibilityConverter   ReportVisibilityConverter  
MenuButton �� Property �� Value��%f   &	        &	        �� .���  � ��$ 60����  � ��$	 250����  � ��$
 Left=�.��� -   $��MainGrid�����#0e1621.+��� 	 �� Orientation$	 Vertical=�.+�� -   $��TopGrid�����#242F3D$
��Left=�$��20��$	��Top=����� 
 �� Path$
 ActualWidth� �� ElementName$ MainGrid��.+��� -   $��MinimizeButton��$��0q�$��Right=�$��0, -5, 47, 0q�$��20����Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�
��������� -   $��MaximizeButton��$��0q�$��Right=�$��0, -5, 26, 0q�$��20����Z� ��Z� .��  -   $��
ResizeIcon��$ WindowMaximize=�
��������� -   $��CloseButton��$��0q�$��Right=�$��0, -5, 5, 0q�$��20����Z� ��Z� .��  $ Close=�
�������� -   $��ToolGrid�����#17212b$
��Left=�$��35��$	��Top=����� $
 ActualWidth�$ MainGrid��.+��� $	 
Horizontal=�.+��� $��0q�$��35�� � Cursor$ Arrow����Z� ��Z� .��  $ Account=����#ffc107$
��29.5��$
��39.5���� -   $��TbAccountName�����#ffc107$��Center=�$��22(�$��Calibri Bold)����� *Name+�� $��Right=�$	 
Horizontal=�.+��� $��0q�$��25����Z� ��Z� .��  -	   $��NotificationButton��$ Notifications=����#ffc107�� -
   $��0q�$��25����Z� ��Z� .��  $ Power=����#ffc107�� -   $��ContentPanel��$	 
Horizontal=�$��Center=�.+�� -   $��MenuGrid�����#0d1521$	��250��$
��Left=�.+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -     Name$ MenuTransition�� K� ZIndex$ 2��C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��� -    �Name$ 
GridCursor��$��0, 80, 0, 0q����#001250$��10��$��60��$
��Left=�$	��Top=��� $	 Vertical=�.+��� -   $��0, 80, 0, 0q�#��[ $	 
Horizontal=�.+�  $��20,0,0,0q�$ MessageBulleted=�$��30��$��30�����#ffc107$��Center=��� $��Center=����#ffc107$��Chats��$��26(�$��10, 0, 0, 0q�$��Calibri Bold)��� -   #��[ $	 
Horizontal=�.+�  $��20,0,0,0q�$ SettingsBox=�$��30�����#ffc107$��30��$��Center=��� $��Center=�$��Settings��$��26(����#ffc107$��10, 0, 0, 0q�$��Calibri Bold)��� -   #��[ $	 
Horizontal=�y��� *IsControlPanelVisible+ �� 	Converter# [  .+�  $��20,0,0,0q�$ ControllerSquare=����#ffc107$��30��$��30��$��Center=��� $��Center=�$��ControlPanel��$��26(����#ffc107$��10, 0, 0, 0q�$��Calibri Bold)�� -   $��ContentGrid��$	��540��$	��Top=�$	��100��