   M S B A M L   `   `   `  ���� E  AGameofLife, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GameofLife
GameofLife      GameofLife.MainWindow   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:GameofLife       � WindowState$  	Maximized=� � Title$ 
MainWindow��$
��1080��$
��1920��.��� -    �Name$ MainGrid������  �� ImageSource$ 
/index.jpg�� j� Stretch$ UniformToFill=� j� TileMode$
 Tile=�.+��� -    ��Name$ 	GridPanel��$��91,85,79,299q��� -   $��Clear��$
��Left=�$��
91,880,0,0q�$	��Top=�$��74��$	��298���� -    ��Name$ stepBut��$
��Step��$��Center=�$��	0,880,0,0q�$	��Top=�$��74��$	��298���� -   $ StartBut��$��Step 10��$
��Left=�$��1585,880,0,0q�$	��Top=�$��74��$	��298���� -   $ LeftBut��$
��Left��$
��Left=�$��
10,373,0,0q�$	��Top=�$	��104��$��54���� -   $ RIghtBut��$��Right��$
��Left=�$��1856,373,0,0q�$	��Top=�$	��104��$��54���� -   $ DownBut��$
��Down��$��Center=�$��	0,784,0,0q�$	��Top=�$��48��$	��130���� -	    ��Name$ ScaleSlider��$
��Left=�$��530,799,0,0q�$	��Top=�$	��120��	 � Minimum$	 10Q�
 � Maximum$	
 100Q��� -
   $ UpBut��$��Up��$
��Left=�$��
898,10,0,0q�$	��Top=�$��50��$	��136���� -    ��Name$ 	SliderVal��$!��Slide this to generate grid��$
��Left=�$��548,822,0,0q�$	��Top=�$	��147��$��32��