# Asset Organization & SoundBank Strategy

## Overview

The project follows a structured asset organization strategy designed to keep the Wwise project maintainable as additional audio content is introduced.

Rather than focusing solely on playback, the project emphasizes clear hierarchy, logical grouping, consistent naming, and scalable asset management.

The current implementation is intentionally lightweight while providing a foundation suitable for larger productions.

---

# Design Goals

The organization strategy was designed to:

- Keep the project easy to navigate.
- Separate gameplay systems into logical categories.
- Minimize duplicated configuration.
- Support future expansion.
- Simplify Unity integration.
- Maintain consistent naming throughout the project.

---

# Content Organization

Audio content is grouped by gameplay responsibility rather than by individual asset type.

Current categories include:

```text
Audio

├── Music
├── Ambience
└── Player_SFX
```

Each category contains the objects required for its own gameplay system.

This approach makes related assets easy to locate and maintain.

---

# Naming Conventions

A consistent naming convention is used throughout the project.

Examples include:

| Prefix | Purpose            |
| ------ | ------------------ |
| PL\_   | Playlist Container |
| MS\_   | Music Segment      |
| Play\_ | Playback Event     |
| Stop\_ | Stop Event         |
| RC\_   | Random Container   |
| AUX\_  | Auxiliary Bus      |

Using descriptive prefixes allows object types to be identified immediately when navigating large Wwise projects.

---

# ShareSets

The project makes use of ShareSets to centralize reusable settings.

Current examples include:

## Attenuation

- Arena_Attenuation
- Shrine_Attenuation

These ShareSets define spatial behaviour for localized ambience.

---

## RoomVerb

RoomVerb is implemented as a reusable ShareSet within the environmental reverb workflow.

Centralizing DSP configuration allows changes to propagate automatically to all connected objects.

---

# Random Containers

Random Containers are used where repeated playback would otherwise become predictable.

Current implementation:

- Footsteps

Random Containers provide:

- Sample variation
- Reduced repetition
- Simplified Unity implementation
- Easy expansion

Gameplay code remains unchanged regardless of the number of variations.

---

# Interactive Music Assets

Interactive Music assets are organized into clearly defined layers.

```text
Music

├── Music Switch Container
├── PL_Exploration
├── PL_Combat
├── PL_PostCombat
├── MS_Exploration
├── MS_Combat
└── MS_PostCombat
```

Separating playlists from segments improves readability and supports future adaptive music expansion.

---

# Event Organization

Events are grouped according to gameplay systems.

Current categories include:

- Music
- Ambience
- Player

Events represent gameplay actions rather than individual audio files.

Examples include:

- Play_Music
- Play_Jump
- Play_Landing
- Play_Arena_Ambience

This keeps Unity independent from asset implementation details.

---

# SoundBank Strategy

The project currently uses a single Main SoundBank.

Reasons:

- Small project scope
- All assets required during gameplay
- Simplified deployment
- Straightforward Unity integration

For the current portfolio project, introducing multiple SoundBanks would increase complexity without providing meaningful benefits.

---

# SoundBank Generation

The Main SoundBank contains all assets required for gameplay.

Generation occurs after significant Wwise changes to ensure Unity always references the latest project data.

Profiler validation is performed following major updates to verify correct event playback and bank loading.

---

# Scalability

The organization strategy supports future expansion without restructuring.

Potential additions include:

- Environment-specific SoundBanks
- Dialogue SoundBanks
- Streaming music banks
- DLC content
- Localized voice assets
- Additional gameplay systems

The existing hierarchy is designed so these additions can be introduced incrementally.

---

# Design Philosophy

The project intentionally favors clarity over complexity.

Objects are grouped according to gameplay responsibility, reusable settings are centralized through ShareSets, and consistent naming conventions improve readability.

This approach reduces maintenance overhead while making the project easier for other developers and audio designers to understand.

---

# Summary

The project's asset organization and SoundBank strategy establish a clean and scalable foundation for middleware development.

By combining consistent naming, logical hierarchy, reusable ShareSets, and an intentionally simple SoundBank strategy, the project remains easy to navigate while supporting future growth without architectural changes.
