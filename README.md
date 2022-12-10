# Highway to Heck
This repository contains the code for a simple car racing game for CSE 210 final project. This is Group 3.
This is a game where the player will control the police car using the left and right arrow keys.
Throughout the game, cars will be coming down the opposite way. When you collide with or hit another car,
you will lose a life. You have a total of three lives.

# We started with the racket game from Unit 06 Articulate.

# Background Class
The background has been changed to a highway scenery. The image is larger than the game's screen, so
a list of 2 backgrounds were made so that they can loop through and make the road appear to be moving.

# Brick Class
The brick class has been modified to hold the cars coming the opposite way. They will be randomly drawn and falling.

# Scene Manager Class
Our scene manager is where we draw all of our images and set the game up to be played. This is where we switch between
the different scenes through elsapsed time and recognition of keys being pressed. We were also able to give our police
car an animation so that it's lights flash throughout the game.

# Collide Brick Action Class
Since we changed our bricks to be the cars coming the opposite way of the player, we were able to keep the collisions the same.
However, we made it so that if there was a collision with one of the cars/bricks, the game would reset and start a new leverl.

# Move Background Action Class
This is wehere we gave the background a velocity so that the 2 images can be used to look like the road is moving.

# Constants Class
We changed the height and width of the screen so that we wouldn't need to change the size of all the cars. By doing this we saved
a lot of time. This is also where we called and changed our images for cars instead of blocks.

# These are the main changes that we made to the Unit 06 Articulate
We kept parts of the code the same, but the classes above are where the majority of the chagnes were made.
