# Devlog 005 – Shrine Ambience System

## Goal

Create a localized ambience source around the reward shrine area to demonstrate 3D environmental audio implementation using Wwise and Unity.

---

## Implementation

A new ambient sound source was created in Wwise and configured as a looping 3D sound object.

### Wwise Structure

```
Containers
└── Ambience
   ├── Dungeon
   │  └── Dungeon_Ambience
   └── Shrine
      └── Shrine_Ambience

Events
└── Ambience
   ├── Play_Dungeon_Ambience
   ├── Stop_Dungeon_Ambience
   ├── Play_Shrine_Ambience
   └── Stop_Shrine_Ambience
```

---

## Attenuation

A custom attenuation ShareSet was created for the shrine ambience.

```
ShareSets
└── Attenuations
└── Shrine_Attenuation
```

The attenuation curve limits the audible range of the shrine ambience and increases perceived loudness as the player approaches the shrine.

---

## Unity Integration

A dedicated ShrineAmbience GameObject was added to the shrine area.

Components:

- Transform
- AkGameObj
- AkAmbient

Configuration:

- Event: Play_Shrine_Ambience
- Trigger: Start

---

## Validation

Testing confirmed:

- Shrine ambience plays successfully.
- Attenuation responds to distance.
- Ambient audio becomes more prominent when approaching the shrine.
- Dungeon ambience continues playing simultaneously.
- SoundBanks generate correctly.
- Wwise Profiler reports expected event activity.

---

## Lessons Learned

This task introduced localized environmental audio and attenuation-based spatialization.

The project now contains both:

- Global ambience (Dungeon)
- Localized ambience (Shrine)

This creates a more believable environment and establishes a foundation for future area-based audio systems.
