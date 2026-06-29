# Project Architecture

## Overview

This project demonstrates a gameplay-driven audio architecture built with **Unity 6** and **Audiokinetic Wwise 2025**.

The implementation separates gameplay logic from audio behaviour by assigning clear responsibilities to Unity and Wwise.

Unity determines **what is happening** during gameplay.

Wwise determines **how it should sound**.

This separation creates a maintainable architecture that is easy to expand without introducing unnecessary coupling between gameplay systems and middleware.

---

# Design Philosophy

The project follows three guiding principles.

## Gameplay communicates intent

Gameplay systems never select individual sounds.

Instead they communicate gameplay events such as:

- Exploration
- Combat
- PostCombat
- Entering an environment
- Jumping
- Landing

Wwise interprets these events and determines the resulting audio behaviour.

---

## Middleware owns audio behaviour

Audio-specific behaviour remains inside Wwise.

Examples include:

- Interactive Music
- Randomization
- Mixing
- Voice Management
- Environmental DSP
- Attenuation
- Audio Routing

This allows audio implementation to evolve without modifying gameplay code.

---

## Clear system responsibilities

Each component has a single responsibility.

No gameplay script directly manages multiple audio systems.

---

# High-Level Architecture

```text
                     Unity
────────────────────────────────────────────

 Player Controller

        │

        ▼

 Gameplay Detection

        │

        ▼

 Audio Managers

 ├── MusicManager
 └── AmbienceManager

        │

        ▼

 Wwise Integration API

────────────────────────────────────────────

        │

        ▼

            Wwise

 Events

 States

 Game Objects

 Auxiliary Sends

        │

        ▼

 Interactive Music

 Gameplay Audio

 Environmental Audio

 Voice Management

 Audio Routing

 SoundBanks

        │

        ▼

      Final Mix
```

---

# Unity Systems

## MusicManager

Responsible for:

- Starting music
- Changing music states
- Stopping music

MusicManager never selects musical assets directly.

Its only responsibility is communicating gameplay state.

---

## AmbienceManager

Responsible for:

- Starting ambience
- Stopping ambience
- Preventing duplicate playback
- Tracking active ambience

Gameplay triggers communicate only environmental events.

AmbienceManager translates those events into Wwise playback requests.

---

## Gameplay Triggers

Trigger volumes detect player progression through the level.

Examples include:

- Combat start
- Combat completion
- Shrine approach

Triggers never contain audio implementation logic.

They communicate with the appropriate manager.

---

# Wwise Systems

## Interactive Music

Uses:

- Music States
- Switch Container
- Playlist Containers
- Music Segments

The system maintains continuous playback while adapting to gameplay progression.

---

## Gameplay Audio

Player movement audio includes:

- Footsteps
- Jump
- Landing

Playback is event-driven and uses Random Containers where appropriate.

---

## Environmental Audio

Environmental ambience and acoustics are implemented using:

- Ambience events
- Attenuation ShareSets
- Auxiliary Busses
- RoomVerb
- AkEnvironment

Gameplay determines environmental context while Wwise controls acoustic behaviour.

---

## Audio Routing

Audio is organized into dedicated mix categories.

```text
Main Audio Bus

├── Music
├── Ambience
├── SFX
│     └── Player
├── UI
├── Voice
└── AUX_Corridor
```

This routing hierarchy supports future balancing and processing without modifying gameplay systems.

---

# Communication Flow

## Interactive Music

```text
Gameplay

↓

MusicManager

↓

SetState()

↓

Music State

↓

Switch Container

↓

Playlist

↓

Music Segment

↓

Music Bus
```

---

## Gameplay Audio

```text
Gameplay Event

↓

PostEvent()

↓

Wwise Event

↓

Random Container

↓

Player Bus

↓

SFX Bus
```

---

## Environmental Audio

```text
Player

↓

Trigger Volume

↓

AmbienceManager

↓

Wwise Event

↓

AkAmbient

↓

Attenuation

↓

Auxiliary Send

↓

RoomVerb
```

---

# Separation of Responsibilities

| Unity               | Wwise             |
| ------------------- | ----------------- |
| Detect gameplay     | Playback          |
| Trigger events      | Randomization     |
| Change states       | Mixing            |
| Control progression | Voice Management  |
| Manage gameplay     | Environmental DSP |
| Manage managers     | Interactive Music |

Each system performs only the tasks appropriate to its domain.

---

# Data Flow

The architecture follows a one-way communication model.

```text
Gameplay

↓

Managers

↓

Wwise API

↓

Middleware

↓

Audio Output
```

Gameplay never queries Wwise for playback decisions.

Audio behaviour remains entirely data-driven.

---

# Scalability

The architecture supports future additions including:

- Additional gameplay states
- Combat intensity
- Dynamic music layers
- Original soundtrack
- Dialogue
- Surface-dependent footsteps
- Enemy audio
- Streaming SoundBanks
- Snapshot mixing

These additions can be implemented without restructuring existing systems.

---

# Benefits

The current architecture provides:

- Clear separation between gameplay and audio.
- Minimal coupling between Unity and Wwise.
- Scalable middleware implementation.
- Simple debugging.
- Consistent event flow.
- Maintainable project organization.
- Straightforward future expansion.

---

# Summary

The project architecture demonstrates a production-oriented workflow in which Unity communicates gameplay intent and Wwise manages all audio behaviour.

By assigning clear responsibilities to each system and maintaining a one-way communication model, the implementation remains simple, scalable, and easy to maintain while supporting future creative and technical expansion.
