   M S B A M L   `   `   `  ����E  AtestBddIHM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:testBddIHM
testBddIHM  5   	   %    testBddIHM.supprimerAffectation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:testBddIHM     5   	     � Title$  Supprimer Affectation��5   	   $	��600��6'   $	��500��64    � 	Resources 5	         caseACocher �� Orientation d� 	IsChecked �� Path �� RelativeSource �� AncestorType��%�   &	        �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      ��  6   �� $ 
IsSelected� �� *FindAncestor+" ��5      5      5      .��5      � .+�5   
   �� -   5        $��	Supprimer��5      $��Right=�6%   $��	0,0,10,10q�6A   $��Bottom=�6T   $��44��6o   $	��128��6{   $��20(�6�   6�   �� 5   
   -   5         ��Name$! listviewAffectationDivision��5      $��10,10,10,72q�68    �� View 5      �� 5      .P�5      �� 	 �� CellTemplate#	 [  6%   
 �� Width$
 30��6Q   �� 5      $��Num Division��6%   $
 80��6;    �� DisplayMemberBinding 6F   �� *	NumeroD+�� 5      $��Num Mission��6%   $
 80��6:    6E   �� *	NumeroM+�� 5      $
��Date��6%   $
 90��63    6>   �� *Date+ �� StringFormat$ dd MMM yyyy���� 5      $��Commentaire��6%   $	
 160��6:    6F   �� *Commentaire+5      5      �� 5   
   -   5        $��Annuler��5      $��Right=�6#   $��
0,0,155,10q�6?   $��Bottom=�6S   $��44��6n   $	��128��6z   $��20(�6�   6�   5      5       