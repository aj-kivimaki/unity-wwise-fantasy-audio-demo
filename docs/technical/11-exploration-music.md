# 11. Exploration Music System

## Goal

Create the first adaptive music implementation using Wwise Interactive Music.

---

# Features

## Wwise

- Music State Group
- Music Switch Container
- Playlist Containers
- Music Segments
- Infinite exploration loop
- Play_Music event
- Stop_Music event

---

## Unity

Dedicated MusicManager singleton.

Responsibilities:

- Start exploration music
- Set Exploration state
- Set Combat state
- Stop music

Music playback is now completely separated from player movement logic.

---

# Architecture

Audio

```
├── MusicManager

│ ├── StartExplorationMusic()

│ ├── SetExploration()

│ ├── SetCombat()

│ └── StopMusic()
```

↓

Wwise

Music Switch Container

↓

Playlist Container

↓

Music Segment

---

# Result

Exploration music now:

- starts automatically
- loops indefinitely
- is controlled by Wwise States
- is ready for seamless combat transitions
