   M S B A M L   `   `   `  ����P  LmyEnglish_with_Button, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:myEnglish_with_ButtonmyEnglish_with_Button  5   	   +    %myEnglish_with_Button.DeleteWordsForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:myEnglish_with_Button     5   	     � Title$!  Удаление слова��5   	   $	��550��6    $	��800��6-    � 	Resources 5	         HoverTextBoxTemplate �� 
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
   �� $��20(�6   $��0,0,418,477q�6   .��63   42Введите слово для удаления:6Q   �� 5.   
   -   5         ��Name$ tbRussianWord��5.      $��20(�6)   #��[  67   $��2,65,-4,413q�6h   6   �� 5/   
   $��20(�6   $��-2,136,420,337q�6   .��66   42Перевод слова для удаления:6T   �� 50   
   -   5        $ tbEnglishWord��50      $��20(�6)   #��[  67   $��-1,201,-1,275q�6h   6�   �� 51   
   -   5        $��279,307,288,157q�51   )   .��6B   Проверить слово6S   �� 52   
   -   5        $��76,422,497,37q�52   %   .��6<   Ok6@   �� 53   
   -   5        $��477,425,92,34q�53   '   .��6>   
Выйти6E   54      55      