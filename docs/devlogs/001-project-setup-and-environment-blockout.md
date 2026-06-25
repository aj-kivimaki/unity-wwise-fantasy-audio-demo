# Dev Log 001 - Project Setup and Environment Blockout

Date: June 2026

## Goal

Create the foundation for the Unity + Wwise portfolio project and establish a playable environment for future audio implementation.

## Progress

Created the Unity project, configured Git and GitHub, and established a clean folder structure.

Imported Unity Starter Assets and learned the workflow for setting up a third-person controller, camera system, and scene management. Encountered camera configuration issues while moving assets into the custom scene and successfully recovered changes using Git.

Imported KayKit Dungeon Remastered and KayKit Skeletons.

Built a simple dungeon layout consisting of:

- Spawn Area
- Corridor
- Gate
- Combat Arena
- Shrine

The design intentionally prioritizes audio implementation opportunities over gameplay complexity.

## Challenges

- Understanding Unity scene navigation.
- Working with Cinemachine and camera references.
- Learning modular environment construction.
- Recovering scene changes using Git after accidentally modifying the sample scene.

## Key Takeaways

The environment does not need to be visually impressive to support a strong game audio portfolio piece. The focus should remain on interactive music, audio systems, sound design, and implementation.

The current environment now supports future implementation of:

- Exploration music
- Combat music
- Reward music
- Ambient zones
- Footstep systems
- Wwise state changes
- Audio triggers

## Next Step

Integrate Wwise and verify communication between Unity and Wwise by successfully triggering a Wwise event from the Unity scene.
