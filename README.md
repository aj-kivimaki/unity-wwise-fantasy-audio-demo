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
- Throne
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
- Gameplay-driven adaptive music transitions

## Environmental Audio Systems

- Global dungeon ambience
- Localized shrine ambience
- Localized combat arena ambience
- Custom attenuation ShareSets
- Multiple simultaneous ambience layers
- Environmental audio layering workflow

## Adaptive Music Systems

- Exploration Music State
- Combat Music State
- PostCombat Music State
- Music Switch Container
- Music Playlist Containers
- Gameplay-driven state transitions
- Continuous music playback
- Centralized MusicManager
- Trigger-based music state changes

## Audio Architecture

- Dedicated Music, Ambience, SFX, UI, and Voice audio buses
- Property Container-based content hierarchy
- Centralized audio routing through inheritance
- Gameplay-driven music architecture
- Music State-driven implementation
- Scalable adaptive music framework
- Foundation prepared for advanced interactive music techniques

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

## Interactive Music

- Exploration music
- Combat music
- PostCombat state
- Music States
- Music Switch Container
- Music Playlist Containers
- Continuous music playback
- Gameplay-driven transitions
- Centralized MusicManager

## Wwise Features

- Events
- States
- Music Switch Containers
- Music Playlist Containers
- Music Segments
- Interactive Music
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

## 🚧 Milestone 2 – Adaptive Music & Technical Implementation

In Progress

### Architecture

- Adaptive music architecture ✅
- MusicManager singleton ✅
- Music Switch Container ✅
- Music Playlist Containers ✅
- Music States ✅

### Gameplay Integration

- Exploration music ✅
- Combat music ✅
- PostCombat state ✅
- Gameplay-driven music state transitions ✅
- Unity gameplay → Wwise State communication ✅
- Trigger-based music transitions ✅
- Wwise Profiler validation ✅

### Remaining

- Post-combat adaptive mix
- Transition timing polish
- Transition stingers
- Musical transition segments

---

## 🎯 Milestone 3 – Portfolio Polish & Advanced Audio

Planned

- Replace placeholder music with original compositions
- Replace placeholder sound effects where appropriate
- Vertical remixing
- RTPC-driven combat intensity
- Advanced transition logic
- Environmental DSP
- Bus-level mixing
- Loudness refinement
- Final gameplay capture
- Technical breakdown
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
├── technical/

portfolio-assets/
```

---

# Status

**Milestone 1 – Core Audio Foundation** is complete.

**Milestone 2 – Adaptive Music & Technical Implementation** is progressing well.

The project now implements a complete gameplay-driven adaptive music state machine:

Exploration → Combat → PostCombat

Music playback remains continuous while gameplay communicates state changes through the MusicManager and Wwise Music States.

Future tasks will build upon this architecture by implementing post-combat adaptive mixing, transition polish, stingers, and advanced interactive music techniques before replacing placeholder assets with original content during Milestone 3.
