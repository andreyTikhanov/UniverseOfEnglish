   M S B A M L   `   `   `  ����P  LmyEnglish_with_Button, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:myEnglish_with_ButtonmyEnglish_with_Button  5   	   !    myEnglish_with_Button.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:myEnglish_with_Button     5   	     � Title$  Login��5      $	��450��6"   $	��800��6/    � 	Resources 5	         HoverTextBoxTemplate �� 
TargetType ��Name J� Opacity �� CornerRadius ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value �� 
TargetType��%�  &	        '�� A    �� 5
   
   " ��67   .R�5      �� $ border��6   $
 0.45Q�6%   
�������
���   �$��0q�6\   $ 5��6p   ._�5      �� $ PART_ContentHost��6   5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      �� $
 border��6    � �� �#e8d38e6G   5      5      �� 5   
   " ��6   .�5      ��  � �� �#b0a47b6+   �� 5       � ��
 �����6+   �� 5       � ��$ 30(�6)   �� 5       � ��$ DemiBold"�6+   �� 5       � ��$ 236,315,216,60q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   
���   �$��1q�6o   $ 5��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5        5!      P� 5"       �@J�IsMouseOver$
	 True��6=   . �5#   "   �� $
 border��6)    � �� �#b4a1636S   5$      5&      5(      5)      5*      .��5+      � 
�������.+�5,   
   �� 
�������$��DemiBold"�6"   $��30(�68   $��237,68,203,297q�6F   $��Welcome to the Keeper��6^   �� 5-   
   
�������$��DemiBold"�6"   $��30(�68   $��73,162,400,166q�6F   .��6^   !Введите ваше имя:6q   �� 5.   
   -   5        $��
tbNameUser��5.      ���#040403#��[  69   
�������$��33(�6~   $��DemiBold"�6�   $��381,164,10,201q�6�   $��0q�6�   �� 5/   
   -   5         ��Name$ btnOk��5/   %   $��Ok��64   $��316,301,327,69q�6A    J� RenderTransformOrigin$ 0.518,0.041&�6Y   50      51      