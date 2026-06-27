# Devlog 017 — SoundBank Review & Organization

## Overview

Reviewed the project's SoundBank architecture to ensure it matches the current project scope while remaining scalable for future development.

Rather than introducing additional runtime SoundBanks unnecessarily, this task focused on validating the existing implementation, reviewing packaging, improving project organization and documenting the design decisions behind the chosen architecture.

---

## Objectives

- Review SoundBank packaging
- Review included Events
- Review media inclusion
- Review runtime loading strategy
- Improve Event organization
- Validate Unity integration

---

## SoundBank Review

Current runtime SoundBanks:

- Init
- Main

The project currently consists of a single playable scene containing one continuous gameplay experience.

Since all audio assets are required during gameplay, loading a single runtime SoundBank provides the simplest and most appropriate solution.

---

## Event Organization

Reorganized the Event hierarchy into logical categories.

Current structure:

Events

- Ambience
- Music
- Player
  - Footsteps
  - Jump
  - Landing

This improves readability while making future expansion significantly easier.

---

## SoundBank Audit

Verified:

- Event inclusion
- Structure inclusion
- Media inclusion
- Generated SoundBank size
- Memory footprint
- Unity loading

No missing media or unnecessary runtime assets were identified.

---

## Runtime Validation

Verified:

- Init SoundBank loads correctly
- Main SoundBank loads correctly
- Gameplay audio functions normally
- Music playback unaffected
- Ambience playback unaffected
- Player SFX unaffected

---

## Design Decision

Although multiple runtime SoundBanks are common in larger productions, the current project does not benefit from additional SoundBank separation.

The chosen architecture minimizes complexity while remaining appropriate for:

- Single scene
- Single gameplay level
- Immediate loading
- Small memory footprint
- Fast iteration

The SoundBank strategy will naturally scale if future development introduces multiple scenes or streamed content.

---

## Outcome

The project now has:

- Reviewed SoundBank architecture
- Organized Event hierarchy
- Documented loading strategy
- Validated packaging
- Production-ready SoundBank rationale
