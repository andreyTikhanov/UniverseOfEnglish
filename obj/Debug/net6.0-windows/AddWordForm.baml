   M S B A M L   `   `   `  ����P  LmyEnglish_with_Button, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:myEnglish_with_ButtonmyEnglish_with_Button  5   	   '    !myEnglish_with_Button.AddWordForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:myEnglish_with_Button     5   	     � Title$%  Добавление слова��5   	   $	��550��6"   $	��800��6/    � 	Resources 5	         HoverTextBoxTemplate �� 
TargetType ��Name J� Opacity �� CornerRadius ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value �� 
TargetType��%�  &	        '�� E    �� 5
   
   " ��67   .R�5      �� $ border��6   $
 0.45Q�6%   ���#b0a47b
���   �$��0q�6]   $ 5��6q   ._�5      �� $ PART_ContentHost��6   5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      �� $
 border��6    � �� �#b0a47b6G   5      5      �� 5   
   " ��6   .�5      ��  � �� �#b0a47b6+   �� 5       � ��
 �����6+   �� 5       � ��$ 20(�6)   �� 5       � ��$ DemiBold"�6+   �� 5       � ��$ 236,315,216,60q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   
���   �$��1q�6o   $ 5��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5        5!      P� 5"       �@J�IsMouseOver$
	 True��6=   . �5#   "   �� $
 border��6)    � �� �#b4a1636S   5$      5&      5(      5)      5*      .��5,      � 
�������.+�5-   
   �� $��20(�6   $5��/Введите слово на русском: ��6   $��5,4,251,453q�6C    J� RenderTransformOrigin$ 0.487,0.384&�6X   6~   �� 5.   
   -   5         ��Name$ tbAddEnglish��5.      #��[  6(   $��25(�6Y   $��-1,158,1,315q�6g   �� 5/   
   $��20(�6   $;��5Введите слово на английском: ��6   $��2,114,380,344q�6F   6_   �� 50   
   -   5        $ tbAddRussian��50      #��[  6(   $��25(�6Y   $��1,47,-1,428q�6g   �� 51   
   -   5        $��20(�51   '   $��578,372,52,104q�65   .��6N   
Выйти6U   �� 52   
   -   5        $��20(�52   '   $��25,277,613,198q�65   .��6N   Noun6T   �� 53   
   -   5        $��580,276,46,199q�53   ,   .��6D   	Adjective6O   �� 54   
   -   5        $��20(�54   -   $��296,278,299,194q�6;   .��6U   Phrase Verb6b   �� 55   
   -   5        $��24,371,612,104q�55   .   .��6F   Regular Verb6T   �� 56   
   -   5        $��291,369,302,103q�56   0   .��6I   Irregular Verb6Y   �� 57   
   $��20(�6   $a��[Если глагол не правильный, нажмите кнопку Irregular Verb��6   $��7,462,165,14q�6a   6y   58      59      