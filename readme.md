# Delivery Driver
Player Drives around in a car picking up deliveries and dropping them off.

## How It's Made:





**Tech used:** 
Unity Game Engine and C#


## Optimizations
*(optional)*


## Lessons Learned:
Using Time.deltaTime Unity tells us how long each frame took to execute
When we multiple something byt the Time.deltaTime it makes the game "Frame Rate Independent"


Collision 
You need to add a collider as well as a ridig body to the game object to intertact with an object. 

### when adding a rigdge body the gravity is set to zero

Added box collider to our player instead of a capsule collider to give it more of a push

Added Delta Time to allow frame rate Independence

Created a collision script using On Collision Enter
Allows use to do something when collision is detected













