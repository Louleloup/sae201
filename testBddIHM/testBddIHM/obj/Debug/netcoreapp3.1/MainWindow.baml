   M S B A M L   `   `   `  ����E  AtestBddIHM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:testBddIHM
testBddIHM  5   	       testBddIHM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:testBddIHM     5   	     � Title$  Gestion d'affectations��5   	   $	��800��6(   $
��1050��65   $	��800��6B   $
��1050��6R   .��5	      �  � ShowGridLines$
 True��6   ���	#FF9E9C9C � ColumnDefinitions 5
   
   �� 5      $	��400 �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $
��Left=�6   $	��329��68   $��-33,-62,0,0q�6E   $	��Top=�6Z   $	��386��6r   $c��]/4805283-ailes-avec-etoile-embleme-armee-militaire-logo-design-vectoriel-removebg-preview.png��6~   �� 5   
   -   5         ��Name$ listviewCorpDArmee��5      $��10,212,215,0q�6/   
���   �$	��239��6X   $	��Top=�6e    �� View 5      �� 5      .P�5      �� $��Corp d'armée��6%    �� Width$	 160��6;    �� DisplayMemberBinding 6G   �� *	libelleCA+5      5      �� 5   
   -   5        $! listviewAffectationDivision��5      
���   �$��1��6K   $��29,519,202,15q�6[    5      �� 5      .P�5      �� $��Num Division��6%   $ 80��6;    6F   �� *	NumeroD+�� 5      $��Num Mission��6%   $ 80��6:    6E   �� *	NumeroM+�� 5      $
��Date��6%   $ 80��63    6>   �� *Date+ �� StringFormat$ dd MMM yyyy���� 5      $��Commentaire��6%   $	 100��6:    6F   �� *Commentaire+5      5!      �� 5"   
   -   5        $ listviewDivision��5"      $��203,212,10,0q�6-   
���   �$	��239��6V   $	��Top=�6c    5#      �� 5$      .P�5%      �� $��Num Division��6%   $ 80��6;    6F   �� *NumeroDivision+�� 5&      $��Nom Division��6%   $ 90��6;    6F   �� *LibelleDivision+5'      5)      �� 5*   
   -   5        $ listviewMission��5*      $��14,519,14,15q�6,   
���   � 5+      �� 5,      .P�5-      �� $��Numéro Mission��6%   $	 100��6=    6I   �� *NumeroMission+�� 5.      $��Libelle mission��6%   $	 100��6>    6J   �� *LibelleMission+�� 5/      $��Commentaire��6%   $	 130��6:    6F   �� *Commentaire+50      52      �� 53   
   $��5q�6   
���   �$��1��69   $��
29,27,29,0q�6I   $	��446��6]   $	��Top=�6j   ��54      �� 55       �� ImageSource$ /2image.jpg��6   57      �� 58   
   $��1��6   $��Center=�6$   $��0,36,0,0q�6A   $"��Enregistrement d'Affectation��6S   $	��Top=�6w   
�������$��35(�6�   �� 59   
   $��1��6   $
��Left=�6$   $��
68,199,0,0q�6?   $��Préciser Mission :��6S   $	��Top=�6m   
�������$��25(�6�   �� 5:   
   $��1��6   $
��Left=�6$   $��
68,145,0,0q�6?   $��Préciser Date :��6S   $	��Top=�6j   
�������$��25(�6�   �� 5;   
   $��1��6   $
��Left=�6$   $��	68,90,0,0q�6?   $��Préciser Division :��6R   $	��Top=�6m   
�������$��25(�6�   �� 5<   
   $��1��6   $
��Left=�6$   $��
68,250,0,0q�6?   $��Renseigner Commentaire :��6S   $	��Top=�6s   
�������$��25(�6�   �� 5=   
   -   5        	 ��Name$	 comboBoxMission��5=      
 �� DisplayMemberPath$
 NumeroMission��6-   $��1��6O   $	��130��6_   $��32��6k   $��288,201,212,0q�6w   $	��Top=�6�   $��20(�6�   (  "System.Windows.Controls.DatePicker  5>   
   -   5          Name$ datePickerAffectation��5>      $��1��64   $	��240��6D   $��32��6P   $��298,146,100,0q�6\   $	��Top=�6s   $��20(�6�   �� 5?   
   -   5        $	 comboBoxDivision��5?      $
 NumeroDivision��6-   $��1��6P   $	��130��6`   $��32��6l   $��288,91,212,0q�6x   $	��Top=�6�   $��20(�6�   �� 5@   
   -   5         ��Name$ txtBoxCommentaire��5@      $��2q�6-   $��52,301,46,0q�6A   $�� ��6V   $��1��6^   $��20(�6n   
���   �$	��125��6�   $	��Top=�6�   �� 5A   
   -	   5        $��Valider��5A   (   $��1��6:   $��
0,431,46,0q�6J   $	��100��6_   $��20(�6k   $��Right=�6y   $��32��6�   $	��Top=�6�   �� 5B   
   $
��Left=�6   $	��Top=�6/   $��
32,181,0,0q�6G   $��Corp d'Armée��6[   $��20(�6o   $
��Bold"�6}   �� 5C   
   $
��Left=�6   $	��Top=�6/   $��216,181,0,0q�6G   $��Division Militaire��6\   $��20(�6v   $
��Bold"�6�   �� 5D   
   $��68,486,218,270q�6   $+��%Affectation aux Missions Humanitaires��6,   $��20(�6Y   $
��Bold"�6g   $��1��6y   �� 5E   
   $��	0,486,0,0q�6   $��Missions Humanitaires��6'   $��20(�6D   $
��Bold"�6R   $��Center=�6d   $	��214��6�   $��27��6�   $	��Top=�6�   �� 5F   
   -
   5        $��Supprimer Affectation��5F   7   $��
0,0,14,190q�6W   $��15(�6k   $��1��6y   $��42��6�   $��Bottom=�6�   $��Right=�6�   $	��164��6�   �� 5G   
   -   5        $��Modifier Affectation��5G   6   $��	0,0,14,98q�6U   $��15(�6h   $��1��6v   $��42��6�   $��Bottom=�6�   $��Right=�6�   $	��164��6�   5I      5J      