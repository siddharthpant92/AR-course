# AR-course
`Build 15 Augmented Reality (AR) apps with Unity and Vuforia` on Udemy

Mobile Phone: OnePlus 6T with Android Version 10 / OxygenOS version 10.3
Unity version: 2020.1
Vuforia: 9.4.6

Demo Videos: https://www.youtube.com/playlist?list=PLqSMASqVLL6QEckylJ7zQ60x4jvcdt4fQ

#### NOTES:
 - For section 5 and 6, when running the objects with vuforia image target, make sure the phone's camera is focused on the objects that are saved in the vuforia database for that project
 In <b>AR-GreetingCard</b>, the 3D object and the 3D text will only stay within the plane of the 2 book covers that were saved in the vuforia database. If the phone's camera does not point at those book covers, the 3d object or 3d text will not show up outside the image target plane.

  - For section 7 <b>AR-VirtualButton</b>, the virtual image is places on a specific image target which is saved in `Assets/Editor/Vuforia/ImageTargetTextures/AR-VirtualButton`. The virtual button will not be triggered if some other surface is clicked instead. 
