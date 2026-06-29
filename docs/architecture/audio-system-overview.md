# Audio System Overview

## Overview

This project demonstrates the implementation of a gameplay-driven audio system using **Unity 6** and **Audiokinetic Wwise 2025**.

The focus is on building scalable and maintainable audio systems rather than implementing isolated audio features. Gameplay logic, middleware implementation, and audio mixing responsibilities are intentionally separated to create an architecture that can evolve as the project grows.

The implementation includes interactive music, gameplay-driven ambience, environmental acoustics, audio routing, voice management, and structured middleware integration.

---

# Design Principles

The architecture is based on four core principles.

## Gameplay drives audio

Unity communicates gameplay intent.

Wwise determines how audio responds.

Gameplay systems communicate using Events, States and Game Objects rather than directly controlling individual sounds.

---

## Separation of Responsibilities

Each system has a single responsibility.

Unity

- Detect gameplay
- Trigger events
- Change game states

Wwise

- Playback
- Mixing
- Randomization
- Music transitions
- Environmental DSP
- Voice management

This separation keeps gameplay code independent from implementation details inside Wwise.

---

## Scalability

The project is intentionally designed to support future expansion without requiring structural changes.

Examples include:

- Additional environments
- Original soundtrack
- Material-based footsteps
- Combat intensity
- Dialogue
- Additional SoundBanks

---

## Simplicity

The project intentionally avoids unnecessary complexity.

New systems are only introduced when they provide clear architectural or gameplay value.

---

# High-Level Architecture

```text
Unity Gameplay
│
├── Player Controller
├── MusicManager
├── AmbienceManager
├── Gameplay Triggers
│
▼
Wwise Integration
│
├── Events
├── States
├── Game Objects
│
▼
Wwise Systems
│
├── Interactive Music
├── Gameplay SFX
├── Environmental Ambience
├── Environmental DSP
├── Voice Management
├── Bus Routing
└── SoundBanks
```

---

# Core Audio Systems

## Interactive Music

The project uses Wwise Interactive Music to implement adaptive horizontal music transitions.

Gameplay communicates only the current gameplay state while Wwise controls playlist selection and continuous playback.

Current states:

- Exploration
- Combat
- PostCombat

Music playback remains continuous throughout gameplay.

---

## Gameplay Audio

Gameplay sound effects currently include:

- Footsteps
- Jump
- Landing

Footsteps use Random Containers to reduce repetition, while Jump and Landing provide responsive movement feedback.

Playback rules are managed through Wwise Voice Management where appropriate.

---

## Environmental Ambience

Environmental ambience is controlled through a dedicated AmbienceManager.

Gameplay areas activate or deactivate ambient layers using trigger volumes while Wwise handles playback.

Current environments include:

- Dungeon
- Arena
- Shrine

---

## Environmental Acoustics

Environmental reverb is implemented using:

- Auxiliary Busses
- RoomVerb
- AkEnvironment
- Game-Defined Auxiliary Sends

Gameplay determines which acoustic space the player occupies while Wwise controls the resulting DSP processing.

---

# Audio Routing

Audio is organized into logical mix categories.

Current hierarchy:

```text
Main Audio Bus
├── Music
├── Ambience
├── SFX
│   └── Player
├── UI
├── Voice
└── AUX_Corridor
```

Each bus represents a gameplay responsibility rather than an individual asset type.

---

# Middleware Features

The project currently demonstrates the use of:

- Events
- States
- Interactive Music
- Playlist Containers
- Music Segments
- Switch Containers
- Random Containers
- Property Containers
- Auxiliary Busses
- ShareSets
- Attenuation ShareSets
- Voice Management
- SoundBanks
- Environmental DSP
- Bus Routing

---

# Unity Integration

Unity communicates with Wwise through centralized manager classes.

Current managers include:

- MusicManager
- AmbienceManager

Gameplay systems communicate with these managers instead of interacting with Wwise directly.

This keeps gameplay systems independent from middleware implementation details.

---

# Scalability

The current architecture supports future expansion without restructuring.

Planned Milestone 3 additions include:

- Original soundtrack
- Original sound effects
- Material-dependent footsteps
- Transition stingers
- Vertical remixing
- Combat intensity
- Dynamic environmental sound design
- Final gameplay mix

The existing architecture has been designed so these additions can be implemented without modifying the underlying system design.

---

# Summary

This project demonstrates a complete technical game audio implementation using Unity and Wwise.

Rather than focusing solely on audio content, the project emphasizes clean architecture, maintainable middleware integration, and production-oriented implementation practices.

The resulting system provides a solid technical foundation that supports future creative expansion while remaining straightforward to understand, debug, and extend.
