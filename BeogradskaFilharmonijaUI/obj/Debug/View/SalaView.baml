   M S B A M L   `   `   `  ����S  OBeogradskaFilharmonijaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BeogradskaFilharmonijaUI.ViewBeogradskaFilharmonijaUI.View  5   	   ,    &BeogradskaFilharmonijaUI.View.SalaView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:BeogradskaFilharmonijaUI.View     5   	     � Title$  SalaView��5   	   $	��650��6   $	��660��6'    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I   .��5	      � ��5
   
   �� 5       �� ImageSource$` ZC:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\BeogradskaFilharmonijaUI\muzika.jpg��6   .+�5   
   �� $
��Sale��6   
���   �$��30(�63   $
��Bold"�6A   $
��Wrap=�6S    �� TextAlignment$ Center=�6g   $��10,40,10,520q�6~   $��2��6�   �� 5      $��Dodaj��6   
���<��$��4q�61   
���   �$��25(�6X   $
��Bold"�6f   
������ $
��Left=�6�   $��
10,431,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Dodaj+{�6
  �� *
Dostupnost+�� 5      $��Obrisi��6   
���<��$��4q�62   
���   �$��25(�6Y   $
��Bold"�6g   
������ $
��Left=�6�   $��456,431,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Obrisi+{�6  �� *
Dostupnost+�� 5      $��Izmeni��6   
���<��$��4q�62   
���   �$��25(�6Y   $
��Bold"�6g   
������ $
��Left=�6�   $��228,431,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Izmeni+{�6  �� *
Dostupnost+&   System.Windows.Controls.DataGrid  5   
   
���<��$��2q�6)      AutoGenerateColumns .  $	��280��6�   $
��Left=�6�   $��
10,130,0,0q�6�   $	��Top=�6�   $	��631��6     SelectionMode$ Single=�6#     
IsReadOnly . $��2��6L  ��6=   ��  �� Path$ Lista�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� SelectedItem
 6�   �� *
Izabrani+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *idsal+  5      $ Broj sedista��6%   $ * 6;    6E   �� *brsed+  5      $ Velicina scene��6%   $ * 6=    6G   �� *velsce+  5      $ 
Id dvorane��6%   $ * 69    6C   �� *dvorana_iddvor+5      �� 5   
   -   5         ��Name$ textBlockIspis��5      
�������$��20(�6?   $
��Wrap=�6M   $ Center=�6a   $��16,541,10,0q�6x   $��70��6�   $	��Top=�6�   $��2��6�   5      5       