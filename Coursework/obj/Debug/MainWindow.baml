   M S B A M L   `   `   `  ����E  ACoursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Coursework
Coursework  5   	       Coursework.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Coursework     5   	     � Title$  
MainWindow��5   	   $��583.337��6   $��1025.951��6-   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6   $��0,0,2,-2q�6+   z�5
   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.126Q�6"   T� 5      5      .+�5   
   �� -   5         ��Name$ 
btnAddUser��5      $��ADD NEW USER��6%   $
��Left=�6<   $��131,191,0,0q�6W   $	��Top=�6l   $	��102��6�   $ 0.101,-1.871&�6�   6�   �� 5   
   -   5         ��Name$ 
txtAddName��5      $
��Left=�6&   $��36��6A   $��
131,98,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��134��6�   �� 5   
   -   5        $ btnAddLocation��5      $��ADD NEW LOCATION��6)   $
��Left=�6D   $��151,430,0,0q�6_   $	��Top=�6t   $	��121��6�   6�   �� 5   
   -   5        $ txtAddLocation��5      $
��Left=�6*   $��36��6E   $��151,373,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��134��6�   $ 1.089,-0.31&�6�   �� 5   
   -   5         ��Name$ lstUserList��5       �� SelectionMode$ Multiple=�6(   $
��Left=�6A   $��96��6\   $��
304,96,0,0q�6h   $	��Top=�6|   $	��375��6�   �� 5   
   -   5        $ lstLocationList��5      $ Multiple=�6+   $
��Left=�6D   $��96��6_   $��304,368,0,0q�6k   $	��Top=�6�   $	��374��6�   $ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.022Q�6$   �� 5      T� 5      	 T� Y$	 0.043Q�6)   5      5       �� 5!   
   -   5        $ btnRecordVisit��5!      $(��"RECORD VISIT OF 
USER TO LOCATION��6)   $
��Left=�6^   $��304,485,0,0q�6y   $	��Top=�6�   $	��115��6�   6�   �� 5"   
   -   5        $ btnRecordContact��5"      $(��"RECORD CONTACT 
BETWEEN TWO USERS��6+   $
��Left=�6`   $��302,207,0,0q�6{   $	��Top=�6�   $	��125��6�   $��36��6�   6�   �� 5#   
   -	   5        $ btnContactPhone��5#      $&�� GENERATE TELEPHONE 
NUMBER LIST��6*   $
��Left=�6]   $��712,207,0,0q�6x   $	��Top=�6�   $	��140��6�   $��36��6�   6�   �� 5$   
   -
   5        $ btnVisitPhone��5$      $&�� GENERATE TELEPHONE 
NUMBER LIST��6(   $
��Left=�6[   $��712,485,0,0q�6v   $	��Top=�6�   $	��133��6�   $��36��6�   6�   �� 5%   
   -   5        $ lstContactPhone��5%      $
��Left=�6D   $��96��6_   $��
712,96,0,0q�6k   $	��Top=�6   $	��250��6�   �� 5&   
   -   5        $ lstVisitPhone��5&      $
��Left=�6B   $��96��6]   $��712,368,0,0q�6i   $	��Top=�6~   $	��250��6�   �� 5'   
   -   5        $ txtAddUserPhone��5'      $
��Left=�6+   $��36��6F   $��131,139,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��133��6�   �� 5(   
   $��Name:��6   $
��Left=�6    $��	70,98,0,0q�6;   $	��Top=�6N   $��56��6f   $��36��6q   $��16(�6}   �� 5)   
   $��Phone Number:��6   $
��Left=�6(   $��
10,139,0,0q�6C   $	��Top=�6W   $	��120��6o   $��36��6{   $��16(�6�   �� 5*   
   $��Name of Location:��6   $
��Left=�6,   $��
10,373,0,0q�6G   $	��Top=�6[   $	��150��6s   $��36��6   $��16(�6�   �� 5+   
   $T��NSelect the two users from the list 
which you want to record contact between:��6   $
��Left=�6q   $��
304,39,0,0q�6�   $	��Top=�6�   $	��314��6�   $��52��6�   $��16(�6�   �� 5,   
   $|��vSelect the user from the box above and 
the location from the box below of which
you want to record a visit between:��6   $
��Left=�6�   $��304,285,0,0q�6�   $	��Top=�6�   $	��307��6�   $��73��6�   $��16(�6  �� 5-   
   $s��mSelect the user on the box to the left 
of which contacts you want to generate
a list of phone numbers for:��6   $
��Left=�6�   $��
696,17,0,0q�6�   $	��Top=�6�   $	��302��6�   $��83��6�   $��16(�6�   �� 5.   
   $u��oSelect the location on the box to the left 
of which visitors you want to generate
a list of phone numbers for:��6   $
��Left=�6�   $��696,285,0,0q�6�   $	��Top=�6�   $	��302��6�   $��83��6�   $��16(�6�   50      51      