# Dev Log 002 - Wwise Integration and First Audio Playback

Date: June 2026

## Goal

Integrate Wwise into the Unity project and establish a working audio implementation pipeline between Unity and Wwise.

## Progress

Installed Wwise 2025.1.8 and created a dedicated Wwise project for the portfolio demo.

Integrated Wwise into the Unity project and configured the required project paths, SoundBank generation settings, and platform support.

Imported the first audio asset and created a basic Wwise event and SoundBank to verify communication between Unity and Wwise.

Encountered several configuration issues related to SoundBank generation, platform setup, and bank loading. Added macOS support to the Wwise project, regenerated SoundBanks, and verified that Unity could successfully locate and load the generated banks.

Created the first test event:

* Play_Weird_Stomp

Added Wwise components to the player character and successfully triggered the event from Unity, confirming audible playback within the game scene.

## Challenges

* Learning the Wwise project structure and workflow.
* Understanding the relationship between Events, SoundBanks, and audio assets.
* Resolving SoundBank generation issues caused by missing macOS platform configuration.
* Troubleshooting bank loading errors and Unity-Wwise path settings.

## Key Takeaways

Successful audio implementation requires more than importing sounds. The complete pipeline consists of audio assets, Events, SoundBanks, platform configuration, and communication between Wwise and the game engine.

Understanding how Wwise organizes and loads audio data is essential for future implementation of adaptive music systems, ambience, and gameplay audio.

The project now has a fully functional Unity-Wwise integration and a verified workflow for creating, generating, loading, and triggering audio events.

## Next Step

Begin implementing core gameplay audio systems, including footsteps, environmental ambience, trigger-based audio events, and the foundation for adaptive music transitions between exploration, combat, and shrine areas.
