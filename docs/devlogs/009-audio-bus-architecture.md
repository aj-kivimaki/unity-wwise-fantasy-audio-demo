# Devlog 009 – Audio Bus Architecture

## Objective

Prepare the project for adaptive music, environmental effects, and future mixing workflows by introducing a dedicated audio bus structure.

---

## Implementation

A dedicated mixing hierarchy was created under the Master Audio Bus.

### Audio Bus Structure

- Music
- Ambience
- SFX
- UI
- Voice

The content hierarchy was also reorganized using Property Containers to separate audio organization from mix routing.

### Content Structure

Property Containers

- Ambience
- Player_SFX
- Music

Virtual Folders

- Arena
- Dungeon
- Shrine
- Footsteps
- Jump
- Landing

---

## Routing

The top-level Property Containers were assigned to their respective output buses.

- Ambience → Ambience Bus
- Player_SFX → SFX Bus
- Music → Music Bus

Individual sounds inherit their routing from their parent Property Container.

---

## Spatial Audio

Localized ambience objects retain their own attenuation ShareSets.

- Shrine → Shrine Attenuation
- Arena → Arena Attenuation

The global dungeon ambience remains non-spatial and therefore does not use an attenuation ShareSet.

---

## Outcome

The project now has a scalable audio routing architecture suitable for:

- Adaptive music
- Bus-level volume control
- Environmental DSP
- Reverb sends
- Future mixing workflows

This establishes the project's long-term mixing foundation before implementing adaptive music systems.
