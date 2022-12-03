![image](https://user-images.githubusercontent.com/32450751/169312352-ed6df610-6867-4cef-9549-5026449c821c.png)

## What is this?

A Unity videogame, developed as a Human Computer Interaction project, made by **Andrea Masciulli** and **Alessandro Pegoraro**. It uses both Unity and Mediapipe in order to bond hand-detection capabilities to an engaging gameplay.

**Play the game**: https://aramas.itch.io/catch-them-eggs

**Video Presentation**: https://youtu.be/vlIggj5z7s4

## Concept

Eggs are falling from the sky! Use your hands (placing them in front of the camera) to catch and save as many eggs you can.

## Project structure

The project consists of a python project and a unity project:

- the python project is responsible to detect hands in front of the camera. The hand position is then sent on a port through UDP protocol.
- the unity project lissens on the aforementioned port (with a custom script) using the hand position for its gameplay.

The python virtual environment (containing custom scripts and opencv&mediapipe libraries) is then built into an EXE app (there are some easy to use libraries that enable you to do so). The unity project contains a script responsible of executing such executable.

**NOTES**: 

- The repo misses the aforementioned python project. This is because we suggest following the initial 20 minutes of [Murtaza's Workshop Tutorial](https://www.youtube.com/watch?v=RQ-2JWzNc6k) to setup the python virtual environment. After that setup, the unity project should work fine (please check that executable names and file path are the same).

- Typo in gif below: Communication between Python and Unity is UDP, not uTP.

![ezgif com-gif-maker (5)](https://user-images.githubusercontent.com/32450751/195997362-246ebc35-81b7-4781-8a55-e6f7472c40af.gif)





