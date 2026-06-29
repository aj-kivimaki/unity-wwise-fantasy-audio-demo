# Milestone 2 – Adaptive Audio Systems

## Overview

Milestone 2 focused on transforming the project from a collection of individual audio features into a cohesive gameplay-driven audio architecture.

The objective was not to produce a final mix or complete sound design, but to establish the technical systems that will support future creative work.

By the end of this milestone, the project contains a complete middleware foundation for interactive music, gameplay audio, environmental ambience, environmental DSP, audio routing, voice management, and asset organization.

---

# Milestone Goals

The primary objectives for Milestone 2 were:

- Implement adaptive music.
- Introduce gameplay-driven ambience.
- Establish environmental acoustics.
- Create a scalable audio bus hierarchy.
- Review asset organization.
- Configure voice management.
- Build maintainable Unity ↔ Wwise communication.

All planned objectives were completed.

---

# Completed Systems

## Interactive Music

Implemented a complete horizontal adaptive music workflow using Wwise Interactive Music.

Features include:

- Music States
- Switch Container
- Playlist Containers
- Music Segments
- Continuous playback
- Gameplay-driven state changes

Unity communicates gameplay intent while Wwise manages playback.

---

## Gameplay Audio

Expanded player audio implementation with:

- Randomized footsteps
- Jump
- Landing

Movement sounds are integrated through gameplay events and animation while remaining independent from middleware implementation details.

---

## Environmental Ambience

Implemented a centralized AmbienceManager responsible for environmental playback.

Current environments include:

- Dungeon
- Arena
- Shrine

Ambient playback now responds directly to player progression through the level.

---

## Environmental DSP

Implemented gameplay-driven environmental acoustics using:

- Auxiliary Bus
- RoomVerb
- AkEnvironment
- Game-Defined Auxiliary Sends

Player sound effects automatically receive environmental processing based on the active acoustic space.

---

## Audio Routing

Established a scalable bus hierarchy.

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

The hierarchy separates gameplay systems into logical mix categories while remaining intentionally simple.

---

## Voice Management

Reviewed playback behaviour for gameplay sounds.

Implemented playback limits for:

- Footsteps
- Jump
- Landing

Music and ambience intentionally rely on gameplay logic rather than middleware voice limiting.

---

## Asset Organization

Reviewed the overall Wwise project structure.

Implemented:

- Consistent naming
- Logical content hierarchy
- Reusable ShareSets
- Organized events
- Single SoundBank strategy

The project now follows a consistent organizational structure suitable for future expansion.

---

# Architectural Decisions

Several important design decisions were made during this milestone.

## Gameplay communicates intent

Unity communicates gameplay events and state changes.

Wwise controls playback behaviour.

---

## Middleware owns audio

Playback logic remains inside Wwise whenever possible.

Unity never selects individual music assets or controls DSP processing directly.

---

## Simplicity over complexity

The project intentionally avoids unnecessary abstraction.

Additional systems are introduced only when they provide clear architectural value.

---

## Future scalability

Every implemented system was designed so that additional content can be introduced without restructuring the project.

---

# Technical Features

By the end of Milestone 2 the project demonstrates:

- Unity 6 + Wwise integration
- Interactive Music
- Music States
- Switch Containers
- Playlist Containers
- Music Segments
- Random Containers
- Gameplay-driven ambience
- Trigger-based audio events
- Auxiliary Busses
- RoomVerb
- Attenuation ShareSets
- Environmental acoustics
- Audio bus hierarchy
- Voice management
- SoundBank organization
- Gameplay-driven architecture

---

# Lessons Learned

This milestone reinforced several key implementation principles.

- Gameplay systems should communicate intent rather than playback details.
- Middleware should own audio behaviour whenever possible.
- A simple architecture is easier to maintain than an over-engineered one.
- Consistent naming and organization significantly improve project readability.
- Technical foundations should be completed before creative polish.

These principles guided every implementation decision throughout the milestone.

---

# Preparing for Milestone 3

With the technical architecture complete, the project is ready to shift its focus from system implementation to creative development.

Planned areas of work include:

- Original soundtrack
- Original sound effects
- Material-dependent footsteps
- Transition stingers
- Vertical remixing
- Combat intensity
- Environmental sound design
- Final gameplay mix
- Overall polish

No major architectural changes are expected before these features are implemented.

---

# Outcome

Milestone 2 successfully established the technical foundation of the project.

The resulting architecture demonstrates production-oriented middleware integration, clean separation between gameplay and audio systems, and a scalable structure capable of supporting future expansion.

With the core systems in place, the project is well positioned to enter its final development phase, where the emphasis will shift from building audio systems to refining the player experience through original content and polish.
