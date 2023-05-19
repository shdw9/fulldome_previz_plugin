# Fulldome Previsualiation: Usage Documentation
For documentation regarding the fulldome camera, see [fulldome docs](https://github.com/shdw9/fulldome_previz_plugin/blob/main/Documentation~/Fulldome.md)

For documentation regarding installation, see [installation docs](https://github.com/shdw9/fulldome_previz_plugin/blob/main/Documentation~/Installation.md)

## Timeline Window
The timeline window allows you to create and edit cinematic content, gameplay sequences, audio sequences, and animations

To open the Timeline Window:
`Window > Sequencing > Timeline`

## Animation Window
The animation window allows you to create and modify animation clips/keyframes inside of Unity.

To open the Animation Window:
`USD > Previzualiation Panels > Animation Window`

## Importing USD file with Timeline Clip
This menu option will import USD files with their animation imported as a timeline clip in Unity.

To use this menu option:
`USD > Import with Timeline Clip`

## Exporting USD file
 Using the USD Unity SDK, the optimal way to export a usd file is through Unity Recorder.
 
- Unity Recorder
  - Open Unity Recorder via `USD > Export Scene with Unity Recorder` 
  - Click on `+ Add Recorder`
  - Select `USD Clip`
  - Drag the root USD scene game object into the Recorder window
  - Click `Start Recording`

## Exporting Timeline Information to JSON
This feature saves the information of the timeline into a JSON format, which can be used to import in other digital content creation tools if a pipeline were made to parse these JSON files.

This will save all information of tracks inside of the timeline, and all information of clips inside of the track.
