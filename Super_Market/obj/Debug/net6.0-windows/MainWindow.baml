   M S B A M L   `   `   `  ????G  CSuper_Market, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Super_MarketSuper_Market  5   	       Super_Market.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   (localclr-namespace:Super_Market   5   	     ? Title$  Admin??5
   	   $	??600??6   $
??1000??6$    ? AllowsTransparency$
 True??5   	    ? WindowStyle$
 None=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? 
ResizeMode$ CanResizeWithGrip=?5   	   ??5   	   Z?  ? 	Resources 5      ??%    5      .??5      (? .??5   
   ??  ?? CornerRadius$ 25??6    ?? Padding$ 10q?6#   ???	#FF5ABA9A._?5      ? $	??600??6   $
??1000??6     ? ColumnDefinitions 5      ?? 5      $??0.27* ?6'   67   ?? 5      6)   .+?5       ?? $ 25??6   
???????	 J? Effect	 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"      
   ShadowDepth$
 1Q?6+      
BlurRadius$ 20Q?6;      Opacity$	 0.4Q?6K   6[   ._?5)      ?? $??5q?6!   $??Center=?6,   .+?5*      ?? $ 25??6	   
???????$??0 0 0 19q?6.   ._?5,      ??  ?? Padding$ 40 0 0 0q?6(   ???	#FF5ABA9A$
??Bold"?6R   $??30(?6d   $	??210??6r   ?? 6?   $?Admin??6?   6?   5.      ?? 5/      .@?50      ?? -   5        ???	#FF5ABA9A$??15q?50   B    '  #MaterialDesignNavigationListBoxItem#??[  6t   .??51   "   ??  ?? Orientation$ 
Horizontal=?6.   .+?52   &   .  (MahApps.Metro.IconPacks.PackIconMaterial  $??30??6<   $??25??6G      Kind$
 Home=?6T   $
??Bold"?6`   6t   ?? 53   &   $ 8 0 0 0q?60   $??18(?6B   $
??Bold"?6P   Home6h   54   #   55      ?? 56      -   5        ???	#FF5ABA9A$??15q?56   B   #??[  6r   .??57   "   ?? $ 
Horizontal=?6.   .+?58   &     $??30??6<   $??25??6G   $ Store=?6S   $
??Bold"?6`   6t   ?? 59   &   $ 8 0 0 0q?60   $??18(?6B   $
??Bold"?6P   Stores6j   5:   #   5;      ?? 5<      -   5        ???	#FF5ABA9A$??15q?5<   B   #??[  6k   .??5=   "   ?? $ 
Horizontal=?6-   .+?5>   &     $??30??6<   $??25??6G   $ Group=?6S   6b   ?? 5?   &   $ 8 0 0 0q?60   $??18(?6B   $
??Bold"?6P   
Categories6o   5@   #   5A      ?? 5B      -   5        ???	#FF5ABA9A$??15q?5B   B   #??[  6s   .??5C   "   ?? $ 
Horizontal=?6-   .+?5D   &     $ Reproduction=?6<   6R   ?? 5E   &   $ 8 0 0 0q?60   $??18(?6B   $
??Bold"?6P   
Products6m   5F   #   5G      ?? 5H      -   5        ???	#FF5ABA9A$??15q?5H   B   #??[  6s   .??5I   "   ?? $ 
Horizontal=?6-   .+?5J   &     $??30??6<   $??25??6G   $ 
Salesforce=?6S   6g   ?? 5K   &   $ 8 0 0 0q?60   $??18(?6B   $
??Bold"?6P   Sales6j   5L   #   5M      ?? 5N      -   5        ???	#FF5ABA9A$??15q?5N   B   #??[  6s   .??5O   "   ?? $ 
Horizontal=?6-   .+?5P   &     $??30??6<   $??25??6G   $ ShoppingOutline=?6S   6l   ?? 5Q   &   $ 8 0 0 0q?60   $??18(?6B   $
??Bold"?6P   	Purchases6n   5R   #   5S      ?? 5T      -   5        ???	#FF5ABA9A$??15q?5T   B   #??[  6s   .??5U   "   ?? $ 
Horizontal=?6-   .+?5V   &     $??30??6<   $??25??6G   $ MicrosoftSharepoint=?6S   6p   ?? 5W   &   $ 8 0 0 0q?60   $??18(?6B   $
??Bold"?6P   	Reports6l   5X   #   5Y      ?? 5Z      -   5        ???	#FF5ABA9A$??10q?5Z   B   $??0 10 0 0q?6O   $??Bottom=?6?   #??[  6?   .??5[   "   ?? $ 
Horizontal=?6-   .+?5\   &     $ Logout=?6<   $??30??6J   $??25??6U   ?? 5]   &   $ 8 0 0 0q?60   $??18(?6C   $
??Bold"?6Q   ?? 6d   $?Logout??6h   6y   5^   #   5_      5`      5a      5b      ?? 5d      -	   5        $??stores??5d   !   $??1??6/   .??5e      ?? $
??Fill=?6   $??
/cover.jpg??6+   $??10q?6?   $	??945??6K   $	??798??6W   	 5f        5g      $
 1Q?6/   $ 20Q?6?   $	 0.4Q?6O   6_   5i      5j      5m      5n      5o      5p      