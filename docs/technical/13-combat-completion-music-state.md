# Gameplay-Driven Combat Completion Music State

## Objective

Extend the adaptive music system by introducing a dedicated PostCombat Music State.

The goal is to complete the gameplay-driven adaptive music loop while maintaining continuous playback through the Wwise Music Switch Container.

---

## Unity

### New Components

CombatEndTrigger

Responsibilities:

- Detect player entering the throne area.
- Notify MusicManager that combat has ended.
- Prevent repeated activations.

MusicManager

Added:

- SetPostCombat()

MusicManager remains the single point of communication between gameplay systems and Wwise.

---

## Wwise

Implemented:

- PostCombat Music State
- Updated Music Switch Container
- Combat → PostCombat transition

Current Music States:

- None
- Exploration
- Combat
- PostCombat

For this milestone, PostCombat reuses the Exploration playlist.

This preserves gameplay architecture while allowing future audio implementation changes without modifying Unity code.

---

## Communication Flow

Player reaches throne

↓

CombatEndTrigger

↓

MusicManager.SetPostCombat()

↓

AkSoundEngine.SetState()

↓

PostCombat Music State

↓

Music Switch Container

↓

Exploration Playlist

---

## Validation

Verified using:

- Unity gameplay
- Wwise Authoring
- Wwise Profiler

Confirmed:

- Continuous playback
- Correct Music State transitions
- Correct playlist switching
- No additional Play_Music events

---

## Design Decisions

The project now communicates gameplay meaning instead of music implementation.

Gameplay requests:

- Exploration
- Combat
- PostCombat

Wwise determines:

- Which playlist plays
- Transition timing
- Future orchestration
- Future mixing

This separation keeps Unity independent from future music implementation changes.

---

## Future Improvements

Milestone 3 will expand the PostCombat state with:

- Dedicated post-combat arrangement
- Lower exploration music level
- Shrine ambience emphasis
- Transition stingers
- Vertical remixing
- RTPC-controlled intensity
