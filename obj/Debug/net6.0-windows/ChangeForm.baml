   M S B A M L   `   `   `  ����P  LmyEnglish_with_Button, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:myEnglish_with_ButtonmyEnglish_with_Button  5   	   &     myEnglish_with_Button.ChangeForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:myEnglish_with_Button     5   	     � Title$%  Добавление слова��5   	   $	��550��6"   $	��800��6/    � 	Resources 5	         HoverTextBoxTemplate �� 
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
 border��6)    � �� �#b4a1636S   5$      5&      5(      5)      5*      .��5.      � 
�������.+�5/   
   �� $��20(�6   $��10,-5,75,477q�6    J� RenderTransformOrigin$ 
0.495,0.23&�64   .��6W   @>Введите слово для редактирования:6z   �� 50   
   -   5         ��Name$ 	tbRussian��50      $��20(�6%   #��[  63   $��
3,37,0,444q�6d   6z   �� 51   
   $��20(�6   $��9,90,76,382q�6   $ 
0.495,0.23&�63   .��6V    Введите перевод:6h   �� 52   
   -   5        $ 	tbEnglish��52      $��20(�6%   #��[  63   $��1,129,2,352q�6d   6{   �� 53   
   -   5        $��86,450,481,26q�53   %   .��6<   Ok6@   �� 54   
   -   5        $��467,451,98,23q�54   '   .��6>   
Выход6E   �� 55   
   -   5        $��91,352,483,125q�55   ,   .��6D   Проверка слова6T   �� 56   
   -   5        $��472,350,99,124q�56   ,   .��6D   Irregular Verb6T   58      59      