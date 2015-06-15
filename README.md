# What is the Multiversal Observatory?
The Multiversal Observatory is a program allowing users to observe all 52 worlds of the post-Flashpoint DC Multiverse.

# How to use
When you first open the program, there will be pop-up instructions on how to operate the GUI, so you won't see any here.

# Inner workings (see Form1.cs for main code)
The program is centered around an "Earth" class, and the properties of the 52 objects derived from it.
These 52 objects, called "Earths", are part of an array called "multiverse".
Users are asked to give an int value ranging from 0 to 51.
The program will then call a method that applies the properties of the object with that value for its multiverse index.
There are no comments, but the code is fairly straightforward, so it's practically self-documenting.
