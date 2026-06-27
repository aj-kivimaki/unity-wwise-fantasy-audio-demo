# Devlog 016 — Environmental DSP Foundation

## Overview

Implemented the technical foundation for environmental acoustics using Wwise Auxiliary Busses, RoomVerb and Unity AkEnvironment components.

This milestone introduces gameplay-driven environmental DSP that reacts dynamically to the player's position within the level.

The objective was to establish a reusable architecture for environmental audio processing rather than artistic acoustic design.

---

## Objective

Implement gameplay-controlled environmental reverb using Wwise's environmental audio pipeline.

The implementation focuses on demonstrating professional middleware workflows while providing a scalable foundation for future environmental audio polish.

---

## Wwise Implementation

Created a dedicated Auxiliary Bus for corridor acoustics.

Implemented:

- AUX_Corridor
- RoomVerb effect
- Game-Defined Auxiliary Sends
- Environmental routing
- Unity AkEnvironment integration

Player sounds now inherit environmental processing through the Player_SFX hierarchy.

---

## Unity Implementation

Created a dedicated Environments hierarchy.

Implemented:

- CorridorEnvironment
- AkEnvironment component
- Trigger volume
- Kinematic Rigidbody
- Auxiliary Bus assignment

The player now automatically enters and exits acoustic spaces based on gameplay.

---

## Audio Routing

Player SFX

↓

Game-Defined Auxiliary Sends

↓

AkEnvironment

↓

AUX_Corridor

↓

RoomVerb

↓

Main Output

This routing separates gameplay logic from DSP processing while allowing environments to control acoustic behaviour dynamically.

---

## Validation

Verified:

- Auxiliary Bus assignment
- Environmental trigger detection
- RoomVerb processing
- Footsteps receive environmental DSP
- Jump and landing inherit Player_SFX routing
- Wwise Profiler confirms environmental routing
- Existing gameplay audio remains unaffected

---

## Notes

During implementation an integration issue was encountered when Auxiliary Busses were created outside the Main Audio Bus hierarchy.

Recreating the Auxiliary Busses within the Main Audio Bus resolved the issue and allowed Unity's AkEnvironment component to reference them correctly.

This implementation establishes the project's environmental DSP architecture and will be expanded with additional environments and artistic tuning during Milestone 3.
