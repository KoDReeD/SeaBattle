   M S B A M L   `   `   `  ????D  @SeaBattle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SeaBattle	SeaBattle  5   	       SeaBattle.Player2Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SeaBattle     5   	     ? Title$  Player2Window??5   	   $	??450??6   $	??800??6,    ? WindowStartupLocation$ CenterScreen=?68    ? 
ResizeMode$ NoResize=?6]    ? WindowStyle$
 None=?6s   .??5	      ? .+?5
   
   ?? $&?? /Resources/ShipSetBackground.jpg??6   $
??Fill=?6:   ?? 5   
   $??Right=?6   $	??Top=?61    ?? Orientation$ 
Horizontal=?5      .+?5      ?? -   5        $??25??5      $??25??6    $??Right=?5      $	??Top=?6-   $??-??5      $??Heavy"?6   $??20(?5      
???iii?5      ?? 5      -   5        $??25??5      $??25??6    $??X??5      $
??Bold"?6   $??16(?5      
???iii?5      5      ?? 5   
   -   5        $??25??5      $??25??6   $??X??5      $
??Bold"?6   $??16(?5      
???iii?5       ?? 5"   
   $ 
Horizontal=?6   $??Center=?6.   .+?5#      ?? $??26(?6   $??Поле игрока: ??6&   
???????$??Heavy"?5$   +   ?? 5%      -   5         ??Name$ TB_PlayerName??5%      $??26(?6/   
???????$??Heavy"?5&   +   5'      ?? 5)   
   $ Vertical=?6   $??Center=?6,   $??Center=?5*      $??30q?60   .+?5+      ?? $ 
Horizontal=?6   $	??330??5,      $??30??6%   $??30,0,0,0q?5-      .+?5/      ?? $??30??6   
???????$??25(?50       ?? TextAlignment$ Center=?6*   $
??Bold"?51      152      ?? 54      $??30??6   
???????$??25(?55      $ Center=?6*   $
??Bold"?56      257      ?? 59      $??30??6   
???????$??25(?5:      $ Center=?6*   $
??Bold"?5;      35<      ?? 5>      $??30??6   
???????$??25(?5?      $ Center=?6*   $
??Bold"?5@      45A      ?? 5C      $??30??6   
???????$??25(?5D      $ Center=?6*   $
??Bold"?5E      55F      ?? 5H      $??30??6   
???????$??25(?5I      $ Center=?6*   $
??Bold"?5J      65K      ?? 5M      $??30??6   
???????$??25(?5N      $ Center=?6*   $
??Bold"?5O      75P      ?? 5R      $??30??6   
???????$??25(?5S      $ Center=?6*   $
??Bold"?5T      85U      ?? 5W      $??30??6   
???????$??25(?5X      $ Center=?6*   $
??Bold"?5Y      95Z      ?? 5\      $??30??6   
???????$??25(?5]      $ Center=?6*   $
??Bold"?5^      105_      5a      ?? 5c      $ 
Horizontal=?6   .+?5d      ?? $ Vertical=?6   $??30??5e      $	??300??6$   .+?5f      ?? $??30??6    
???????$??25(?5g      $ Center=?6*   $
??Bold"?5h      A5i      ?? 5k      $??30??6    
???????$??25(?5l      $ Center=?6*   $
??Bold"?5m      B5n      ?? 5p      $??30??6    
???????$??25(?5q      $ Center=?6*   $
??Bold"?5r       C5s      ?? 5u      $??30??6    
???????$??25(?5v      $ Center=?6*   $
??Bold"?5w       D5x      ?? 5z      $??30??6    
???????$??25(?5{      $ Center=?6*   $
??Bold"?5|       E5}      ?? 5      $??30??6    
???????$??25(?5?      $ Center=?6*   $
??Bold"?5?       F5?      ?? 5?      $??30??6    
???????$??25(?5?      $ Center=?6*   $
??Bold"?5?       J5?      ?? 5?      $??30??6    
???????$??25(?5?      $ Center=?6*   $
??Bold"?5?       H5?      ?? 5?      $??30??6    
???????$??25(?5?      $ Center=?6*   $
??Bold"?5?       I5?      ?? 5?      $??30??6    
???????$??25(?5?      $ Center=?6*   $
??Bold"?5?       J5?      5?      ? 5?      -   5        $??
WP_Player1??5?      $	??300??5?      $	??300??6%   5?      5?      5?      ?? 5?   
   -   5        $??SP_Menu??5?   =   $??Right=?6   $??10q?61   
???????$??Center=?5?   +   .+?5?      ?? .+?5?      ?? $ 
Horizontal=?6   $??
10,10,10,5q?66   .+?5?      ?? -   5        $
??B_S4??5?   5   $??30??6   $	??100??6)   $??■■■■??5?      5?      ?? 5?      -   5        $ TB_4ShipAmount??5?       
???????$??10,0,0,0q?5?   7   $
??Bold"?5?   $   $??18(?66   $ Center=?5?   $   5?      5?      ?? 5?      $ 
Horizontal=?6   $??	10,5,10,5q?66   .+?5?      ?? -	   5        $
??B_S3??5?   5   $??30??6   $	??100??6)   $??	■■■??5?      5?      ?? 5?      -
   5        $ TB_3ShipAmount??5?       
???????$??10,0,0,0q?5?   7   $
??Bold"?5?   $   $??18(?66   $ Center=?5?   $   5?      5?      ?? 5?      $ 
Horizontal=?6   $??	10,5,10,5q?66   .+?5?      ?? -   5        $
??B_S2??5?   5   $??30??6   $	??100??6)   $??■■??5?      5?      ?? 5?      -   5        $ TB_2ShipAmount??5?       
???????$??10,0,0,0q?5?   7   $
??Bold"?5?   $   $??18(?66   $ Center=?5?   $   5?      5?      ?? 5?      $ 
Horizontal=?6   $??	10,5,10,5q?66   .+?5?      ?? -   5        $
??B_S1??5?   5   $??30??6   $	??100??6)   $	??■??5?      5?      ?? 5?      -   5        $ TB_1ShipAmount??5?       
???????$??10,0,0,0q?5?   7   $
??Bold"?5?   $   $??18(?66   $ Center=?5?   $   5?      5?      ?? 5?      $ 
Horizontal=?6   $??
10,5,25,10q?66   .+?5?      ?? $??0,0,10,0q?6!   .+?5?      ?? -   5        $??30??5?   !   $??30??6-   .??5?      ?? $??/Resources/eraser.png??6$   5?      ?? 5?      
???????$
??Bold"?67   $??12(?5?       $??Корабль??6.   5?      5?      ?? 5?      .+?5?      ?? -   5        $??30??5?   !   $??30??6-   .??5?      ?? $??/Resources/eraser2.png??6$   5?      ?? 5?      
???????$
??Bold"?67   $??12(?5?       $??Поле??6.   5?      5?      5?      5?      5?      ?? 5?   
   -   5        $	??100??5?      $??30??6   $??5,0,60,5q?5?      $??Bottom=?6#   $
??Left=?5?      $??
Назад??6,   $??18(?5?      
???iii?$
??Bold"?5?   &   5?      ?? 5?   
   -   5        $	??120??5?      $??30??6   $??Bottom=?5?      $??Right=?5?      $??Начать игру??6-   $??18(?5?      
???iii?$
??Bold"?5?   &   $??0,0,5,5q?5?      5?      5?      5?      