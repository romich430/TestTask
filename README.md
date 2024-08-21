This is the test task for Unity developer position

Target Platform – Android. Main Character (Red Cube) is rushing through space on an endless platform, collecting coins as points while trying to avoid obstacles (grey). 

The platform is not actually endless. Instead of player rush forward,  it is rather grey obstacles that are coming on to him, while player can only move left or right to avoid them and pick up yellow coins for points. Players movement is clamped, so he cant fall off the platform. Rotation is frozen too. 
At the end of the platform there is a spawner object creating obstacles and coins at random position with random interval. Also there is a slight fog so player cant see them spawning but just appearing from the fog. 
When Player collides with coin his score will be increased and coin will be destroyed. When Player collides with obstacle game will stop, final score will appear and on touch user will be transferred to a starting page.
Application UI allows to start game, pause in-game (from there either resume or exit back to menu) and exit to main menu. 

According to the task, when launching application, user IP will be checked and if any other than "Ukraine" will open wikipedia main page.

Also, AppsFlyer and OneSignal SDKs are initialized.