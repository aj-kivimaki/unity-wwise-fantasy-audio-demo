# Gameplay Audio

## Overview

The gameplay audio system provides responsive audio feedback for core player actions while demonstrating clean integration between Unity and Audiokinetic Wwise.

Current implementation focuses on player movement audio and establishes a scalable architecture for future gameplay sound effects.

Implemented systems include:

- Footsteps
- Jump
- Landing

These systems demonstrate event-driven playback, randomized variation, animation integration, voice management, and structured audio routing.

---

# Design Goals

The gameplay audio system was designed to:

- Provide immediate player feedback.
- Keep gameplay code independent from audio implementation.
- Prevent repetitive playback.
- Support future gameplay expansion.
- Maintain clean communication between Unity and Wwise.

---

# System Architecture

```text
Player Input
      │
      ▼
Character Controller
      │
      ▼
Gameplay Detection
      │
      ▼
Animation / State Change
      │
      ▼
Wwise Event
      │
      ▼
Random Container
      │
      ▼
Player Bus
      │
      ▼
SFX Bus
```

Unity detects gameplay.

Wwise determines playback behaviour.

---

# Footsteps

Footsteps provide continuous movement feedback.

The system uses:

- Animation Events
- Random Container
- Multiple audio variations

Each animation event posts a single Wwise event.

The Random Container automatically selects an appropriate variation, reducing audible repetition without additional gameplay logic.

---

# Jump

Jump playback is triggered when the player transitions from a grounded state to airborne.

Unity detects the gameplay state change and posts a dedicated Wwise event.

Only one jump sound is allowed to play simultaneously for the player.

---

# Landing

Landing playback occurs when the player returns to the ground.

The implementation reuses the same grounded-state tracking logic introduced for the Jump system.

Like Jump, Landing uses voice limiting to prevent overlapping playback.

---

# Random Containers

Footsteps are implemented using a Random Container.

Benefits include:

- Automatic sample variation.
- Reduced repetition.
- Simplified Unity implementation.
- Easy expansion with additional samples.

Gameplay code remains unchanged regardless of how many variations are added.

---

# Voice Management

Voice Management is configured where it provides practical value.

Current settings:

| Audio     | Playback Limit |
| --------- | -------------: |
| Footsteps |              4 |
| Jump      |              1 |
| Landing   |              1 |

Music and ambience intentionally rely on gameplay systems rather than playback limits.

This separation keeps responsibilities clear and avoids redundant middleware configuration.

---

# Routing

All player sounds share the same routing path.

```text
Player_SFX
      │
      ▼
Player Bus
      │
      ▼
SFX Bus
      │
      ▼
Main Audio Bus
```

This structure allows future balancing and processing of all player-generated sounds from a single location.

---

# Environmental Processing

Player sounds support environmental acoustics through Game-Defined Auxiliary Sends.

When the player enters an active AkEnvironment, compatible sounds automatically receive RoomVerb processing.

No gameplay scripting is required.

---

# Design Decisions

## Animation drives playback

Footsteps are triggered directly from animation events.

This keeps audio synchronized with character movement and avoids timing logic inside gameplay code.

---

## Gameplay detects state

Jump and Landing use gameplay state transitions rather than animation events.

This approach provides reliable playback regardless of animation timing.

---

## Middleware owns playback

Unity decides **when** a gameplay event occurs.

Wwise decides:

- which sound to play,
- which variation to use,
- how many voices may play simultaneously,
- how environmental processing is applied.

---

# Future Expansion

The current architecture supports future additions including:

- Surface-dependent footsteps
- Sprint and crouch movement
- Player attacks
- Weapon audio
- Interaction sounds
- Enemy sound effects
- Collectibles
- Destructible objects
- Physics-based impacts

These additions can be implemented without changing the underlying architecture.

---

# Summary

The gameplay audio system demonstrates a responsive, event-driven workflow that cleanly separates gameplay logic from audio behaviour.

By combining Unity state detection with Wwise playback systems, the implementation remains simple, maintainable, and ready for future expansion while providing immediate and consistent feedback to the player.
