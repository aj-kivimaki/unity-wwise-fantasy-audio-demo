# Environmental Audio

## Overview

The project implements gameplay-driven environmental audio using Unity and Audiokinetic Wwise.

Environmental acoustics are achieved through a combination of localized ambience, attenuation, Auxiliary Busses, AkEnvironment components, and Game-Defined Auxiliary Sends.

Rather than manually controlling audio effects through gameplay code, Unity communicates environmental context while Wwise manages spatialization and digital signal processing.

---

# Design Goals

The environmental audio system was designed to:

* Create distinct acoustic spaces.
* Keep gameplay logic independent from DSP processing.
* Encourage reuse through ShareSets.
* Minimize duplicated configuration.
* Support future environmental expansion.

---

# System Architecture

```text
Player
    │
    ▼
AkGameObj
    │
    ▼
AkEnvironment
    │
    ▼
Game-Defined Auxiliary Send
    │
    ▼
AUX_Corridor
    │
    ▼
RoomVerb
```

Gameplay determines where the player is.

Wwise determines how the environment should sound.

---

# Environmental Ambience

The project currently contains three environmental ambience layers.

## Dungeon

The Dungeon ambience represents the project's persistent environmental soundscape.

Characteristics:

* Non-spatial
* Scene-wide playback
* Starts automatically
* Provides the base environmental atmosphere

---

## Arena

Arena ambience becomes active when gameplay enters the combat area.

Characteristics:

* Trigger-driven playback
* Controlled by AmbienceManager
* Supports gameplay progression

---

## Shrine

Shrine ambience introduces a localized environmental layer.

Characteristics:

* Spatialized
* Uses attenuation
* Trigger-driven playback
* Becomes increasingly prominent as the player approaches the shrine

---

# Ambience Management

Environmental ambience is controlled through a centralized **AmbienceManager**.

Responsibilities include:

* Starting ambience
* Stopping ambience
* Preventing duplicate playback
* Managing playback state

Gameplay triggers communicate only gameplay events.

The AmbienceManager handles all communication with Wwise.

---

# Attenuation

Localized ambience uses Wwise Attenuation ShareSets.

Current ShareSets include:

* Arena_Attenuation
* Shrine_Attenuation

Attenuation controls:

* Audible distance
* Volume falloff
* Spatial positioning

Using ShareSets allows multiple objects to reuse the same attenuation settings while maintaining consistency throughout the project.

---

# Environmental Reverb

Environmental reverb is implemented using an Auxiliary Bus.

Current implementation:

```text
AUX_Corridor
```

The Auxiliary Bus contains a RoomVerb effect that simulates the reflective acoustic characteristics of the dungeon corridor.

Player sounds automatically send signal to the Auxiliary Bus when entering an active acoustic space.

---

# AkEnvironment

Unity AkEnvironment components define acoustic regions within the level.

Responsibilities include:

* Detecting player presence.
* Applying Auxiliary Sends.
* Communicating environmental context to Wwise.

No gameplay scripting is required for reverb behaviour.

---

# Game-Defined Auxiliary Sends

Player sound effects use **Game-Defined Auxiliary Sends**.

This allows Wwise to determine the appropriate environmental processing based on the player's current location.

Benefits include:

* No manual DSP control
* Cleaner gameplay code
* Automatic environmental transitions
* Scalable implementation

---

# Audio Flow

```text
Player Movement
        │
        ▼
Trigger Volume
        │
        ▼
AkEnvironment
        │
        ▼
Auxiliary Send
        │
        ▼
RoomVerb
        │
        ▼
Final Output
```

Gameplay determines location.

Wwise determines acoustics.

---

# Design Decisions

## Gameplay controls context

Unity determines **where** the player is.

Wwise determines **how that location sounds**.

---

## Reuse through ShareSets

Attenuation settings are shared across multiple objects where appropriate.

This minimizes duplicated authoring and keeps environmental behaviour consistent.

---

## DSP belongs in middleware

No gameplay code directly controls reverbs or audio effects.

Environmental processing remains entirely within Wwise, allowing acoustic adjustments without modifying Unity code.

---

# Future Expansion

The current architecture supports future additions such as:

* Multiple Auxiliary Busses
* Indoor and outdoor transitions
* Cave acoustics
* Dynamic weather effects
* Occlusion and obstruction
* Additional environmental emitters
* Layered ambience
* Surface-specific environmental responses

These features can be introduced without changing the existing architecture.

---

# Summary

The environmental audio system demonstrates a gameplay-driven workflow where Unity communicates environmental context and Wwise manages spatialization, attenuation, and acoustic processing.

The implementation emphasizes maintainability, reuse, and separation of responsibilities while providing a scalable foundation for future environmental sound design.
