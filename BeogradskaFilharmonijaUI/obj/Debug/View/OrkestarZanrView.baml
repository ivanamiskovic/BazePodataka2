   M S B A M L   `   `   `  ����S  OBeogradskaFilharmonijaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BeogradskaFilharmonijaUI.ViewBeogradskaFilharmonijaUI.View  5   	   4    .BeogradskaFilharmonijaUI.View.OrkestarZanrView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:BeogradskaFilharmonijaUI.View     5   	     � Title$  OrkestarZanrView��5   	   $	��350��6"   $	��600��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      � ��5
   
   �� 5       �� ImageSource$` ZC:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\BeogradskaFilharmonijaUI\muzika.jpg��6   .+�5   
   �� $��Zanr :��6   
���   �$
��Bold"�64   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $��55��6�   �� 5   
   -   5         ��Name$ textBox��5      
���<��$��2q�69   $
��Left=�6M   $��23��6h   $��
105,13,0,0q�6t    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��177��6�   6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Wrap=�6'    �� TextAlignment$ Center=�6;   
���   �$
��Left=�6e   $	��Top=�6�   $��	10,41,0,0q�6�   $	��272��6�   $��25��6�   �� 5   
   -   5         ��Name$ pronadji��5      
���<��$��4q�69   
���   �$
��Bold"�6`   
������ $��Pronadji��6�   $
��Left=�6�   $��	299,2,0,0q�6�   $	��Top=�6�   $	��272��6�   $��34��6�   6�   �� 5   
   -   5        $ 
textBlock1��5      $
��Wrap=�6(   $ Center=�6<   
���  ��$
��Left=�6d   $	��Top=�6   $��
299,41,0,0q�6�   $	��272��6�   $��25��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dataGrid��5   ;   
���   �$��2q�6'   
   AutoGenerateColumns
 .  $	��174��6i   $
��Left=�6v   $��	10,71,0,0q�6�   $	��Top=�6�   $	��565��6�      SelectionMode$ Single=�6�      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *id+  5      $	 Ime��6%   $ * 62    6<   �� *imeork+  5      $ Prezime��6%   $ * 66    6@   �� *brclan+5      5      5      