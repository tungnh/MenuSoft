   M S B A M L   `   `   `  ����F  BNewMenuSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NewMenuSoft.ViewsNewMenuSoft.Views  5   	   ?$clr-namespace:NewMenuSoft.ViewModelsNewMenuSoft.ViewModels  5   	   #    NewMenuSoft.Views.StoreMaster   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5   	   L HLivet, Version=1.3.0.0, Culture=neutral, PublicKeyToken=b0b1d3f711ef38cb.l&http://schemas.livet-mvvm.net/2011/wpf  5   	   'vclr-namespace:NewMenuSoft.Views  5   	   -vm$clr-namespace:NewMenuSoft.ViewModels  5   	     � Title$  店舗マスタ登録 ��5	   	   $	��500��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�5
   	   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ ContentRendered��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      +  %Livet.Behaviors.LivetCallMethodAction     
MethodName$ 
Initialize��6?      MethodTarget 6&   �� 6?   5        5   
   $ Closed��6   . 5      .  (Livet.Behaviors.DataContextDisposeAction  5      .��5$      �  � ColumnDefinitions 5%   
   �� 5&      $
��371* �6   �� 5'      $
��421* �6   .+�5)   
   �� 
����� �$��店舗コード��6"   $
��Left=�62   $��5,50,0,0q�6M   $	��Top=�6_   $��74��6w   $��23��6�    J� RenderTransformOrigin$ 0.962,3.729&�6�   �� 5*   
   -   5        	 ��Name$	 txtShopCode��5*      $
��Left=�6w   $��23��6�   $��	80,50,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $��Center=�6�   $	��336��5+      $��2��6   ��5*   '   ��  �� Path$ ShopCode� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5+   "   �� 5,   
   
����� �$�� 店舗名称��6"   $
��Left=�62   $��5,75,0,0q�6M   $	��Top=�6_   $��74��6w   $��23��6�   �� 5-   
   -   5        $	 txtShopName��5-      $
��Left=�6w   $��23��6�   $��	80,75,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $��Center=�6�   $	��450��5.      $��2��6   ��5-   '   �� $ ShopName�$ TwoWay=�$ PropertyChanged=�5.   "   �� 50   
   $��店舗マスタ登録��6   
�������$��Center=�51      $
��Left=�65   $��0q�6P   $	��Top=�6[   $	��192��6s   $��1q�6   ���	#FFAE1A1A$
��Bold"�6�   �� 52   
   -   5         ��Name$ btnNew��52      $��新規作成(Esc)��6!   $
��Left=�65   $��30.373,10,0,0q�6P   $	��Top=�6g   $��75��6   $��1��6�   �� 53   
   -   5        $ btnRegister��53      $��
登録(F1)��6&   $
��Left=�67   $��127.373,10,0,0q�6R   $	��Top=�6j   $��75��6�   $ -0.109,0.782&�6�   $��1��6�   �� 54   
   -   5        $ 	btnDelete��54      $��
削除(F3)��6$   $
��Left=�65   $��221.373,10,0,0q�6P   $	��Top=�6h   $��75��6�   $��1��6�   �� 55   
   -   5        $ btnClose��55      $��閉じる(F12)��6#   $
��Left=�66   $��319.373,10,0,0q�6Q   $	��Top=�6i   $��75��6�   $��1��6�   &   System.Windows.Controls.DataGrid  56   
   -   5          Name$ dgShop��56      $
��Left=�6#      SelectionMode$ Single=�6\      RowHeaderWidth$ 0Q�6s      AutoGenerateColumns .  $   HorizontalScrollBarVisibility$ Disabled=�6�   $��
80,134,0,0q�6�   $	��Top=�6�   $	��272��6�   $	��644��6  $��2��6+  ��6>   �� *Shops+   Columns 57      4  .System.Windows.Controls.DataGridTemplateColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ 店舗コード��6)      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 154	 68      
IsReadOnly .    HeaderStyle 59      �� 5:       �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 6    .�5;      ��  �� Property � �� �� Value$ Center=�6K   5<         CellTemplate 5>      �� 5?      .R�5@      ��  ��Name$ txtCode��6(   ��69   �� *
ShopCode+$ TwoWay=�5A      5C        5D      $  店舗名称��6)   $	 490	 68    .  5E      �� 5F      " 
 6    .�5G      ��  � ��$ Center=�6K   5H       5J      �� 5K      .R�5L      �� $ txtCode��6(   ��69   �� *
ShopName+$ TwoWay=�5M      5O      5Q      5R      5S      