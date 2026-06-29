# Environmental DSP Foundation

## Objective

Implement gameplay-driven environmental acoustics using Wwise Auxiliary Busses and Unity AkEnvironment components.

The objective is to establish a scalable technical architecture for environmental DSP before introducing artistic mixing and acoustic refinement.

---

## Wwise

Implemented:

- AUX_Corridor
- RoomVerb effect
- Game-Defined Auxiliary Sends

Player audio objects receive environmental processing through inheritance from the Player_SFX hierarchy.

This minimizes duplicated configuration and allows future player sounds to inherit environmental behaviour automatically.

---

## Unity

Created:

GamePlay

└── Environments

    └── CorridorEnvironment

CorridorEnvironment contains:

- AkEnvironment
- Box Collider (Trigger)
- Rigidbody (Kinematic)
- AUX_Corridor assignment

The environment defines an acoustic space that dynamically controls auxiliary routing.

---

## Audio Signal Flow

Gameplay

↓

Player enters CorridorEnvironment

↓

AkEnvironment

↓

Game-Defined Auxiliary Send

↓

AUX_Corridor

↓

RoomVerb

↓

Main Audio Bus

This architecture keeps gameplay independent from DSP implementation while allowing environmental audio behaviour to remain fully data-driven.

---

## Design Decisions

Environmental DSP is implemented using Game-Defined Auxiliary Sends rather than User-Defined Sends.

Advantages:

- Gameplay determines the active environment.
- Multiple environments can reuse the same implementation.
- Audio objects inherit environmental routing.
- Improved maintainability.
- Reduced configuration duplication.

Player_SFX is used as the inheritance point, allowing footsteps, jump and landing sounds to share the same environmental behaviour.

---

## Validation

Verified using:

- Unity gameplay
- Wwise Authoring
- Wwise Profiler

Confirmed:

- Environmental routing functions correctly.
- Auxiliary Bus receives environmental sends.
- RoomVerb processes player sounds.
- Environmental transitions occur automatically.
- Existing music and ambience systems remain unaffected.

---

## Future Improvements

Milestone 3 will extend this system with:

- Arena environment
- Shrine environment
- Environment-specific acoustic tuning
- Additional DSP effects
- Artistic reverb balancing
- Final environmental mixing
