   M S B A M L   `   `   `  ����S  OBeogradskaFilharmonijaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BeogradskaFilharmonijaUI.ViewBeogradskaFilharmonijaUI.View  5   	   4    .BeogradskaFilharmonijaUI.View.Sef_dirigentView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:BeogradskaFilharmonijaUI.View     5   	     � Title$  Sef_dirigentView��5   	   $	��650��6"   $	��650��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      � ��5
   
   �� 5       �� ImageSource$` ZC:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\BeogradskaFilharmonijaUI\muzika.jpg��6   .+�5   
   �� $��Sef dirigent��6   
���   �$
��Bold"�6;   $��30(�6M   $
��Wrap=�6[    �� TextAlignment$ Center=�6o   $��10,33,10,522q�6�   �� 5      $��Dodaj��6   
���   �$��25(�6.   $
��Bold"�6<   
���<��$��4q�6d   
������ $
��Left=�6�   $��
10,441,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Dodaj+{�6
  �� *
Dostupnost+�� 5      $��Obrisi��6   
���   �$��25(�6/   $
��Bold"�6=   
���<��$��4q�6e   
������ $
��Left=�6�   $��442,441,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Obrisi+{�6  �� *
Dostupnost+�� 5      $��Izmeni��6   
���   �$��25(�6/   $
��Bold"�6=   
���<��$��4q�6e   
������ $
��Left=�6�   $��229,441,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Izmeni+{�6  �� *
Dostupnost+&   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns .  $	��280��6�   $
��Left=�6�   $��
10,130,0,0q�6�   $	��Top=�6�   $	��617��6�      SelectionMode$ Single=�6�      
IsReadOnly . ��6   ��  �� Path$ Lista�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� SelectedItem
 6[   �� *
Izabrani+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *iddir+  5      $	 Ime��6%   $ * 62    6<   �� *imed+  5      $ Prezime��6%   $ * 66    6@   �� *	prezdir+5      �� 5   
   -   5         ��Name$ textBlockIspis��5      
�������$��20(�6?   $
��Wrap=�6M   $ Center=�6a   $��17,531,10,30q�6x   5      5      