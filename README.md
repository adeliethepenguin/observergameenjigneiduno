# observergameenjigneiduno

Basically I used the observer pattern and created 5 actions:
OnCrashed
OnOutOfFuel
OnFuelGet
GameRestart

Each of which have the soundmanager, ui manager, and the player react to such events and have their own methods activate.



Update:
I have added dirty flag pattern. The flagmanager checks through all the streetcars to see if they've crashed and then marks them dirty and Unloads them by changing the sprite colour and turning off collider so they cant be collided with again.
