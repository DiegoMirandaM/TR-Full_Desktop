   M S B A M L   `   `   `  ????N  JTurismoReal_Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TurismoReal_DesktopTurismoReal_Desktop  5   	   0    *TurismoReal_Desktop.ServiciosExtra_Asociar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:TurismoReal_Desktop     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  6B   $	??570??5
   	   $	??950??6   $	??570??5   	   $	??950??6     ? WindowStartupLocation$  CenterScreen=?5   	    ? Title$: 4Relacionar servicio con departamentos - Turismo Real??5   	   (  "MahApps.Metro.Controls.MetroWindow   WindowTitleBrush ?#fe7a4a
???   ?
???????   TitleCharacterCasing$ Normal=?6?   .??5      ?  ? ShowGridLines .   ? ColumnDefinitions 5   
   ?? 5      $??0.19* ?6   ?? 5      $
??1.7* ?6   ?? 5      $
??0.5* ?6   ?? 5      $
??0.1* ?6   ?? 5      $
??0.5* ?6   ?? 5      $??0.19* ?6    ? RowDefinitions 5   
   ?? 5      $
??0.1* ?6   ?? 5      $
??0.5* ?6   ?? 5      $
??0.3* ?6   ?? 5      $
??0.3* ?6   ?? 5      -   5         ?Name$ rd_datagrid??5      $??2* ?6/   ?? 5       $
??0.3* ?6   ?? 5!      $
??0.4* ?6   ?? 5"      $
??0.2* ?6   .+?5%   
   ?? -   5        $??btn_retroceder??5%   I       MahApps.Styles.Button.Circle#???   6   $??0??6_   $??1??6o   $??55??6|   $??55??6?   $??Center=?6?   $??Center=?6?   .??5&      "  FontAwesome.WPF.ImageAwesome     Icon$ SignOut=?6   $??40??6-   	   Rotation$		 180Q?68   
   
Foreground
 ?#fe7a4a6G   5'      ?? 5)   
   $??1??6   $??1??6   $(??"Relación servicio - departamentos??6-   $
??Left=?6Y   $??Center=?6t   $??29(?6?   $
??Bold"?6?   ???#fe7a4a6?   ?? 5*   
   $??2??6   $??1??6   $,??&Por favor, especifique disponibilidad.??6-   $
??Left=?6^   $??Center=?6y   $??14(?6?   $??Medium"?6?   ???#04aba36?   ?? 5+   
   -   5        $??lb_selectedServicio??5+      $??3??6+   $??1??68   $??Label generada??6H   $
??Left=?6a   $??Center=?6|   $??14(?6?   $??Medium"?6?   ???#04aba36?   &   System.Windows.Controls.DataGrid  5-   
   -   5        $??dg_relacionDptos??5-      $??4??6+   $??1??68   $??4??6H   
???????   AutoGenerateColumns .     GridLinesVisibility$	 All=?6?      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .    CanUserSortColumns .     Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre??6@      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.9* 6P      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *NOMBRE+6]     50      $ 
Dirección??6C   $
 0.9* 6V    .  6%   ?? *	DIRECCION+6c     51      $ Núm. Depto??6B   $
 0.5* 6V    .  6%   ?? *
NRO_DPTO+6c     52      $ Ciudad??6O   $
 0.7* 6_    .  6%   ?? *Negocio_Ciudad.NOMBRE+6l   4  .System.Windows.Controls.DataGridCheckBoxColumn  53      $ ¿Ofrecido aquí???6K   $
 0.6* 6d    6)   ?? *disp_asociado+6d     54      $ ¿Disponible???6M   $
 0.6* 6c    6)   ?? *disp_habilitado+6c   56      (? 5@   
   $??2??6   $??6??6"    (? Stretch$ Uniform=?6/   $??Center=?6A   $??55??6^   .??5A      ?? -   5        $??btn_cancelar??5A      $??Cancelar??6)   $??Center=?6<   ???#fe7a4a$??80??6m   
??????????#fe7a4a$??DemiBold"?6?   $??8(?6?   +	  %MahApps.Metro.Controls.ControlsHelper 	  ContentCharacterCasing$ Normal=?6?   6?   5B      (? 5D   
   $??4??6   $??6??6"   $ Uniform=?6/   $??Center=?6A   $??55??6^   .??5E      ?? -   5        $??btn_guardarCambios??5E      $??Guardar cambios??6/   $??Center=?6I   ???#fe7a4a$??80??6z   ???#fe7a4a
???????$??DemiBold"?6?   $??8(?6?   $ Normal=?6?   6  5F      5I      5L      