# Highway to Heck
This repository contains the code for a simple car racing game for CSE 210 final project. This is Group 3.
This is a game where the player will control the police car using the left and right arrow keys after pressing 
enter to start the game.
Throughout the game, cars will be coming down the road the opposite way. When you collide with or hit another car,
you will lose a life. You have a total of three lives before the game will be over.
We started with the racket game from Unit 06 Articulate as an outline for this project.

# Background Class
The background has been changed to an image of a highway. The image is larger than the game's screen and
a list of 2 backgrounds were made so that they can loop through and make the road appear to be moving when
they are given a velocity.

# Brick Class
The brick class has been modified to hold the cars coming the opposite way. They will be randomly drawn and falling.
The images of bricks have been replaced by the cars.

# Scene Manager Class
Our scene manager is where we draw all of our images and set the game up to be played. This is where we switch between
the different scenes through elsapsed time, recognition of keys being pressed, and after collisions. We were also able to give our police
car an animation so that it's lights flash throughout the game. This is the class where we spawned the cars to come down in the game.
# Collide Brick Action Class
Since we changed our bricks to be the cars coming the opposite way of the player, we were able to keep the collisions the same.
However, we made it so that if there was a collision with one of the cars/bricks, the game would reset and start a new level.

# Move Background Action Class
This is wehere we gave the background a velocity so that the 2 images can be used to look like the road is moving. Since the images are bigger
than the screen, when the bottom of the image hits the screen, the other background image will be drawn, so that there isn't a disconnect
between the road.

# Constants Class
We changed the height and width of the screen so that we wouldn't need to change the size of all the cars. By doing this we saved
a lot of time. This is also where we called and changed our images for cars instead of blocks. This is also where we changed the 
sounds for the game.

# Maintainability
We used maintainability by setting up branches so that we can see each other's commits to the program. We were able to keep the work organized and
describe what the code was allowing to happen when we pushed our code to the branches. Since this was a long term project of about 3 weeks, it was 
helpful to use maintainability because we could look back at what was done and easily understand, even though we are working on other projects and 
assignments this semester. We also avoided working on 1 branch until the end so that if mistakes were made and bugs in our code appeared, we would be able 
to look back at the other teammember's codes and our previous commits so that we can get back to the code before the changes were made. This helps us to backtrack and find where the errors were made.
