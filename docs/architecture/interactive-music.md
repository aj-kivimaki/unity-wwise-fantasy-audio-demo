# Interactive Music

## Overview

The project implements adaptive horizontal music using **Audiokinetic Wwise Interactive Music** integrated with Unity.

The system is gameplay-driven. Unity communicates gameplay intent through Music States while Wwise manages playlist selection, transitions, and continuous playback.

This separation allows gameplay systems to remain independent from the musical implementation.

---

# Design Goals

The music system was designed around the following objectives:

- Continuous playback
- Gameplay-driven transitions
- Separation between gameplay and music logic
- Scalable architecture
- Minimal Unity-side implementation
- Easy future expansion

---

# System Architecture

```text
Unity Gameplay
        │
        ▼
MusicManager
        │
        ▼
Play_Music Event
        │
        ▼
Music Switch Container
        │
        ▼
Music State
        │
        ▼
Playlist Container
        │
        ▼
Music Segment
        │
        ▼
Music Bus
```

Unity communicates only gameplay state.

Wwise determines which musical content should be played.

---

# Unity Implementation

Music playback is managed by a dedicated **MusicManager**.

Responsibilities include:

- Starting gameplay music
- Changing Music States
- Stopping music
- Preventing duplicate playback

The manager intentionally exposes a small, explicit API that directly corresponds to gameplay events.

Current public methods:

- StartExplorationMusic()
- SetExploration()
- SetCombat()
- SetPostCombat()
- StopMusic()

The manager does not track musical content internally.

State ownership remains inside Wwise.

---

# Wwise Implementation

## Events

Only two events are required.

```text
Play_Music
Stop_Music
```

Music playback begins once.

All subsequent changes occur through State transitions.

---

## Music State Group

```text
Music

├── Exploration
├── Combat
└── PostCombat
```

The State Group represents gameplay situations rather than individual music tracks.

This allows musical content to evolve independently from gameplay code.

---

## Music Switch Container

The Music Switch Container serves as the central decision point for playback.

Based on the active Music State, it automatically selects the correct Playlist Container.

Unity never selects playlists directly.

---

## Playlist Containers

Current playlists:

```text
PL_Exploration
PL_Combat
PL_PostCombat
```

Each playlist represents a gameplay state.

Playlists can later contain multiple segments, transition rules, or additional adaptive behaviour without requiring Unity code changes.

---

## Music Segments

Current segments:

```text
MS_Exploration
MS_Combat
MS_PostCombat
```

Music Segments represent reusable musical material.

The current PostCombat implementation reuses exploration music while maintaining its own logical segment, allowing independent expansion in future milestones.

---

# Gameplay Flow

Current gameplay progression:

```text
Game Start
        │
        ▼
Exploration
        │
Combat Trigger
        ▼
Combat
        │
Combat End Trigger
        ▼
PostCombat
```

The demo intentionally remains in the PostCombat state after combat concludes.

A return to Exploration would be appropriate in a larger gameplay loop but is unnecessary for the scope of this demonstration.

---

# Continuous Playback

Music is started only once.

Subsequent gameplay changes modify only the active Music State.

Benefits include:

- No playback restart
- Seamless transitions
- Cleaner Unity implementation
- Improved scalability

This approach reflects common middleware workflows used in modern game development.

---

# Design Decisions

## Gameplay controls intent

Unity communicates:

- Exploration
- Combat
- PostCombat

Wwise decides how those states sound.

---

## Music States represent gameplay

States intentionally describe gameplay situations rather than music assets.

For example:

```text
Combat
```

instead of

```text
BattleTheme01
```

This keeps gameplay independent from content.

---

## Minimal Event Design

Only one Play event is required.

Additional playback events are unnecessary because the Interactive Music system manages playback internally.

---

## Reusable Musical Content

The current implementation allows multiple gameplay states to reference the same musical material while maintaining separate logical structures.

This supports rapid iteration during development and allows original compositions to replace placeholder material later without affecting gameplay systems.

---

# Future Expansion

The architecture is designed to support:

- Original soundtrack
- Transition stingers
- Vertical remixing
- Combat intensity layers
- RTPC-driven music behaviour
- Dynamic arrangements
- Additional gameplay states

These additions can be implemented without changing the Unity-side architecture.

---

# Summary

The interactive music system demonstrates a gameplay-driven middleware workflow where Unity communicates high-level gameplay intent and Wwise manages all music playback behaviour.

The implementation emphasizes simplicity, maintainability, and scalability while providing a solid technical foundation for future musical expansion.
