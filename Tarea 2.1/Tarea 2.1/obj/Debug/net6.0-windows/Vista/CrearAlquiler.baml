   M S B A M L   `   `   `  ����D  @Tarea 2.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Tarea_2._1.VistaTarea_2._1.Vista  5   	   $    Tarea_2._1.Vista.CrearAlquiler   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Tarea_2._1.Vista     5   	     � Title$  CrearAlquiler��5   	   $	��450��6   $	��800��6,    � 	Resources 5	       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%�   '��       �� 5
   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  �@�ToolTip 5      ��  �� *self+$)	 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � .+�5   
   �� $��Vehiculo��6   $
��Left=�6#   $��	40,27,0,0q�6>   $	��Top=�6Q   �� 5   
   -   5        
 ��Name$
 comboVehiculos��5      $
��Left=�6�   $��	42,58,0,0q�6�   $	��Top=�6�   $	��120��6�    �� Text 6O   �� $	 Alquiler.Vehiculo� �� NotifyOnValidationError$
 True�� �� ValidatesOnDataErrors$
 True��6�   �� 5   
   $��Cliente��6   $
��Left=�6"   $��
212,27,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5        $
 comboClientes��5      $
��Left=�6�   $��
212,58,0,0q�6�   $	��Top=�6�   $	��120��6�    6N   �� $	 Alquiler.Cliente�$
 True��$
 True��6�   �� 5   
   $��Precio Total��6   $
��Left=�6'   $��	40,90,0,0q�6B   $	��Top=�6U   �� 5   
   -   5        $
��Left=�5   �   $��
40,116,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 PrecioTotal�$
 True��$
 True��6�   �� 5   
   $��Fianza��6   $
��Left=�6!   $��
212,90,0,0q�6<   $	��Top=�6P   �� 5    
   -   5        $
��Left=�5    �   $��212,116,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 Fianza�$
 True��$
 True��6�   �� 5"   
   .+�5#      �� $��Tipo de Seguro��6   $
��Left=�6-   $��
41,139,0,0q�6H   $	��Top=�6\   	� 5$      -   5         	�Name$ 
todoRiesgo��5$      $��Todo riesgo��6.    d� 	IsChecked$
 TrueY�6D   $��18��6U   $	��718��6a   	� 5%      -   5        $ terceros��5%      $��Terceros��6,   $��18��6?   $	��718��6K   5&      �� 5(   
   $��Estado del coche��6   $
��Left=�6+   $��212,139,0,0q�6F   $	��Top=�6[   �� 5)   
   -   5        $
��Left=�5)   �   $��212,165,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��21��6�   ��66   �� $	 EstadoVehiculo�$
 True��$
 True��6�   �� 5+   
   $��	Km Inicio��6   $
��Left=�6$   $��
40,191,0,0q�6?   $	��Top=�6S   �� 5,   
   -   5        $
��Left=�5,   �   $��
40,217,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 KmInicio�$
 True��$
 True��6�   �� 5.   
   $��Km Fin��6   $
��Left=�6!   $��210,191,0,0q�6<   $	��Top=�6Q   �� 5/   
   -	   5        $
��Left=�5/   �   $��212,217,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��66   �� $	 KmFin�$
 True��$
 True��6�   �� 51   
   $��	Fecha Fin��6   $
��Left=�6$   $��210,240,0,0q�6?   $	��Top=�6T   (  "System.Windows.Controls.DatePicker  52   
   -
   5          Name$ calendarioFin��52      $
��Left=�6�   $��212,270,0,0q�6�   $	��Top=�6�      SelectedDate 6Q   �� $	 FechaFin�$
 True��$
 True��6�   �� 54   
   $��Fecha Inicio��6   $
��Left=�6'   $��
40,240,0,0q�6B   $	��Top=�6V     55   
   -   5        $ calendarioInicio��55      $
��Left=�6�   $��
41,270,0,0q�6�   $	��Top=�6�    6T   �� $	 FechaInicio�$
 True��$
 True��6�   �� 57   
   -   5         ��Name$ anadirBoton��57      $��Crear��6&   $
��Left=�66   $��138,334,0,0q�6Q   $	��Top=�6f   6~   59      5:      