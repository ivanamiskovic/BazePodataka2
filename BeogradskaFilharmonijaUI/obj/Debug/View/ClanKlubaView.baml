   M S B A M L   `   `   `  ����S  OBeogradskaFilharmonijaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BeogradskaFilharmonijaUI.ViewBeogradskaFilharmonijaUI.View  5   	   1    +BeogradskaFilharmonijaUI.View.ClanKlubaView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:BeogradskaFilharmonijaUI.View     5   	     � Title$  ClanKlubaView��5   	   $	��630��6   $	��650��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N   .��5	      � ��5
   
   �� 5       �� ImageSource$` ZC:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\BeogradskaFilharmonijaUI\muzika.jpg��6   .+�5   
   �� $��
Clan kluba��6   
���   �$��30(�69   $
��Bold"�6G   $
��Wrap=�6Y    �� TextAlignment$ Center=�6m   $��10,34,10,527q�6�   �� 5      $��Dodaj��6   
���� ��$��4q�60   
���   �$��25(�6W   $
��Bold"�6e   
������ $
��Left=�6�   $��
10,435,0,0q�6�   $	��Top=�6�   $	��165��6�   $��45��6�   ��6�   �� *Dodaj+{�6	  �� *
Dostupnost+�� 5      $��Obrisi��6   
���� ��$��4q�61   
���   �$��25(�6X   $
��Bold"�6f   
������ $
��Left=�6�   $��462,435,0,0q�6�   $	��Top=�6�   $	��165��6�   $��45��6�   ��6�   �� *Obrisi+{�6  �� *
Dostupnost+&   System.Windows.Controls.DataGrid  5   
   
���<��$��2q�6)      AutoGenerateColumns .  $	��280��6�   $
��Left=�6�   $��	5,130,0,0q�6�   $	��Top=�6�   $	��629��6     SelectionMode$ Single=�6"     
IsReadOnly . ��6=   ��  �� Path$ Lista�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� SelectedItem
 6�   �� *
Izabrani+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Sifra��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *sfr+  5      $
 JMBG��6%   $ * 63    6=   �� *jmbg+  5      $	 Ime��6%   $ * 62    6<   �� *imeck+  5      $ Prezime��6%   $ * 66    6@   �� *prezck+  5      $ Korisnicko ime��6%   $ * 6=    6G   �� *korime+  5      $ Datum rodjenja��6%   $ * 6=    6G   �� *	datrodj+  5      $ ID posetioica��6%   $ * 6<    6F   �� *posetilac_brckarte+5      �� 5   
   -   5         ��Name$ textBlockIspis��5      
���   �$��20(�6?   $
��Wrap=�6M   $ Center=�6a   $��10,525,16,0q�6x   $��52��6�   $	��Top=�6�   5!      5"      