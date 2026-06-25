# Devlog 004 – Dungeon Ambience System

## Goal

The objective of this milestone was to establish the first environmental ambience system for the fantasy dungeon prototype. The system serves as a foundation for future environmental audio design while expanding the project's Wwise implementation beyond character-driven sound effects.

## Implementation

A placeholder dungeon ambience loop was imported into Wwise and organized under a dedicated Ambience hierarchy.

Wwise structure:

- Ambience
  - Dungeon
    - Dungeon_Ambience

Dedicated playback events were created:

- Play_Dungeon_Ambience
- Stop_Dungeon_Ambience

The ambience object was configured to loop continuously and included in the project's SoundBank generation process.

In Unity, a DungeonAmbience GameObject was created and configured with an AkAmbient component. The ambience event is triggered automatically when the scene starts.

## Testing

The system was tested in the playable prototype to verify:

- Successful SoundBank generation
- Correct Wwise initialization
- Automatic ambience playback
- Compatibility with the existing footstep system
- Absence of console errors or warnings

Testing confirmed that the ambience and footstep systems operate simultaneously without conflicts.

## Result

The prototype now contains a persistent environmental audio layer that helps establish the atmosphere of the dungeon environment.

This milestone represents the first implementation of environmental ambience within the project and provides a foundation for future zone-based ambience systems and adaptive environmental audio.

## Next Steps

- Create shrine-specific ambience
- Create arena ambience
- Implement ambience zones and transitions
- Begin adaptive music system planning
