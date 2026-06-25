# Audio Bus Architecture

## Overview

The project uses a dedicated audio bus hierarchy to separate content organization from audio mixing.

This structure simplifies volume balancing, DSP processing, and future adaptive audio implementation.

---

## Audio Bus Hierarchy

Master Audio Bus

- Music
- Ambience
- SFX
- UI
- Voice

Each category represents a logical mix bus rather than a gameplay system.

---

## Content Hierarchy

The Actor-Mixer hierarchy is organized using Property Containers.

Property Containers

- Ambience
- Player_SFX
- Music

Virtual Folders

- Arena
- Dungeon
- Shrine
- Footsteps
- Jump
- Landing

Property Containers are responsible for routing, while Virtual Folders provide organization only.

---

## Routing

Output Bus assignments are configured on the top-level Property Containers.

| Property Container | Output Bus |
| ------------------ | ---------- |
| Ambience           | Ambience   |
| Player_SFX         | SFX        |
| Music              | Music      |

Child objects inherit routing automatically.

---

## Spatial Audio

Localized ambience sounds define their own spatial behavior.

| Sound            | Attenuation        |
| ---------------- | ------------------ |
| Dungeon Ambience | None (Global)      |
| Shrine Ambience  | Shrine Attenuation |
| Arena Ambience   | Arena Attenuation  |

This allows the project to combine global ambience with localized environmental audio.

---

## Benefits

The architecture provides:

- Centralized mix control
- Simplified content organization
- Consistent routing through inheritance
- Support for future DSP processing
- Foundation for adaptive music
- Scalable project organization

---

## Future Applications

The bus hierarchy enables future features including:

- Music and ambience balancing
- Indoor/outdoor EQ processing
- Environmental reverb sends
- Audio ducking
- Dynamic mixing
- Adaptive music implementation
