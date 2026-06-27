# Unity Wwise Fantasy Audio Demo

An interactive game audio portfolio project exploring adaptive music, sound design, and technical audio implementation using Unity and Wwise.

## Project Goals

This project focuses on showcasing:

- Interactive music systems
- Adaptive music transitions
- Gameplay-driven environmental audio
- Sound design for gameplay and environments
- Audio implementation in Unity
- Wwise integration and middleware workflows
- Technical audio design concepts including States, RTPCs, Attenuation, Reverb, Audio Busses, adaptive mixing, and dynamic music systems

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
- Gameplay-driven environmental ambience

## Environmental Audio Systems

- Global dungeon ambience
- Gameplay-driven arena ambience
- Gameplay-driven shrine ambience
- Custom attenuation ShareSets
- Multiple simultaneous ambience layers
- Centralized AmbienceManager
- Environmental audio layering workflow

## Adaptive Music Systems

- Exploration Music State
- Combat Music State
- PostCombat Music State
- Music Switch Container
- Independent Playlist Containers
- Gameplay-driven music state transitions
- Continuous music playback
- State-driven adaptive music mixing
- Centralized MusicManager

## Audio Architecture

- Dedicated Music, Ambience, SFX, UI and Voice audio buses
- Property Container-based content hierarchy
- Centralized MusicManager
- Centralized AmbienceManager
- Gameplay-driven audio architecture
- Music State-driven implementation
- Independent Playlist-based adaptive mixing
- Gameplay-driven ambience management
- Scalable audio framework prepared for advanced implementation

---

# Current Audio Features

## Movement Audio

- Animation-driven footsteps
- Randomized footstep playback
- Jump audio
- Landing audio
- Gameplay-driven movement state detection

## Environmental Audio

- Dungeon ambience
- Arena ambience
- Shrine ambience
- Gameplay-driven ambience playback
- 3D positional audio
- Distance-based attenuation
- Multiple simultaneous ambience layers

## Interactive Music

- Exploration music
- Combat music
- PostCombat music state
- Continuous playback
- Music States
- Music Switch Container
- Independent Playlist Containers
- Gameplay-driven transitions
- State-driven adaptive music mixing
- Centralized MusicManager

## Wwise Features

- Events
- States
- Music Switch Containers
- Music Playlist Containers
- Music Segments
- Interactive Music
- Adaptive Playlist Mixing
- Gameplay-driven ambience
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
- AmbienceManager singleton ✅
- Music Switch Container ✅
- Independent Playlist Containers ✅
- Music States ✅
- State-driven adaptive mixing ✅
- Gameplay-driven ambience system ✅

### Gameplay Integration

- Exploration music ✅
- Combat music ✅
- PostCombat state ✅
- Gameplay-driven music transitions ✅
- Gameplay-driven environmental ambience ✅
- Unity gameplay → Wwise communication ✅
- Wwise Profiler validation ✅

### Remaining

- Environmental DSP foundation
- SoundBank organization
- Audio bus architecture & mixing foundation
- Voice management & playback optimization
- Interactive music transition foundation

---

## 🎯 Milestone 3 – Portfolio Polish & Advanced Audio

Planned

- Replace placeholder music with original compositions
- Replace placeholder sound effects
- Original environmental ambience
- Environmental sound variation
- Vertical remixing
- RTPC-driven combat intensity
- Transition stingers
- Advanced transition logic
- Environmental DSP refinement
- Final mixing and loudness refinement
- Final gameplay capture
- Portfolio production

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

**Milestone 2 – Adaptive Music & Technical Implementation** is progressing according to plan.

The project now demonstrates gameplay-driven interactive music and gameplay-driven environmental ambience using centralized manager classes, Wwise Events and Music States. The technical foundation is complete enough to begin implementing more advanced middleware features while preserving a clean and scalable architecture.
