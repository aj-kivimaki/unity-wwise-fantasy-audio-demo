# Unity Wwise Fantasy Audio Demo

An interactive game audio portfolio project exploring adaptive music, sound design, and technical audio implementation using Unity and Wwise.

## Project Goals

This project focuses on showcasing:

- Interactive music systems
- Adaptive music transitions
- Sound design for gameplay and environments
- Audio implementation in Unity
- Wwise integration and middleware workflows
- Technical audio design concepts including States, RTPCs, Attenuation, Reverb, Audio Busses, and dynamic mixing

---

## Demo Structure

The playable experience consists of a short fantasy dungeon adventure through:

- Spawn Area
- Exploration Corridor
- Ancient Gate / Transition Area
- Combat Arena
- Reward Shrine

The prototype is intentionally designed as an audio-focused experience, providing opportunities to demonstrate adaptive music, gameplay audio, environmental sound design, and professional Wwise implementation while maintaining a manageable development scope.

---

## Technologies

- Unity 6
- Wwise 2025
- C#
- Git

---

## Portfolio Deliverables

This project serves as the foundation for:

- Composer Reel
- Interactive Music Reel
- Technical Audio Breakdown
- Cinematic Scoring Reel
- Sound Design Reel

---

# Current Progress

## Project Foundation

- Unity project created
- Git workflow established
- Documentation and development log workflow established
- Third-person gameplay prototype implemented

## Environment Development

- Fantasy dungeon environment completed
- Gameplay flow and level structure implemented
- Environment dressing completed

## Wwise Integration

- Wwise project created
- Wwise integrated into Unity
- SoundBank generation pipeline established
- Unity ↔ Wwise communication verified
- Wwise Profiler workflow established

## Gameplay Audio Systems

- Animation-driven footstep system
- Randomized footstep playback
- Jump audio system
- Landing audio system
- Complete player movement audio package
- Gameplay-driven movement state detection

## Environmental Audio Systems

- Global dungeon ambience
- Localized shrine ambience
- Localized combat arena ambience
- Custom attenuation ShareSets
- Multiple simultaneous ambience layers
- Environmental audio layering workflow

## Audio Architecture

- Dedicated Music, Ambience, SFX, UI, and Voice audio buses
- Property Container-based content hierarchy
- Centralized audio routing through inheritance
- Dedicated Music State architecture
- Adaptive music event framework
- Scalable audio mixing architecture
- Foundation prepared for adaptive music and environmental DSP

---

# Current Audio Features

## Movement Audio

- Animation-driven footsteps
- Randomized footstep playback
- Jump audio
- Landing audio
- Gameplay-driven movement state detection

## Environmental Audio

- Global ambience
- Localized ambience
- 3D positional audio
- Distance-based attenuation
- Multiple simultaneous ambience layers

## Wwise Features

- Events
- States
- Property Containers
- Random Containers
- Audio Busses
- Attenuation ShareSets
- SoundBank management
- Wwise Profiler workflow

---

# Development Roadmap

## ✅ Milestone 1 – Core Audio Foundation

Completed

- Unity ↔ Wwise integration
- Gameplay audio systems
- Environmental ambience systems
- Audio routing architecture
- Technical documentation and validation

---

## 🚧 Milestone 2 – Adaptive Music

In Progress

- Adaptive music architecture ✅
- Exploration music
- Combat music
- Combat transition stinger
- Unity gameplay → Wwise State communication
- Horizontal adaptive music implementation
- Profiler validation

---

## 🎯 Milestone 3 – Portfolio Polish & Advanced Audio

Planned

- Replace placeholder music with original compositions
- Replace placeholder sound effects where appropriate
- RTPC-driven combat intensity
- Vertical remixing and layered music
- Environmental DSP (EQ, reverb, spatial processing)
- Bus-level mixing and balancing
- Loudness and dynamic range refinement
- Final gameplay capture
- Technical implementation breakdown
- Portfolio reel production

---

## Repository Structure

```text
Assets/
├── Scenes/
├── Scripts/
├── StreamingAssets/

FantasyAudioDemo_Wwise/
├── Events/
├── Containers/
├── Audio Busses/
├── Attenuations/
├── States/
├── Originals/

docs/
├── milestones/
├── devlogs/

portfolio-assets/
```

---

# Status

**Milestone 1 – Core Audio Foundation** is complete.

**Milestone 2 – Adaptive Music** is now underway. The architectural foundation—including music routing, States, events, and audio bus organization—has been completed, allowing development to focus on implementing exploration and combat music, gameplay-driven transitions, and adaptive music behavior.

The final milestone will replace placeholder assets with original compositions and sound design while introducing more advanced game audio techniques such as RTPC-driven music intensity, vertical remixing, environmental DSP, and final mix refinement.
