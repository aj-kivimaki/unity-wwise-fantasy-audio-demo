# Unity Wwise Fantasy Audio Demo

An interactive game audio portfolio project exploring adaptive music, sound design, and technical audio implementation using Unity and Wwise.

## Project Goals

This project focuses on showcasing:

* Interactive music systems
* Adaptive music transitions
* Sound design for gameplay and environments
* Audio implementation in Unity
* Wwise integration and middleware workflows
* Technical audio design concepts such as States, RTPCs, Switches, Attenuation, Reverb, and audio mixing

## Demo Structure

The playable experience consists of a short fantasy dungeon adventure through:

* Spawn Area
* Exploration Corridor
* Ancient Gate / Transition Area
* Combat Arena
* Reward Shrine

The prototype is intentionally designed as an audio-focused experience, providing opportunities for adaptive music, gameplay audio, environmental sound design, and technical middleware implementation while maintaining a manageable development scope.

## Technologies

* Unity 6
* Wwise
* C#
* Git

## Portfolio Deliverables

This project serves as the foundation for the following portfolio pieces:

* Composer Reel
* Interactive Music Reel
* Technical Audio Breakdown
* Cinematic Scoring Reel
* Sound Design Reel

## Current Progress

### Project Foundation

* Unity project created
* Git workflow established
* Documentation and development log workflow established
* Third-person gameplay prototype implemented

### Environment Development

* Fantasy dungeon environment completed
* Gameplay flow and level structure implemented
* Environment dressing completed

### Wwise Integration

* Wwise project created
* Wwise integrated into Unity
* SoundBank generation pipeline established
* Unity ↔ Wwise communication verified
* Wwise Profiler workflow established

### Gameplay Audio Systems

* Animation-driven footstep system
* Randomized footstep playback
* Jump audio system
* Landing audio system
* Complete player movement audio package
* Gameplay state detection for movement events

### Environmental Audio Systems

* Global dungeon ambience
* Localized shrine ambience
* Localized combat arena ambience
* Custom attenuation ShareSets
* Multiple simultaneous ambience layers
* Environmental audio layering workflow

### Audio Architecture

* Dedicated Music, Ambience, SFX, UI, and Voice audio buses
* Property Container-based content hierarchy
* Centralized bus routing through inheritance
* Scalable audio mixing architecture
* Foundation prepared for adaptive music and environmental DSP

## Current Audio Features

### Movement Audio

* Animation-driven footsteps
* Randomized footstep playback
* Jump audio
* Landing audio
* Gameplay-driven movement state detection

### Environmental Audio

* Global ambience
* Localized ambience
* 3D positional audio
* Distance-based attenuation
* Simultaneous ambience playback

### Wwise Features

* Events
* Random Containers
* Property Containers
* Audio Busses
* Attenuation ShareSets
* SoundBank management
* Wwise Profiler workflow

## Next Milestone

### Milestone 2 – Adaptive Music

* Implement adaptive exploration and combat music
* Design music state architecture
* Introduce Wwise States
* Create seamless music transitions
* Connect Unity gameplay events to music states
* Validate adaptive music workflow using the Wwise Profiler

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
├── Originals/
├── States/

docs/
├── milestones/
├── devlogs/

portfolio-assets/
```

## Status

**Milestone 1 – Core Audio Foundation** is complete.

The project now includes a complete gameplay audio foundation, environmental ambience systems, and a scalable Wwise mixing architecture. Development is now focused on implementing adaptive music systems and interactive music workflows for Milestone 2.
