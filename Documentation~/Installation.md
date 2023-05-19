# Fulldome Previsualization: Installation Documentation

This project was built and tested on [Unity 2022.2.9f1](https://unity.com/releases/editor/whats-new/2022.2.9) 

It is confirmed to **NOT** work with earlier versions of Unity

In order for this to work, you will need to already have a Unity Scene created ([guide](https://docs.unity3d.com/Manual/scenes-working-with.html))

## Installing Package Dependencies

This package requires three dependencies in order for it to be added to Unity.

* [Unity Recorder](https://docs.unity3d.com/Packages/com.unity.recorder@4.0/manual/index.html) `version 4.0.0+`

  * Open Package Manager (Window > Package Manager) 
  * Set `Packages: In Project` to `Packages: Unity Registry`
  * Search for Recorder (com.unity.recorder)
  * Install the package

* [USD Unity SDK](https://github.com/Unity-Technologies/usd-unity-sdk) `dev branch`

  * Download the latest version of USD Unity SDK from [dev branch](https://github.com/Unity-Technologies/usd-unity-sdk/archive/refs/heads/dev.zip)
  * Extract the folder somewhere in your computer (preferably inside the Unity Scene's Packages folder)
  * Open Package Manager (Window > Package Manager)
  * Click on the `+` button on the top left
  * Click on `Add package from disk...`
  * Navigate to the extracted folder, inside of `package/com.unity.formats.usd`
  * Locate the package.json file
  * Install the package

* [Newtonsoft Json](https://www.newtonsoft.com/json) `version 3.2.1+`

  * Open Package Manager (Window > Package Manager) 
  * Click on the `+` button on the top left
  * Click on `Add package by name...`
  * Enter `com.unity.nuget.newtonsoft-json`
  * Install the package

## Installing This Package

After installing the dependencies stated above, follow the following steps:

* Download the [latest version](https://github.com/shdw9/fulldome_previz_plugin/archive/refs/heads/main.zip) of this package
* Extract the folder somewhere in your computer (preferably inside the Unity Scene's Packages folder)
* Open Package Manager (Window > Package Manager)
* Click on the `+` button on the top left
* Click on `Add package from disk...`
* Navigate to the extracted folder
* Locate the package.json file
* Install the package

## Optional Downloads

> Software used to stream from Unity to the dome

- [Spout](http://spout.zeal.co/) (video routing software)
- [KlakSpout](https://github.com/keijiro/KlakSpout) (Unity plugin for Spout)
