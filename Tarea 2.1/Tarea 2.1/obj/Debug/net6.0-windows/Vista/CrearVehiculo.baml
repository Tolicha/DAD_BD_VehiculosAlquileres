   M S B A M L   `   `   `  ����D  @Tarea 2.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Tarea_2._1.VistaTarea_2._1.Vista  5   	   $    Tarea_2._1.Vista.CrearVehiculo   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Tarea_2._1.Vista     5   	     � Title$  CrearVehiculo��5   	   $	��450��6   $	��800��6,    � 	Resources 5
       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%�   '��       �� 5   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  �@�ToolTip 5      ��  �� *self+$)	 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � .+�5   
   �� $��	Matricula��6   $
��Left=�6$   $��	40,27,0,0q�6?   $	��Top=�6R   �� 5   
   -   5        $
��Left=�5   �   $��	40,58,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 	Matricula� �� NotifyOnValidationError$
 True�� �� ValidatesOnDataErrors$
 True��6�   �� 5   
   $��Bastidor��6   $
��Left=�6#   $��
212,27,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $
��Left=�5   �   $��
212,58,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 Bastidor�$
 True��$
 True��6�   �� 5   
   $��Marca��6   $
��Left=�6    $��	40,90,0,0q�6;   $	��Top=�6N   �� 5   
   -   5        $
��Left=�5   �   $��
40,116,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 Marca�$
 True��$
 True��6�   �� 5    
   $��Modelo��6   $
��Left=�6!   $��
212,90,0,0q�6<   $	��Top=�6P   �� 5!   
   -   5        $
��Left=�5!   �   $��212,116,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 Modelo�$
 True��$
 True��6�   �� 5#   
   $��Plaza��6   $
��Left=�6    $��
41,139,0,0q�6;   $	��Top=�6O   �� 5$   
   -   5         ��Name$ comboboxPlazas��5$      $
��Left=�6�   $��
40,165,0,0q�6�   $	��Top=�6�   $��56��6�    �� Text 6O   �� $	 Plaza�$
 True��$
 True��6�   �� 5&   
   $��
Precio €��6   $
��Left=�6#   $��212,139,0,0q�6>   $	��Top=�6S   �� 5'   
   -   5        $
��Left=�5'   �   $��212,165,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $��53��6�   ��66   �� $	 Precio�$
 True��$
 True��6�   �� 5)   
   $��Depósito (L)��6   $
��Left=�6'   $��
40,191,0,0q�6B   $	��Top=�6V   �� 5*   
   -   5        $
��Left=�5*   �   $��
40,217,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 Deposito�$
 True��$
 True��6�   �� 5,   
   $��Km��6   $
��Left=�6   $��210,191,0,0q�68   $	��Top=�6M   �� 5-   
   -   5        $
��Left=�5-   �   $��212,217,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 Km�$
 True��$
 True��6�   �� 5/   
   $��Tipo de Vehículo��6   $
��Left=�6+   $��
41,240,0,0q�6F   $	��Top=�6Z   �� 50   
   -	   5        $ comboTipoVehiculo��50      $
��Left=�6�   $��
42,271,0,0q�6�   $	��Top=�6�   $	��120��6   6R   �� $	 Vehiculo.TipoVehiculo�$
 True��$
 True��6  �� 52   
   $��Fecha próxima ITV��6   $
��Left=�6,   $��210,240,0,0q�6G   $	��Top=�6\   (  "System.Windows.Controls.DatePicker  53   
   -
   5          Name$ 
calendario��53      $
��Left=�6�   $��212,270,0,0q�6�   $	��Top=�6�      SelectedDate 6N   �� $	 CaducidadITV�$
 True��$
 True��6�   �� 55   
   -   5         ��Name$ anadirBoton��55      $��Crear��6&   $
��Left=�66   $��138,334,0,0q�6Q   $	��Top=�6f   6~   57      58      