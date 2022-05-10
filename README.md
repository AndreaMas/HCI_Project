# HCI_project_build
Build of the human computer interaction videogame project, made with love by **Andrea Masciulli** and **Alessandro Pegoraro**. 

For the actual build of the game, please visit https://github.com/AndreaMas/HCI_project_build

![image](https://user-images.githubusercontent.com/32450751/166153226-ddaf85f6-538f-4f5c-b7b5-533466f72196.png)
![image](https://user-images.githubusercontent.com/32450751/166153185-3aa2c2c6-6679-48e2-82c0-369f2c4cf9af.png)

## Aim of this project
The project focused on having a performant hand detection to enable an engaging gameplay, where the user is asked to catch eggs falling from the sky by simply placing its hand in front of the camera.


## How the application is structured:
The app is actually made up by two separate applications. A Pyhon application and a Unity application. 
- the python app uses OpenCV and MediaPipe libraries for hand detection. The position of the hand is then broadcasted through UDP protocol.
- the unity application receves the broadcasted position of the hand. This way we're able to have very good hand detection within our game.

PLEASE NOTE: A future update (by the end of this month) hopes to merge these two applications into one, making it a simple Unity executable. For the time being, this is the best we could get.

## How to run the game:
The game was build to run on a Windows desktop machine. To run, follow these steps:
- First, open the PythonApp folder, and run the dist/main/main.exe executable. This should open the computer webcam and hand tracking should be working.
- Then, open the UnityApp folder and run the 3DHandTracking.exe executable. This should launch the actual Unity game.

## Video Tutorial/Presentation
upcoming by the end of may


