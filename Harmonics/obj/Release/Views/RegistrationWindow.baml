   M S B A M L   `   `   `  ���� D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  (    "Harmonics.Views.RegistrationWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  3
viewModels"clr-namespace:Harmonics.ViewModels    � Title$  RegistrationWindow��$	��450��$	��700��$	��450��$	��800�� � WindowStyle$
 None=� � 
ResizeMode$ 	CanResize=�'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 0Q�.��� -   $��MainGrid�����#0e1621.+���  �� Orientation$ Vertical=�.+�� -   $��TopGrid�����#242F3D$
��Left=�$��20��$	��Top=�����  �� Path$ ActualWidth� �� ElementName$ MainGrid��.+��� -   $��MinimizeButton��$��0q�$��Right=�$��0, -5, 48, 0q�$��20����Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�
��������� -   $��MaximizeButton��$��0q�$��Right=�$��0, -5, 26, 0q�$��20����Z� ��Z� .��  -   $��
ResizeIcon��$ WindowMaximize=�
��������� -   $��CloseButton��$��0q�$��Right=�$��0, -5, 5, 0q�$��20����Z� ��Z� .��  $ Close=�
�������� -   $��CentralGrid��$	��400��$��Center=�.+��� $��
0, 30,0, 0q����#ffc107$��Center=�
������ $��Registration��$��50(�$��Calibri Bold)�	 �� TextAlignment$	 Center=�$	��300���� -   $��
MainBorder�����#242f3d$	��600��$��Center=�$	��170��
 �� CornerRadius$
 15��._��� $��Center=�$��Center=�$ Vertical=�.+��� -	   $��TbLogin��$	��500��
�������$��40��$	��Top=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username�� %  !MaterialDesignFloatingHintTextBox#��[  ���� *Login+ �� UpdateSourceTrigger$ PropertyChanged=�G� -
   $��
TbPassword��$	��500��
�������$��40��$	��Top=�$ Password�� ) %MaterialDesignFloatingHintPasswordBox#��[ �� -   ���#ffc107 � Cursor$
 Hand��$	��150��$��0,20,0,0q�
������ $)��#already have an account? click here��$��10(�$��Calibri Bold)�$	 Center=��� -   $��LoginBorder�� K� ZIndex$ 1�����#0e1621$��80��$��80��$
 80��._��� -   $
 Hand�����#242f3d$��60��$��60��$
 60��._�� $ 1�����#ffc107 � Points' �   @x} -1@x} Zb Zb����� -    ��Name$ 	infoLabel��$��Center=�$��Center=�$��16(�$��	0,0,0,125q�$��DemiBold"����� *Info+