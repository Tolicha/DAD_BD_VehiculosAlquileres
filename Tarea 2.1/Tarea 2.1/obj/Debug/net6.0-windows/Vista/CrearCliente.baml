   M S B A M L   `   `   `  ����D  @Tarea 2.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Tarea_2._1.PaginasTarea_2._1.Paginas  5   	   %    Tarea_2._1.Paginas.CrearCliente   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Tarea_2._1.Paginas     5   	     � Title$  CrearCliente��5   	   $	��400��6   $	��520��6+    � 	Resources 5	       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%�   '��       �� 5
   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  �@�ToolTip 5      ��  �� *self+$)	 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � .+�5   
   �� $��Nombre��6   $
��Left=�6!   $��	50,30,0,0q�6<   $	��Top=�6O   �� 5   
   -   5        $
��Left=�5   �   $��	50,60,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��66   �� $	 Nombre� �� NotifyOnValidationError$
 True�� �� ValidatesOnDataErrors$
 True��6�   �� 5   
   $	��Nif��6   $
��Left=�6   $��
50,100,0,0q�69   $	��Top=�6M   �� 5   
   -   5        $
��Left=�5   �   $��
50,130,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��66   �� $		 Nif�$
 True��$
 True��6�   �� 5   
   $��Telefono��6   $
��Left=�6#   $��
50,170,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $
��Left=�5   �   $��
50,200,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��66   �� $	 Telefono�$
 True��$
 True��6�   �� 5   
   $��Email��6   $
��Left=�6    $��
50,240,0,0q�6;   $	��Top=�6O   �� 5    
   -   5        $
��Left=�5    �   $��
50,270,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��66   �� $	 Email�$
 True��$
 True��6�   �� 5"   
   $��Fecha de nacimiento��6   $
��Left=�6.   $��
300,30,0,0q�6I   $	��Top=�6]   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ calendarioNacimiento��5#      $
��Left=�6�   $��
300,60,0,0q�6�   $	��Top=�6�   $	��150��6	     SelectedDate 6X   �� $	 FechaNacimiento�$
 True��$
 True��6	  �� 5%   
   $��Tipo de Carnet��6   $
��Left=�6)   $��300,100,0,0q�6D   $	��Top=�6Y   �� 5&   
   -   5         ��Name$ comboTipoCarnet��5&      $
��Left=�6�   $��300,130,0,0q�6�   $	��Top=�6�   $	��150��6�    �� Text 6P   �� $	 Carnet.TipoCarnet�$
 True��$
 True��6�   �� 5(   
   $��Fecha de expedición��6   $
��Left=�6.   $��300,170,0,0q�6I   $	��Top=�6^     5)   
   -   5        $ calendarioExpedicion��5)      $
��Left=�6�   $��300,200,0,0q�6�   $	��Top=�6�   $	��150��6   6X   �� $	 Carnet.FechaExpedicion�$
 True��$
 True��6  �� 5+   
   $��Fecha de caducidad��6   $
��Left=�6-   $��300,240,0,0q�6H   $	��Top=�6]     5,   
   -   5        $ calendarioCaducidad��5,      $
��Left=�6�   $��300,270,0,0q�6�   $	��Top=�6�   $	��150��6   6W   �� $	 Carnet.FechaCaducidad�$
 True��$
 True��6  �� 5.   
   -	   5         ��Name$ anadirBoton��5.      $��Crear��6&   $
��Left=�66   $��370,330,0,0q�6Q   $	��Top=�6f   $��75��6�   50      51      