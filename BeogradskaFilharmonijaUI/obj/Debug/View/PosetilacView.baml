   M S B A M L   `   `   `  ����S  OBeogradskaFilharmonijaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BeogradskaFilharmonijaUI.ViewBeogradskaFilharmonijaUI.View  5   	   1    +BeogradskaFilharmonijaUI.View.PosetilacView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:BeogradskaFilharmonijaUI.View     5   	     � Title$  PosetilacView��5   	   $	��630��6   $	��650��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N   .��5	      � ��5
   
   �� 5       �� ImageSource$` ZC:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\BeogradskaFilharmonijaUI\muzika.jpg��6   .+�5   
   �� $��	Posetioci��6   $��30(�6%   
���   �$
��Bold"�6F   $
��Wrap=�6X    �� TextAlignment$ Center=�6l   $��10,33,10,509q�6�   �� 5   
   $��Dodaj��6   
���<��$��4q�67   $��25(�6K   
���   �$
��Bold"�6l   
������ $
��Left=�6�   $��
10,438,0,0q�6�   $	��Top=�6�   $	��165��6�   $��45��6�   ��6�   �� *Dodaj+�� 5   
   $��Obrisi��6   $��25(�6"   
���<��$��4q�6F   
���   �$
��Bold"�6m   
������ $
��Left=�6�   $��442,438,0,0q�6�   $	��Top=�6�   $	��165��6�   $��45��6�   ��6�   �� *Obrisi+&   System.Windows.Controls.DataGrid  5   
   
���<��$��2q�6)      AutoGenerateColumns .  $	��280��6�   $
��Left=�6�   $��
10,130,0,0q�6�   $	��Top=�6�   $	��617��6     SelectionMode$ Single=�6#     
IsReadOnly . ��6=   ��  �� Path$ Lista�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� SelectedItem
 6�   �� *
Izabrani+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Brojac��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *brckar+5      �� 5   
   -   5         ��Name$ textBlockIspis��5      
�������$��20(�6?   $
��Wrap=�6M   $ Center=�6a   $��10,507,17,29q�6x   5      5      