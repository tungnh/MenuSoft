   M S B A M L   `   `   `  ����F  BNewMenuSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NewMenuSoft.ViewsNewMenuSoft.Views  5   	   ?$clr-namespace:NewMenuSoft.ViewModelsNewMenuSoft.ViewModels  5   	   /    )NewMenuSoft.Views.Category.CategoryTbl001   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5   	   L HLivet, Version=1.3.0.0, Culture=neutral, PublicKeyToken=b0b1d3f711ef38cb.l&http://schemas.livet-mvvm.net/2011/wpf  5   	   'vclr-namespace:NewMenuSoft.Views  5   	   -vm$clr-namespace:NewMenuSoft.ViewModels  5   	   -   5          � Title$%  大カテゴリマスタ登録 ��5	   	   $	��500��6   $	��670��6*    � WindowStartupLocation$ CenterScreen=�5
   	   ���#bebebe.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ ContentRendered��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      +  %Livet.Behaviors.LivetCallMethodAction     
MethodName$ 
Initialize��6?      MethodTarget 6&   �� 6?   5        5   
   $ Closed��6   . 5      .  (Livet.Behaviors.DataContextDisposeAction  5      .��5      �  � ColumnDefinitions 5    
   �� 5!      $
��371* �6   �� 5"      $
��421* �6   .+�5$   
   �� 
����� �$��	コード��6"   $
��Left=�60   $��5,50,0,0q�6K   $	��Top=�6]   $��74��6u   $��23��6�    J� RenderTransformOrigin$ 0.962,3.729&�6�   �� 5%   
   -   5        	 ��Name$	 txtCategoryCode��5%      {�.  $
��Left=�6�   $��23��6�   $��	80,50,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $��Center=�6�   $	��336��6  $��2��6&  ��6=   ��  �� Path$ Category_Code� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6&  �� 5&   
   
����� �$��名称��6"   $
��Left=�6/   $��5,75,0,0q�6J   $	��Top=�6\   $��74��6t   $��23��6   �� 5'   
   -   5        $	 txtCategoryName��5'      $
��Left=�6�   $��23��6�   $��	80,75,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $��Center=�6�   $	��450��6  $��2��6  ��6+   �� $ Category_Name�$ TwoWay=�$ PropertyChanged=�6  �� 5(   
   $&�� 大カテゴ  リマスタ登録��6   
�������$��Center=�6:   $
��Left=�6_   $��0q�6z   $	��Top=�6�   $	��192��6�   $��1q�6�   ���	#FFAE1A1A$
��Bold"�6�   �� 5)   
   -   5         ��Name$ btnRegister��5)      $��
登録(F1)��6&   $��Right=�67   $��184,10,90,0q�6S   $	��Top=�6h   $��75��6�   $ -0.109,0.782&�6�   $��1��6�   �� 5*   
   -   5        $ btnClose��5*      $��閉じる(F12)��6#   $��Right=�66   $��264,10,10,0q�6R   $	��Top=�6g   $��75��6   $��1��6�   &   System.Windows.Controls.DataGrid  5+   
   -   5          Name$ 
dgCategory��5,         RowHeaderWidth$ 0Q�5-         AutoGenerateColumns .  $   HorizontalScrollBarVisibility$ Disabled=�5/      $��
5,110,10,0q�50      $	��Top=�51      $	��272��52      $��2��53         CanUserAddRows .     SelectionMode$ Single=�58      ��56      �� *	Categorys+ �� SelectedItem 57      �� *SelectedItem+   Columns 59      4  .System.Windows.Controls.DataGridTemplateColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ 	コード��6)      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 150	 66      
IsReadOnly .    HeaderStyle 5;      �� 5<       �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 6    .�5=      ��  �� Property � �� �� Value$ Center=�6K   5>         CellTemplate 5@      �� 5A      .R�5B      ��  ��Name$ txtCode��6(   ��69   �� *Category_Code+$ TwoWay=�5C      5E        5F      $ 名称��6)   $	 494	 65    .  5G      �� 5H      " 
 6    .�5I      ��  � ��$ Center=�6K   5J       5L      �� 5M      .R�5N      �� $ txtCode��6(   ��69   �� *Category_Name+$ TwoWay=�5O      5Q      5S      �� 5T   
   $
��Left=�6   $��225,400,0,0q�6/   $
��Wrap=�6D   $	��Top=�6o   ��6X   �� *Clock+6o   5U      5V      