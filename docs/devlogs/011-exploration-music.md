# Devlog 011 – Exploration Music System

## Overview

Implemented the first adaptive music system using Wwise Interactive Music and integrated it with Unity.

The system now starts looping exploration music automatically when gameplay begins, using a dedicated Music Manager and Wwise Music Switch Container architecture.

---

## Implemented

### Wwise

- Music State Group
  - None
  - Exploration
  - Combat

- Music Switch Container
- Exploration Playlist Container
- Exploration Music Segment
- Play_Music event
- Stop_Music event

Configured playlist sequencing correctly and enabled infinite looping for exploration music.

---

### Unity

Created a dedicated MusicManager component.

Responsibilities:

- Starts gameplay music
- Sets initial Exploration state
- Posts Play_Music event
- Exposes music state API
- Singleton architecture for global access

Removed all music logic from ThirdPersonController.

---

## Architecture

Unity

↓

MusicManager

↓

Wwise Events & States

↓

Music Switch Container

↓

Playlist Container

↓

Music Segment

↓

Audio

---

## Lessons Learned

One important discovery was that Music Playlist Containers are not populated automatically by hierarchy.

Music Segments must also be added into the Playlist sequence editor.

Without this step:

- Music Segment plays
- Event posts successfully
- Switch Container appears valid

…but no music is produced.

---

## Next

Implement combat music transition using Wwise States.
