   M S B A M L   `   `   `  ????E  AAssignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Assignment.ViewAssignment.View  5   	       Assignment.View.ShowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Assignment.View     5   	     ? Title$  	Logged in??5   	   $	??600??6   $	??800??6(    ? WindowStartupLocation$ CenterScreen=?5   	   
?????? .??5      ?? ??5   
   ?? 5       ?? ImageSource$ /images/backgroundpic.jpg??6   ._?5   
   ??  J? Opacity$
 0.85Q?6   $??2q?5      ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #462AD8??6#    ? Offset$ 0Q?63   ? 5      $ #DA34AE??6#   $
 0.75Q?63   ? 5      $ #8A16C1??6#   $ 1Q?63   5      ??5"      ?? 5#      $	 0,1&?6&   $	 1,1&?67   .??5$      ? $ #462AD8??6#   $ 0Q?63   ? 5%      $ #DA34AE??6#   $
 0.75Q?63   5&      ._?5)      ?  ? RowDefinitions 5*      ?? 5+      $??30 ?6$   ?? 5,      .+?5.      ? 	 ? ColumnDefinitions	 5/      ?? 50      ?? 51      $??25 ?6+   ?? 52      $??25 ?6+   ?? 53      $??5 ?6+   56      ?? 58      $	??650??6   $??2??59      
 ?? Orientation$
 Vertical=?5:      $??0,35,0,0q?5;      .+?5=      &   System.Windows.Controls.DataGrid  -   5          Name$ dgrid??5D      $	??400??5>      $	??500??5?      
?????? 
???   ?$??Center=?5B      $??Center=?5C      5I      ?? 5K      -   5         ??Name$ btnlogin??5K      $??0q?5M      $??Logout??5N      
???????$??12(?5P      $??
Montserrat)?5Q       ? Cursor$
 Hand??5R      $??2??5S      $??0,50,0,0q?5T      ??5L      ?? *LoginCommand+??5W      ?? 5X       ?? 
TargetType" ??6$   .?5Y   "   ??  ?? Property ? ?? ?? Value ?#462AD86?    ?? Triggers 5Z   "   P? 5[   &    P? Property ?@J?IsMouseOver P? Value . . ?5\   *   ??  ? ?? ?#28AEED6G   5]   '   5`      ??5c      ?? 5d       ?? 
TargetType" ??6.   .R?5e   "   ?? $	??150??6)   $??40??65    ?? CornerRadius$ 20??5f   )   #??z??5g   )   ._?5h   &   ?? $??Center=?67   $??Center=?5i   4   5k   #   5m      5p      5{      5|      5      5?      5?      