   M S B A M L   `   `   `  ����D  @Harmonics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Harmonics.Views.MenuPages.ChatTemplates'Harmonics.Views.MenuPages.ChatTemplates  5      ;"clr-namespace:Harmonics.ConvertersHarmonics.Converters  5      ;"clr-namespace:Harmonics.ViewModelsHarmonics.ViewModels  5	      >    8Harmonics.Views.MenuPages.ChatTemplates.SelectedChatView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:Harmonics.Views.MenuPages.ChatTemplates     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3
converters"clr-namespace:Harmonics.Converters  5      3
viewModels"clr-namespace:Harmonics.ViewModels  5	        � 	Resources  5      ,   &Harmonics.Converters.ChatSizeConverter   ChatSizeConverter4   .Harmonics.Converters.ParticipantsSizeConverter  ParticipantsSizeConverter;   5Harmonics.Converters.CanAddParticipantToChatConverter $  CanAddParticipantToChatConverter��%W   &	        &	      &	 &       5   
   6'     5   
   6/     5   
   66   5       � DataContext 5      0   *Harmonics.ViewModels.SelectedChatViewModel  5   
   .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ Product��5   *   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6;   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.4X�.��5   
   � -   5        $��MainGrid��5      .+�5      � $	��Top=�6    K� ZIndex$ 1��6+   ���#242F3D$��40��6K   .+�5      �� -   5        $��0q�5   2   $
��Left=�6]   $��50��6x   $��40��6�   
������ ��6F   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon   � Cursor$
 Hand��6.      Kind$ 	ArrowBack=�6<   $��20��6M   $��20��6X   ���#ffc107$��Center=�6y   5      �� 5      -   5        $��0q�5   �   $
��Left=�6�   $��50,0,0,0q�6�   $��50��6�   $��40��6�   
������ y�6   ��  �� 	Converter# [ ��6�   Z� .��5        $
 Hand��6.   $��Center=�6<   $ PlusBold=�6W   $��Center=�6g   $��20��6�   $��20��6�   ���#ffc1076�   5      �� 5      ���#ffc107$	��200��61   $��24(�6=   $��Calibri Bold)�6K   	 �� TextAlignment$	 Center=�6   ��6e   �� *
ChatName+6�   5      �� 5      
 �� Orientation$
 
Horizontal=�6R   ��6   ��  �� Path$ ActualWidth� �� ElementName$ MainGrid��.+�5       � -   5        $��ChatTemplate��5       .+�5!      2	   ,Harmonics.Views.MenuPages.ChatTemplates.Chat	  ��6!   �� $ ActualWidth�$ MainGrid��# [  5"      � 5#      -   5        $��ParticipantsTemplate��5#      .+�5$      :
   4Harmonics.Views.MenuPages.ChatTemplates.Participants
  ��6)   �� $ ActualWidth�$ MainGrid��# [ 5%      5&      5'      5(      5)      