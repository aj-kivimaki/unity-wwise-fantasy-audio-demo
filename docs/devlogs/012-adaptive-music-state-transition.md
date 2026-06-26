# Devlog 012 — Gameplay-Driven Adaptive Music Transition

## Overview

Implemented the first gameplay-driven adaptive music transition using Wwise Music States and Unity trigger volumes.

The system now transitions between Exploration and Combat music entirely through gameplay events.

---

## Implementation

Created a dedicated MusicManager responsible for all music playback and music state management.

Responsibilities include:

- Starting exploration music
- Switching between Music States
- Stopping music
- Singleton lifetime management

Gameplay no longer communicates directly with Wwise. Instead, gameplay systems communicate with MusicManager.

---

## Gameplay Trigger

Created a dedicated CombatMusicTrigger GameObject positioned at the arena gate.

When the player enters the trigger:

- Combat Music State is activated
- Wwise Music Switch Container changes playlist
- Combat music begins according to the configured transition rules

The trigger disables itself after activation.

---

## Architecture

Player
→ CombatMusicTrigger
→ MusicManager
→ Wwise State
→ Music Switch Container
→ Music Playlist
→ Music Segment

This architecture cleanly separates gameplay logic from audio implementation.

---

## Validation

Verified:

- Exploration music starts automatically.
- Combat trigger activates correctly.
- Music State changes successfully.
- Wwise Profiler confirms state transition.
- Exploration and Combat playlists switch correctly.
- Existing gameplay audio remains unaffected.

---

## Notes

Placeholder music is currently used.

Transition polish, stingers, transition segments and original compositions will be implemented during Milestone 3.
