   M S B A M L   `   `   `  ????G  CSuper_Market, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Super_MarketSuper_Market  5          Super_Market.Store   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Super_Market     5      .??5
      (? .??5   
   ??   ?? CornerRadius$  35??6    ?? Padding$ 40q?6#   
??????? J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q?6#      
BlurRadius$ 20Q?63      Opacity$	 0.4Q?6C   6S   ._?5      ? $
??1100??6   $	??850??6     ? ColumnDefinitions 5      ?? 5      $	??650 ?6'   65   ?? 5      6)    ? RowDefinitions 5      ?? 5      $	??100 ?6$   63   ?? 5      $	??100 ?6%   64   ?? 5      $??* ?6$   61   .+?5      ?? $??0??6    ?? Orientation$ 
Horizontal=?6*   $??50??6C   $	??Top=?6O   .+?5      ?? $	??160??6   $	??100??6(   $??30(?66   .??6E   
StoreName:6Q   ?? 5      -   5        $??txtstor??5      $??30(?6-   ???	#FF5ABA9A$??
10,0,100,0q?6R   $	??300??6g   ??6s   ?? 	 ?? ElementName$	 datagrid??
 ?? Path$
 SelectedItem.Name?6?   5      ?? 5      $??1??6   $ 
Horizontal=?6-   $??50??6F   $	??Top=?6R   .+?5       ?? $	??125??6   $	??100??6(   $??30(?66   .??6E   	Location:6P   ?? 5!      -   5        $??txtloc??5!      $??30(?6,   ???	#FF5ABA9A$??
10,0,100,0q?6Q   $	??270??6f   ??6r   ?? $	 datagrid??$
 SelectedItem.Location?6?   5"      ?? 5$      $??2??6   $??1??61   $ 
Horizontal=?6>   $??50??6W   $	??Top=?6c   $??Center=?6{   $??0,0,0,0q?6?   .+?5%      ?? -   5        $??25(?5%      $??	30,0,70,0q?6+   $	??200??6>   $??50??6J   ???	#FF5ABA9A.??6?   Add6?   ?? 5&      -   5        $??25(?5&      $??	30,0,70,0q?6+   $	??200??6?   $??50??6K   ???	#FF5ABA9A.??6?   Save6?   ?? 5'      -   5        $??25(?5'      $??	30,0,70,0q?6+   $	??200??6>   $??50??6J   ???	#FF5ABA9A.??6?   delete6?   5(      &   System.Windows.Controls.DataGrid  5+      -   5        $??datagrid??5+         
IsReadOnly$
 True??6+   $??2??6?   $??2??6L      AutoGenerateColumns$ False??6?    ? 	Resources 5,      =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%   '        ?? 5-      "  6    .?5.      ??  ? ??
 ???@?6O   ?? 5/       ? ??$ SemiBold"?6;   6N   ?? 50       ? ??$ 0,0,1,2q?6@   6R   ?? 51       ? ??$ 30(?69   6F   ?? 52       ? ??
 ? ? ?6L   53      54         Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56         FontSize$ 40Q?6-   ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6<      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6T   ?? $
 Id?6r     57      $ 40Q?6-   $
 Name??6<   $	 200 6J    6V   ?? $

 Name?6v     58      $ 40Q?6-   $ Location??6<   $ * 6N    6X   ?? $
 Location?6|   5:      5B      5C      5D      5E      