   M S B A M L   `   `   `  ����S  OBeogradskaFilharmonijaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BeogradskaFilharmonijaUI.ViewBeogradskaFilharmonijaUI.View  5   	   -    'BeogradskaFilharmonijaUI.View.KartaView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:BeogradskaFilharmonijaUI.View     5   	     � Title$  	KartaView��5   	   $	��650��6   $	��800��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J   .��5	      � ��5
   
   �� 5       �� ImageSource$` ZC:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\BeogradskaFilharmonijaUI\muzika.jpg��6   .+�5   
   �� $��Karte��6   
���   �$��30(�64   $
��Bold"�6B   $
��Wrap=�6T    �� TextAlignment$ Center=�6h   $��10,30,10,527q�6   �� 5   
   $��Dodaj��6   
���<��$��4q�67   
���   �$��25(�6^   $
��Bold"�6l   
������ $
��Left=�6�   $��
10,435,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Dodaj+{�6  �� *
Dostupnost+�� 5   
   $��Obrisi��6   
���<��$��4q�68   
���   �$��25(�6_   $
��Bold"�6m   
������ $
��Left=�6�   $��392,435,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *Obrisi+{�6  �� *
Dostupnost+&   System.Windows.Controls.DataGrid  5   
   
���<��$��4q�6)      AutoGenerateColumns .  $	��280��6�   $
��Left=�6�   $��
10,130,0,0q�6�   $	��Top=�6�   $	��567��6     SelectionMode$ Single=�6#     
IsReadOnly . ��6=   ��  �� Path$ Lista�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� SelectedItem
 6�   �� *
Izabrani+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *br+  5      $	 Red��6%   $ * 62    6<   �� *red+  5      $ Sediste��6%   $ * 66    6@   �� *sed+  5      $ Dan izvodjenja��6%   $ * 6=    6G   �� *daniz+  5      $ Sat izvodjenja��6%   $ * 6=    6G   �� *satiz+  5      $
 Cena��6%   $ * 63    6=   �� *cen+5      �� 5   
   -   5         ��Name$ textBlockIspis��5      
�������$��20(�6?   $
��Wrap=�6M   $ Center=�6a   $��10,559,17,5q�6x   �� 5    
   $��Center=�6   $
��Tip:��64   
������ 
���  ��$��22(�6q   $
��Bold"�6   $��582,79,10,494q�6�   �� 5!   
   -   5         ��Name$ tipComboBox��5!      $��22(�6(   $
��Bold"�66   $��582,132,10,414q�6H    �� SelectedValue 6`   �� $ 	FilterTip�.@�5"      �� -   5        $	��Red��5"      .��6&   Red6+   �� 5#      -   5        $��Sediste��5#      .��6*   	Sediste63   �� 5$      -   5        $	��Dan��5$      .��6&   Dan6+   �� 5%      -   5        $	��Sat��5%      .��6&   Sat6+   �� 5&      -   5        $
��Cena��5&      .��6'   Cena6-   5'      �� 5(   
   -   5         ��Name$ filterTextBox��5(       �� TextWrapping$
 Wrap=�6)   $��22(�6=   $
��Bold"�6K   $��582,225,10,317q�6]   �� 5)   
   $��	Filtriraj��6   
���<��$��4q�6;   
���   �$��25(�6b   $
��Bold"�6p   
������ $
��Left=�6�   $��592,346,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *	Filtriraj+{�6  �� *
Dostupnost+�� 5*   
   $��Prebaci u fajl��6   
���<��$��4q�6@   
���   �$��25(�6g   $
��Bold"�6u   
������ $
��Left=�6�   $��592,435,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6   �� *PrebaciUFajl+{�6!  �� *
Dostupnost+5+      5,      