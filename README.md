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



I have added command pattern in order to add vertical movements. There are three set locations you can move, 'I' moves you up 'K' moves you down. The location moves to is set in a list.
You can undo movements by pressing 'J'.
<img width="1092" height="583" alt="image" src="https://github.com/user-attachments/assets/c921a0de-29d5-4c6f-a8c9-786da92de540" />

I feel I was able to pretty decently implement the command pattern in this time. Creating the command and receiver script was pretty by-the-book for me and managing the stack too. It was somewhat difficult to come up with a decent use case that was probably the most annoying part. And also the error testing afterwards. But generally it worked pretty quickly and I feel more confident about implementing command. I'd say the explanation part was also difficult. As you can see above it is pretty simplistic and if I had more time I would like to make a more intuitive explanation. Creating a diagram quickly and making it legible and succinctly explain my thought process through is alot to do in a short time and I feel it will be difficult to do it for all the pieces required in the final exam time. I also feel I need to go back and look at materials about game engine architecture and such since I was off base and misinterpreted questions...
