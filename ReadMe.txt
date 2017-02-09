Name: Darshan Shah
Assignment Name: Programming Assignment 1, Part I

------------------------------------------------------------------------
A. Required elements

- Use either the arrow keys to tilt the board
- Maneuver the ball into the green circle to win
- Hit 'Q' or ESC to quit
- Hit 'R' to restart
- I allow a maximum tilt of 10 degrees
- The board rotates at 0.5 degree per frame

------------------------------------------------------------------------
B. Additional elements

- No extra stuff here besides some custom lighting.
- One thing I did differently was that I set transform.eulerAngles instead of
  calling transform.Rotate
  - This was because when i spammed arrow keys the board would also slightly
    rotate in the y axis
  - This doesn't happen in my implementation as y axis is always forced to be 0

------------------------------------------------------------------------
C. Known issues

I developed in linux, so when restarting the game, some of the lighting seems to
be off when you restart the level.

------------------------------------------------------------------------
D. External resources

- The wood textures were downloaded from the Unity store for free.
