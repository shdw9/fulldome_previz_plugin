
<p align="center">
  <img src="https://raw.githubusercontent.com/shdw9/fulldome_previz_plugin/main/Documentation%7E/images/fullDomePreviz.png" width="400" class="margin-left: auto; margin-right: auto;" />
</p>

# Fulldome Previsualization: Fulldome Addon for Unity USD
This repository contains the source code for the `Fulldome Previsualization in Unity` plugin. Based on a student project proposal by Jeroen Lapré for the Computer Science Department of San Francisco State University. It is an addon to the [Unity's USD package](https://github.com/Unity-Technologies/usd-unity-sdk) and adds features that would create a fulldome camera to allow users to visualize USD scenes in fulldome in Unity.

![package manager ss](https://i.imgur.com/FTzFh7l.png)

## Documentation

For more documentation about this package, see the [package docs](https://github.com/shdw9/fulldome_previz_plugin/blob/main/Documentation~/Usage.md)

## Features

The following is a brief list of features of this addon:

* Importing and exporting USD
   * Import with Timeline
     * Import usd files with a timeline animation attached
     * File formats: `.usd, .usda, .usdc, .usdz`
   * Export Scene with Unity Recorder
     * Export usd files with custom settings *(target fps, interpolation, scale)*
     * File formats: `.usd, .usda, .usdz`
* Fulldome Camera Rig
  * Toggle scene cameras to be seen through a fulldome lens
  * To stream fulldome footage to the dome, see [fulldome docs](https://github.com/shdw9/fulldome_previz_plugin/tree/main/Documentation~/Fulldome.md)
  * Utilizies Open Source Project: [FulldomeCameraForUnity](https://github.com/rsodre/FulldomeCameraForUnity)
* Export Timeline Information
  * Save timeline changes to a JSON file
  * Allows you to import that information to different Digital Content Creation tools

## Dependencies
For a more detailed guide, see [installation docs](https://github.com/shdw9/fulldome_previz_plugin/tree/main/Documentation~/Installation.md)

* [Unity Recorder](https://docs.unity3d.com/Packages/com.unity.recorder@4.0/manual/index.html) `version 4.0.0+`
* [Unity USD SDK](https://github.com/Unity-Technologies/usd-unity-sdk) `dev branch`
* [Newtonsoft Json](https://www.newtonsoft.com/json) `version 3.2.1+`

## License

The `Fulldome Previsualization in Unity` package is licensed under the terms of the MIT license. See [LICENSE](https://github.com/shdw9/fulldome_previz_plugin/blob/main/LICENSE) for more information.

## Credits

*Made from our standalone version which was discontinued, [fulldome_previz_unity](https://github.com/shdw9/fulldome_previz_unity)*

*Special thanks to the audio team (Nathan, Ky, Ryutaro, and Jared) and Mark D. for the artwork!*

*SFSU CSC 631 (Spring 2023) Team 3B - Clark-Kent Victa, Austin Nguyen, Joshua Del Rosario*
