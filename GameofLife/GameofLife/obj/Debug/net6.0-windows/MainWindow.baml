   M S B A M L   `   `   `  ����E  AGameofLife, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GameofLife
GameofLife  5   	       GameofLife.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GameofLife     5   	     � WindowState$  	Maximized=�5   	    � Title$ 
MainWindow��5	   	   $
��1080��6   $
��1920��6*   .��5
      � -   5         �Name$ MainGrid��5
      ��5   
   �� 5       �� ImageSource$- '/Meme_Man_on_transparent_background.png��6    j� Stretch$
 None=�6O    j� TileMode$
 Tile=�6^   .+�5   
   �� -   5         ��Name$ 	GridPanel��5      $��91,85,79,299q�6(   5      �� 5   
   -   5        $��Clear��5      $
��Left=�6!   $��
91,880,0,0q�6<   $	��Top=�6P   $��74��6h   $	��298��6t   6�   �� 5   
   -   5         ��Name$ stepBut��5      $
��Step��6"   $��Center=�61   $��	0,880,0,0q�6N   $	��Top=�6a   $��74��6y   $	��298��6�   6�   �� 5   
   -   5        $ StartBut��5      $��Step 10��6#   $
��Left=�65   $��1585,880,0,0q�6P   $	��Top=�6f   $��74��6~   $	��298��6�   6�   �� 5   
   -   5        $ LeftBut��5      $
��Left��6"   $
��Left=�61   $��
10,373,0,0q�6L   $	��Top=�6`   $	��104��6x   $��54��6�   6�   �� 5   
   -   5        $ RIghtBut��5      $��Right��6#   $
��Left=�63   $��1856,373,0,0q�6N   $	��Top=�6d   $	��104��6|   $��54��6�   6�   �� 5   
   -   5        $ DownBut��5      $
��Down��6"   $��Center=�61   $��	0,784,0,0q�6N   $	��Top=�6a   $��48��6y   $	��130��6�   6�   �� 5   
   -	   5         ��Name$ ScaleSlider��5      $
��Left=�6&   $��530,799,0,0q�6A   $	��Top=�6V   $	��120��6n   	 � Minimum$	 10Q�6�   
 � Maximum$	
 100Q�6�   �� 5   
   -
   5        $ UpBut��5      $��Up��6    $
��Left=�6-   $��
898,10,0,0q�6H   $	��Top=�6\   $��50��6t   $	��136��6�   6�   �� 5   
   -   5         ��Name$ 	SliderVal��5      $��Label��6#   $
��Left=�63   $��548,822,0,0q�6N   $	��Top=�6c   $��72��6{   5      5      