   M S B A M L   `   `   `  ����T  P300871455(Baten)_Example3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:_300871455_Baten__Example3_300871455_Baten__Example3  5   	   +    %_300871455_Baten__Example3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:_300871455_Baten__Example3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,0.333,-3.333q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��gridview��5
   ;   $
��Left=�6   $	��143��6.      AlternatingRowBackground
 �P��$��	26,28,0,0q�6�   $	��Top=�6�   $	��416��6     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Company��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *CName+6R     5      $
 Name��6%    63   �� *Name+6N     5      $ Title��6%    64   �� *Title+6P     5      $ Address��6%    66   �� *Adress+6S     5      $
 City��6%    63   �� *City+6N     5      $ Country��6%    66   �� *	Country+6T   5      �� 5   
   -   5        $��Cname��5   M   $
��Left=�6   $��23��6-   $��
629,28,0,0q�69    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $
��name��5   M   $
��Left=�6   $��23��6-   $��
629,75,0,0q�69   $
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $��title��5   N   $
��Left=�6   $��23��6-   $��629,128,0,0q�69   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $��address��5   N   $
��Left=�6   $��23��6-   $��629,171,0,0q�69   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $
��city��5   N   $
��Left=�6   $��23��6-   $��629,225,0,0q�69   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $��country��5   N   $
��Left=�6   $��23��6-   $��629,274,0,0q�69   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   $
��Name��6   $
��Left=�6   $��
485,72,0,0q�6:   $	��Top=�6N   �� 5   
   $��Title��6   $
��Left=�6    $��485,125,0,0q�6;   $	��Top=�6P   �� 5   
   $��Address��6   $
��Left=�6"   $��485,169,0,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ 0.478,-1.308&�6j   �� 5   
   $��Company��6   $
��Left=�6"   $��
485,33,0,0q�6=   $	��Top=�6Q   �� 5    
   $
��City��6   $
��Left=�6   $��485,222,0,0q�6:   $	��Top=�6O   �� 5!   
   $��Country��6   $
��Left=�6"   $��485,274,0,0q�6=   $	��Top=�6R   �� 5"   
   -   5        $	��Add��5"      $
��Left=�6   $��634,340,0,0q�6O   $	��Top=�6d   $��75��6|   5$      5%      