# Combat Arena Ambience System

## Overview

This milestone introduces a dedicated ambience system for the combat arena area.

The objective is to establish a unique environmental audio identity for combat spaces while maintaining coexistence with the global dungeon ambience and other localized ambience systems.

---

## Objectives

- Implement combat arena ambience playback.
- Demonstrate localized environmental audio using Wwise.
- Create distance-based attenuation behavior.
- Validate coexistence with existing ambience systems.
- Verify implementation using Wwise Profiler.

---

## Wwise Implementation

### Audio Hierarchy

```
Containers
└── Ambience
   ├── Dungeon
   │  └── Dungeon_Ambience
   ├── Shrine
   │  └── Shrine_Ambience
   └── Arena
      └── Arena_Ambience
```

### Events

```
Events
└── Ambience
   ├── Play_Dungeon_Ambience
   ├── Stop_Dungeon_Ambience
   ├── Play_Shrine_Ambience
   ├── Stop_Shrine_Ambience
   ├── Play_Arena_Ambience
   └── Stop_Arena_Ambience
```

### Attenuation

A custom Arena_Attenuation ShareSet was created and assigned to the arena ambience object.

The attenuation curve controls audible range and supports environmental localization.

---

## Unity Implementation

### ArenaAmbience GameObject

A dedicated GameObject was placed in the center of the combat arena.

Components:

- AkGameObj
- AkAmbient

Configuration:

Event:
Play_Arena_Ambience

Trigger:
Start

---

## Testing

The system was validated through gameplay testing and Wwise Profiler analysis.

Expected behavior:

- Dungeon ambience remains active throughout the level.
- Arena ambience becomes more prominent near the combat arena.
- Arena ambience fades naturally when moving away.
- Shrine ambience continues to function independently.
- Multiple ambience systems operate simultaneously.

---

## Results

The combat arena ambience system successfully demonstrates:

- Environmental audio layering
- 3D spatial audio implementation
- Distance-based attenuation
- Wwise-to-Unity integration
- Multi-zone ambience design

The project now contains three distinct environmental audio identities and is prepared for future ambience transitions and adaptive music implementation.
