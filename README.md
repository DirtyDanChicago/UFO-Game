# UFO-Game
This is a simple 2D game in which you hover around as a UFO and collect gold nuggets.
I added a special feature in which clicking Q or E will change the color of the UFO, with that 
you can only collect collectables that are the same color as you. I did this by making a new prefab
of the already existing collectable, and making it blue. I then made a new BluePickup tag for it.
In my player script I made a blank string. I replaced the PickUp string in the tag detection with the
blank string. In the If statements for both colors I added the string replacement for their respective colors. 


YouTube Video: https://www.youtube.com/watch?v=yJSBJrQUIw0&feature=youtu.be
