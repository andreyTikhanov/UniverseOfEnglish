   M S B A M L   `   `   `  ����P  LmyEnglish_with_Button, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:myEnglish_with_ButtonmyEnglish_with_Button  5   	   0    *myEnglish_with_Button.AddIrregularVerbForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:myEnglish_with_Button     5   	     � Title$D  >Добавление неправильного глагола��5   	   $	��550��62   $	��800��6?    � 	Resources 5	         HoverTextBoxTemplate �� 
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
 border��6)    � �� �#b4a1636S   5$      5&      5(      5)      5*      .��5-      � 
�������.+�5.   
   �� $��20(�6   $5��/Введите слово на русском: ��6   $��5,-2,251,480q�6C    J� RenderTransformOrigin$ 0.487,0.384&�6Y   6   �� 5/   
   -   5         ��Name$ tbAddRussian��5/      #��[  6(   $��25(�6Y   $��3,51,-3,429q�6g   �� 50   
   $��20(�6   $.��(Введите первую форму: ��6   $��7,100,525,377q�6?   6X   �� 51   
   -   5        $ tbAddTheFirstForm��51      #��[  6-   $��25(�6^   $��1,155,-1,325q�6l   $ 0.5,0.5&�6�   �� 52   
   $��20(�6   $��4,211,525,263q�6   .��66   )'Введите вторую форму:6M   �� 53   
   -   5        $ tbAddTheSecondForm��53      #��[  6.   $��25(�6_   $��0,264,0,216q�6m   �� 54   
   $��20(�6   $��5,317,515,161q�6   .��65   )'Введите третью форму:6L   �� 55   
   -   5        $ tbAddTheThirdForm��55      #��[  6-   $��25(�6^   $��2,370,-1,110q�6l   �� 56   
   -   5        $��479,444,90,33q�56   '   .��6>   
Выйти6E   �� 57   
   -   5        $��89,442,469,32q�57   0   .��6G   Сохранить6R   5;      5<      