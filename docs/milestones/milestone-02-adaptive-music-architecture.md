# Milestone 2 – Adaptive Music Architecture

## Objective

Implement a horizontal adaptive music system using Wwise States to respond to major gameplay events.

The focus of this milestone is technical implementation rather than final musical content. Placeholder music will be used initially and replaced with original compositions during Milestone 3.

---

## Gameplay Flow

```text
Spawn
    │
    ▼
Exploration
    │
    ▼
Ancient Gate
    │
    ▼
Combat Arena
    │
    ▼
Boss Defeated
    │
    ▼
Reward Shrine
```

---

## Music Design

### Exploration

- Begins automatically when the level starts.
- Plays throughout the Spawn Area and Exploration Corridor.

### Combat

- Triggered when the player enters the Ancient Gate / Combat Arena.
- Begins with a short combat transition stinger.
- Transitions into a looping combat cue.

### Boss Defeat

- Combat music stops when the boss is defeated.
- No new music begins.
- The player enters a calm reward space supported solely by the shrine ambience.

This creates a clear emotional contrast between combat and the conclusion of the demo.

---

## Music State Architecture

### State Group

Music_State

### States

- Exploration
- Combat

---

## Unity Responsibilities

Unity communicates gameplay state only.

Examples:

- Level Start → Exploration
- Enter Combat Arena → Combat
- Boss Defeated → Stop Music

Unity never selects individual music assets directly.

---

## Wwise Responsibilities

Wwise is responsible for:

- Music playback
- Music state management
- Transition stingers
- Music routing
- Future transition timing
- Adaptive music behavior

---

## Planned Wwise Hierarchy

### Property Containers

- Music

### Virtual Folders

- Exploration
- Combat
- Stingers

### Events

- Play_Music
- Stop_Music

### State Group

Music_State

States

- Exploration
- Combat

---

## Milestone Goals

- Design adaptive music architecture
- Implement Wwise Music States
- Implement exploration music
- Implement combat music
- Implement combat transition stinger
- Connect Unity gameplay events to Wwise States
- Stop combat music when the boss is defeated
- Allow shrine ambience to become the sole environmental audio at the end of the demo
- Validate the complete adaptive music workflow using the Wwise Profiler

---

## Future Expansion (Milestone 3)

Once the adaptive music system is complete:

- Replace placeholder music with original compositions.
- Replace placeholder sound effects where appropriate.
- Implement RTPC-driven combat intensity.
- Explore layered music using vertical remixing techniques.
- Refine transition timing and musical phrasing.
- Implement environmental DSP processing (EQ, reverb, and spatial effects).
- Balance and mix the project using dedicated audio buses.
- Fine-tune overall loudness and dynamic range.
- Capture polished gameplay footage for the portfolio.
- Produce a technical implementation breakdown demonstrating the Unity ↔ Wwise workflow.

---

## Expected Learning Outcomes

By completing this milestone, the project will demonstrate:

- Wwise State-based adaptive music
- Horizontal music transitions
- Transition stinger implementation
- Unity-driven music state management
- Scalable adaptive music architecture
- Professional middleware workflow suitable for game audio production
