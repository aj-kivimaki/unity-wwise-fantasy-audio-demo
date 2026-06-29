# Gameplay-Driven Adaptive Music Transition

## Objective

Implement gameplay-controlled adaptive music using Unity triggers and Wwise Music States.

---

## Unity

Created:

- MusicManager
- CombatMusicTrigger

MusicManager centralizes all interaction with Wwise.

Responsibilities:

- Start exploration music
- Set Exploration State
- Set Combat State
- Stop music

CombatMusicTrigger detects player entry and requests the Combat state from MusicManager.

---

## Wwise

Implemented:

- Music Switch Container
- Exploration Playlist
- Combat Playlist
- Exploration Music Segment
- Combat Music Segment
- Music State Group

Music playback remains active while the Music Switch Container changes the active playlist according to the Music State.

---

## Communication Flow

Unity Trigger

↓

MusicManager.SetCombat()

↓

AkSoundEngine.SetState()

↓

Music State changes

↓

Music Switch Container switches playlist

↓

Combat music plays

---

## Validation

Verified using:

- Unity gameplay
- Wwise Authoring
- Wwise Profiler

Profiler confirms successful state changes and playlist transitions.

---

## Future Improvements

Milestone 3:

- Transition stingers
- Transition segments
- Musical phrase synchronization
- Original soundtrack
- Vertical remixing
