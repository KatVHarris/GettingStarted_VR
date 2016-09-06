# Mobile-VR
Samples and Instructions for getting started with Virtual Reality Development. Gear VR example inculded. 
The powerpoint attached outlines the talk I gave at PAXDev about the main differences between game design and virtual reality design.  

## Author
Katherine "Kat" Harris - @KatVHarris
Technical Evangelist in AR/VR/Game Development for Microsoft

## Requirements

* Android SDK
* Java NDK - https://developer.android.com/ndk/index.html
* Unity 5.3+ - https://unity3d.com/
* Oculus Mobile SDK (for gear) + Oculus Unity Util - https://developer3.oculus.com/downloads/
* Oculus Developer Account and osig file - https://dashboard.oculus.com/tools/osig-generator/

## Building Unity Project
Unity Instructions: https://unity3d.com/learn/tutorials/topics/virtual-reality/getting-started-vr-development

Important part of the instructions. 
* Click Android for Build Settings
* Make sure VR Enabled is selected in Player Settings
* Generate osig file - aka signed APK
 * Go to Oculus Developers > Tools Oculus Signature File
 * Go to Java\Android-SDK\platform-tools - adb.exe : Have phone pluged in and get key for device by running adb.exe 
 * Paste key into the Device ID and download osig file 
 * Copy that file to your Unity Project's Assets > Plugins > Android > Assets Folder
* Push to phone
 * Make sure your device is pluged in
 * Run the following command in command promt window 
  * adb install -r APKName.apk
