# Shrine Ambience System

## Overview

This milestone expands the environmental audio implementation by introducing a localized ambience source around the reward shrine area.

Unlike the dungeon ambience, which is designed to provide a consistent environmental bed across the entire level, the shrine ambience uses attenuation and 3D positioning to create a sense of place and proximity.

---

## Objectives

- Implement a localized ambience source.
- Demonstrate 3D spatial audio using Wwise.
- Create distance-based volume attenuation.
- Validate Wwise-to-Unity integration.
- Verify behavior using Wwise Profiler.

---

## Wwise Implementation

### Audio Hierarchy

```
Containers
└── Ambience
   ├── Dungeon
   │  └── Dungeon_Ambience
   └── Shrine
      └── Shrine_Ambience
```

### Events

```
Events
└── Ambience
   ├── Play_Dungeon_Ambience
   ├── Stop_Dungeon_Ambience
   ├── Play_Shrine_Ambience
   └── Stop_Shrine_Ambience
```

### Attenuation

A custom attenuation ShareSet named Shrine_Attenuation was created.

The attenuation curve reduces volume as distance increases, creating a localized listening area around the shrine.

---

## Unity Implementation

### ShrineAmbience GameObject

A dedicated GameObject was placed in the center of the shrine area.

Components:

- AkGameObj
- AkAmbient

Configuration:

Event:
Play_Shrine_Ambience

Trigger:
Start

---

## Testing

The system was validated through in-engine testing and Wwise Profiler analysis.

Expected behavior:

- Dungeon ambience remains active throughout the level.
- Shrine ambience becomes more audible as the player approaches the shrine.
- Shrine ambience fades naturally when moving away.
- Both ambience systems operate simultaneously.

---

## Results

The shrine ambience system successfully demonstrates:

- Wwise 3D audio implementation
- Distance-based attenuation
- Environmental audio layering
- Real-time Unity integration

The project now supports multiple environmental audio identities within a single level and provides a foundation for future ambience zones and adaptive audio systems.
