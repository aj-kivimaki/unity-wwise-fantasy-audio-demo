# Devlog 018 — Audio Bus Architecture & Mixing Foundation

## Overview

Reviewed and refined the project's audio bus architecture to establish a scalable routing structure and prepare the project for final mixing during later development stages.

The implementation focused on improving project organization and routing rather than introducing unnecessary processing or complexity.

---

## Objectives

- Review bus hierarchy
- Review audio routing
- Improve project scalability
- Prepare mixing foundation
- Validate runtime behaviour

---

## Bus Hierarchy Review

The existing audio bus structure was evaluated against the current project scope.

Rather than introducing additional category buses prematurely, the hierarchy was refined only where it provided immediate value.

A dedicated **Player** bus was added beneath the **SFX** bus.

Current hierarchy:

Main Audio Bus

- Music
- Ambience
- SFX
  - Player

- UI
- Voice
- AUX_Corridor

This structure reflects the current gameplay implementation while providing a clear path for future expansion.

---

## Routing

Player audio was rerouted to the dedicated Player bus.

Current signal flow:

Player_SFX

↓

Player Bus

↓

SFX Bus

↓

Main Audio Bus

This allows all player-related audio to be managed from a single location without affecting future SFX categories.

---

## Mixing Strategy

Bus volumes intentionally remain at their default values.

Individual asset balancing continues to be performed at the object and container level until the complete audio implementation is available.

Category-level balancing and bus processing are deferred until Milestone 3.

---

## Validation

Verified:

- Bus routing
- Gameplay audio playback
- Interactive music
- Environmental ambience
- Environmental DSP
- Auxiliary Bus functionality

No regressions were introduced.

---

## Outcome

The project now contains a scalable and production-oriented audio bus hierarchy that supports future expansion without unnecessary complexity.

The implementation establishes the technical foundation for the final gameplay mix planned during Milestone 3.
