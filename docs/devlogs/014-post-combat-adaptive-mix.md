# Devlog 014 — Post-Combat Adaptive Music Mix

## Overview

Implemented a dedicated adaptive music mix for the PostCombat gameplay state.

The music system now distinguishes between the Exploration and PostCombat gameplay states, allowing each state to present the same musical material with different mixing characteristics while maintaining continuous playback.

---

## Objective

Separate the audio presentation of the Exploration and PostCombat gameplay states.

Although both states currently use the same Music Segment, the introduction of an independent PostCombat Playlist allows each state to evolve independently as the project grows.

This establishes a scalable architecture for future adaptive music development.

---

## Unity Implementation

No gameplay code changes were required.

The existing gameplay flow remains:

Exploration

↓

Combat

↓

PostCombat

Unity simply communicates gameplay state changes through MusicManager while Wwise determines the resulting audio presentation.

---

## Wwise Implementation

Created a dedicated Playlist Container:

- PL_PostCombat

Updated the Music Switch Container:

- Exploration → PL_Exploration
- Combat → PL_Combat
- PostCombat → PL_PostCombat

The PostCombat Playlist currently references the same Music Segment used by Exploration.

The PostCombat Playlist volume was reduced by approximately **-9 dB**, creating a noticeably calmer atmosphere while maintaining continuous playback.

---

## Architecture

Gameplay

↓

PostCombat State

↓

Music Switch Container

↓

PL_PostCombat

↓

MS_Exploration

This demonstrates one of the primary advantages of middleware: gameplay communicates only the current game state while Wwise controls how that state is presented sonically.

---

## Validation

Verified:

- Exploration mix remains unchanged.
- Combat mix remains unchanged.
- PostCombat uses an independent Playlist.
- Continuous playback is preserved.
- Music does not restart.
- Wwise Profiler confirms correct Music State transitions.
- Existing gameplay audio remains unaffected.

---

## Notes

The independent PostCombat Playlist provides the foundation for future enhancements without requiring Unity code changes.

Planned improvements include:

- Dedicated PostCombat arrangement
- Transition stingers
- Vertical remixing
- Original music
- Shrine-focused adaptive mixing
