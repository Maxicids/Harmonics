   M S B A M L   `   `   `  ����D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  5   	   (    "Harmonics.Views.RegistrationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   3
viewModels"clr-namespace:Harmonics.ViewModels  5   	     � Title$  RegistrationWindow��5	   	   $	��450��6$   $	��700��64   $	��450��6C   $	��800��6P    � WindowStyle$
 None=�6\    � 
ResizeMode$ 	CanResize=�6o   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      CaptionHeight$ 0Q�6   6+   .��5      � -   5        $��MainGrid��5   A   ���#0e1621.+�5      ��  �� Orientation$ Vertical=�6   .+�5      � -   5        $��TopGrid��5      ���#242F3D$
��Left=�68   $��20��6S   $	��Top=�6_   ��6w   ��  �� Path$ ActualWidth� �� ElementName$ MainGrid��.+�5      �� -   5        $��MinimizeButton��5      $��0q�6O   $��Right=�6[   $��0, -5, 48, 0q�6w   $��20��5   G   ��6   Z� ��60   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6/   
�������6E   5      �� 5      -   5        $��MaximizeButton��5      $��0q�6O   $��Right=�6[   $��0, -5, 26, 0q�6w   $��20��5   G   ��6   Z� ��60   Z� .��5        -   5        $��
ResizeIcon��5   /   $ WindowMaximize=�6A   
�������6W   5      �� 5      -   5        $��CloseButton��5      $��0q�6I   $��Right=�6U   $��0, -5, 5, 0q�6q   $��20��5   G   ��6   Z� ��60   Z� .��5        $ Close=�6/   
�������6<   5      5      � 5      -   5        $��CentralGrid��5      $	��400��6'   $��Center=�64   .+�5      �� $��
0, 30,0, 0q�6   ���#ffc107$��Center=�6F   
������ $��Registration��5   4   $��50(�6H   $��Calibri Bold)�5       	 �� TextAlignment$	 Center=�65   $	��300��6L   �� 5!      -   5        $��
MainBorder��5!      ���#242f3d$	��600��6A   $��Center=�6M   $	��170��6h   
 �� CornerRadius$
 15��6u   ._�5"      �� $��Center=�6"   $��Center=�6=   $ Vertical=�6Z   .+�5#      �� -	   5        $��TbLogin��5#   Q   $	��500��6`   
�������$��40��6   $	��Top=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��6�    %  !MaterialDesignFloatingHintTextBox#��[  5$   #   ��6^   �� *Login+ �� UpdateSourceTrigger$ PropertyChanged=�6�   G� 5%      -
   5        $��
TbPassword��5%   �   $	��500��6�   
�������$��40��6�   $	��Top=�6�   $ Password��6�    ) %MaterialDesignFloatingHintPasswordBox#��[ 5&   '   �� 5'      -   5        ���#ffc107 � Cursor$
 Hand��5'   Z   $	��150��6h   $��0,20,0,0q�6t   
������ $)��#already have an account? click here��6�   $��10(�6�   $��Calibri Bold)�6�   $	 Center=�6�   5(      5)      �� 5*      -   5        $��LoginBorder��5*       K� ZIndex$ 1��6-   ���#0e1621$��80��6T   $��80��6_   $
 80��6k   ._�5+      �� -   5        $
 Hand��5+   <   ���#242f3d$��60��6_   $��60��6j   $
 60��6v   ._�5,      � $ 1��6#   ���#ffc107 � Points' �   @x} -1@x} Zb Zb���6D   5-      5.      5/      50      �� 51      -   5         ��Name$ 	infoLabel��51      $��Center=�6=   $��Center=�6Z   $��16(�6u   $��	0,0,0,125q�6�   $��DemiBold"�6�   ��6$   �� *Info+6�   52      53      