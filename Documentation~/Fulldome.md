# Fulldome Previsualization: Fulldome Camera Documentation

## Fulldome / Fisheye Lens

To attach a fulldome / fisheye lens to a camera, go to `USD > Previsualization Panels > Add Fulldome Camera`

![image](https://i.imgur.com/RCGaYM1.png)

The difference between the two lenses is seen below:
- Fisheye Lens
<img src="https://i.imgur.com/wFa9ykM.png" width="400" class="margin-left: auto; margin-right: auto;" />

- Fulldome Lens
<img src="https://i.imgur.com/e0BLqHK.png" width="400" class="margin-left: auto; margin-right: auto;" />

This will create a FulldomeCamera Object in the root of the scene and it will automatically import the [FulldomeCameraForUnity Script](https://github.com/rsodre/FulldomeCameraForUnity).

## FulldomeCameraForUnity Script Settings

You can customize the horizon, dome tilt, and cubemap faces of the FulldomeCamera Object by clicking on the "Fulldome Camera" game object in the Unity hierarchy.

![fdc settings](https://i.imgur.com/IdqbSj6.png)

## Streaming to the Dome

In order to stream to the Dome itself, you would have to use [Spout](https://spout.zeal.co/) (video routing software for Windows)

To use Spout with Unity, you would have to download [KlakSpout](https://github.com/keijiro/KlakSpout) which allows you to add a `SpoutSender` component to the Fulldome Camera game object

*from the FulldomeCameraForUnity documentation*
