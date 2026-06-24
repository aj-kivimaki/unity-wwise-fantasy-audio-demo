# Unity Wwise Fantasy Audio Demo

An interactive game audio portfolio project exploring adaptive music, sound design, and technical audio implementation using Unity and Wwise.

## Project Goals

This project focuses on showcasing:

- Interactive music systems
- Adaptive music transitions
- Sound design for gameplay and environments
- Audio implementation in Unity
- Wwise integration and middleware workflows
- Technical audio design concepts such as States, RTPCs, Switches, Attenuation, and Reverb Zones

## Demo Structure

The playable experience consists of a short fantasy dungeon adventure through:

- Spawn Area
- Exploration Corridor
- Ancient Gate / Transition Area
- Combat Arena
- Reward Shrine

The prototype is intentionally designed as an audio-focused experience, providing opportunities for adaptive music, ambience, gameplay audio, environmental sound design, and Wwise implementation while maintaining a manageable development scope.

## Technologies

- Unity 6
- Wwise
- C#
- Git

## Portfolio Deliverables

This project serves as the foundation for the following portfolio pieces:

- Composer Reel
- Interactive Music Reel
- Technical Audio Breakdown
- Cinematic Scoring Reel
- Sound Design Reel

## Current Progress

### Project Foundation

- Unity project created
- Git workflow established
- Project documentation and development logs created
- Third-person gameplay prototype established

### Environment Development

- Fantasy dungeon environment blockout completed
- Gameplay flow and level structure completed
- Environment dressing completed

### Wwise Integration

- Wwise project created
- Wwise integrated into Unity
- SoundBank generation pipeline verified
- Unity ↔ Wwise communication verified
- Wwise Profiler workflow established

### Gameplay Audio Systems

- First Wwise event implemented and tested
- Randomized footstep system implemented
- Animation-driven footstep triggering implemented
- Jump audio system implemented
- Landing audio system implemented
- Grounded-to-airborne movement state detection implemented
- Airborne-to-grounded movement state detection implemented
- Complete movement audio package implemented
- Placeholder audio workflow established

### Environmental Audio Systems

- Global dungeon ambience system implemented
- Localized shrine ambience system implemented
- Localized combat arena ambience system implemented
- Custom Wwise attenuation ShareSets implemented
- Multiple simultaneous ambience layers validated
- Environmental audio layering workflow established

## Current Audio Features

### Movement Audio

- Animation-driven footsteps
- Randomized footstep playback
- Jump audio playback
- Landing audio playback
- Grounded-state movement detection
- Complete player movement audio package

### Environmental Audio

- Global environmental ambience
- Localized environmental ambience
- 3D positional audio
- Distance-based attenuation
- Multiple concurrent ambience systems

### Wwise Implementation

- Event-driven audio playback
- Random Containers
- Attenuation ShareSets
- SoundBank management
- Wwise Profiler validation workflow

## Next Milestone

- Implement adaptive exploration and combat music
- Introduce Wwise States
- Create music state transitions
- Establish Unity-to-Wwise music control workflow
- Build first adaptive music system

## Repository Structure

```text
Assets/
├── Scenes/
├── Scripts/
├── StreamingAssets/

FantasyAudioDemo_Wwise/
├── Events/
├── Containers/
├── Attenuations/
├── Originals/

docs/
devlogs/
portfolio-assets/
```

## Status

The project has completed its core gameplay audio and environmental audio foundation. Current development is focused on adaptive music implementation, Wwise States, and interactive music workflows that will drive the next phase of the portfolio project.
