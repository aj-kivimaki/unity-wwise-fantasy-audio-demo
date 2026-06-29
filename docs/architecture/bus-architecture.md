# Bus Architecture

## Overview

The project uses a dedicated audio bus hierarchy to organize routing, mixing, and future processing of gameplay audio.

Rather than routing sounds directly to the Main Audio Bus, audio is grouped into logical categories that represent their role within the mix. This approach improves maintainability, simplifies balancing, and provides clear locations for future processing.

The current implementation intentionally establishes the routing foundation while deferring artistic mixing decisions until all major audio content has been implemented.

---

# Design Goals

The bus architecture was designed to:

- Separate audio into logical mix categories.
- Keep routing simple and maintainable.
- Support future bus-level processing.
- Allow independent balancing of gameplay systems.
- Scale naturally as the project grows.

---

# Bus Hierarchy

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

Each bus represents a gameplay responsibility rather than a collection of individual sounds.

---

# Bus Responsibilities

## Main Audio Bus

The Main Audio Bus serves as the project's final output stage.

All category buses ultimately route through this bus before reaching the audio device.

No additional processing is currently applied at this level.

---

## Music

The Music bus receives all Interactive Music playback.

Current routing:

```text
Music Switch Container
        ↓
Music Bus
        ↓
Main Audio Bus
```

Keeping all music on a dedicated bus allows future implementation of:

- Bus-level EQ
- Compression
- Loudness balancing
- Dynamic ducking

without modifying individual music objects.

---

## Ambience

The Ambience bus contains all environmental ambience.

Current environments include:

- Dungeon
- Arena
- Shrine

Grouping environmental ambience into a dedicated bus allows the entire environmental layer to be adjusted independently from gameplay sound effects.

---

## SFX

The SFX bus represents general gameplay sound effects.

Rather than routing individual sounds directly to the Main Audio Bus, all gameplay effects pass through this category first.

Future systems such as enemy audio, environmental interactions, and combat effects can be added without changing the overall routing structure.

---

## Player

A dedicated Player bus exists beneath the SFX bus.

Current player sounds include:

- Footsteps
- Jump
- Landing

This additional routing layer provides a dedicated control point for all player-generated sounds.

Future additions may include:

- Weapon sounds
- Attacks
- Rolls
- Interactions

The Player bus allows these sounds to be balanced or processed independently while still belonging to the overall SFX category.

---

## UI

The UI bus is currently reserved for future implementation.

Although unused, it remains part of the hierarchy because interface sounds represent a standard production mix category.

Future examples include:

- Button clicks
- Menu transitions
- Notifications

---

## Voice

The Voice bus is reserved for dialogue and voice-over.

Maintaining this bus from the beginning allows future expansion without requiring structural changes to the mix hierarchy.

---

## AUX_Corridor

The Auxiliary Bus is dedicated to environmental reverb.

It contains the RoomVerb effect used by Unity AkEnvironment components.

Player sounds send audio to this bus through Game-Defined Auxiliary Sends, allowing environmental acoustics to be controlled automatically by gameplay.

---

# Routing Philosophy

Audio routing relies heavily on inheritance.

Examples include:

- Music playlists inherit routing from the Music Switch Container.
- Player sound effects inherit routing from the Player bus.
- Child objects inherit parent output assignments.

This minimizes duplicated configuration while keeping the project easy to maintain.

---

# Mixing Strategy

All buses currently remain at **0 dB**.

Balancing individual sounds occurs at the object or container level during development.

Category-level balancing has intentionally been postponed until Milestone 3, when the complete audio implementation will be available.

This separates:

- Asset balancing
- Category balancing
- Final mix

into distinct stages of development.

---

# Mixing Philosophy

Each bus represents a different gameplay responsibility.

| Bus      | Primary Responsibility |
| -------- | ---------------------- |
| Music    | Emotion and pacing     |
| Ambience | Sense of place         |
| SFX      | Gameplay feedback      |
| UI       | Player communication   |
| Voice    | Narrative clarity      |

This philosophy guides future mixing decisions by prioritizing gameplay information over purely aesthetic audio.

---

# Future Expansion

The current architecture supports future implementation of:

- Bus-level EQ
- Compression
- Loudness balancing
- Dynamic ducking
- Snapshot mixing
- Additional gameplay categories
- Dialogue processing
- Final mastering

No structural changes are expected before these features are introduced.

---

# Summary

The project's bus architecture establishes a clean and scalable routing foundation that separates gameplay audio into logical mix categories.

By emphasizing inheritance, clear responsibilities, and minimal complexity, the current implementation supports future expansion while remaining straightforward to understand and maintain.
