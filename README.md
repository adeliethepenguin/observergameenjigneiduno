# observergameenjigneiduno

Basically I used the observer pattern and created 5 actions:
OnCrashed
OnOutOfFuel
OnFuelGet
GameRestart

Each of which have the soundmanager, ui manager, and the player react to such events and have their own methods activate.



Update:
I have added dirty flag pattern. The flagmanager checks through all the streetcars to see if they've crashed and then marks them dirty and Unloads them by changing the sprite colour and turning off collider so they cant be collided with again.
Each of the street cars are sectors.
Furthermore, the flagmanager Loads them when they are above a certain position.y value (meaning they have respawned) and thus if they are unloaded they can be loaded.
Below is a diagram explaining it:
<img width="806" height="486" alt="image" src="https://github.com/user-attachments/assets/3c2cf5d0-70df-4d03-8ced-6b910fdea411" />
Sorry about the "type words to search for thing" on the screenshot. Visual sudio made that notification pop up on my computer and i cant close it...
