# Post-Combat Adaptive Music Mix

## Objective

Implement a dedicated adaptive mix for the PostCombat gameplay state while preserving continuous music playback.

The objective is to separate gameplay state from audio implementation and demonstrate state-driven adaptive mixing within Wwise.

---

## Unity

No Unity implementation changes were required.

MusicManager continues to communicate gameplay states:

- Exploration
- Combat
- PostCombat

The adaptive mix is implemented entirely inside Wwise.

---

## Wwise

Implemented:

- PL_PostCombat Playlist Container
- Updated Music Switch Container
- Independent PostCombat routing

Current Playlist structure:

- PL_Exploration
- PL_Combat
- PL_PostCombat

Current Music States:

- None
- Exploration
- Combat
- PostCombat

PL_PostCombat currently references the existing Exploration Music Segment while maintaining independent playlist settings.

---

## Mixing

Implemented:

- Independent Playlist volume
- Approximately -9 dB PostCombat mix

This allows the same musical content to be presented differently depending on gameplay context.

No modifications were made to:

- Music Bus
- Music Segment
- Audio assets

Mixing remains localized to the PostCombat Playlist.

---

## Communication Flow

Gameplay

↓

MusicManager.SetPostCombat()

↓

AkSoundEngine.SetState()

↓

PostCombat State

↓

Music Switch Container

↓

PL_PostCombat

↓

MS_Exploration

---

## Validation

Verified using:

- Unity
- Wwise Authoring
- Wwise Profiler

Confirmed:

- Continuous playback
- Correct Music State changes
- Correct Playlist selection
- Independent PostCombat mix
- No additional Play_Music events

---

## Design Decisions

The adaptive mix is implemented entirely within Wwise.

Unity communicates gameplay state only.

This architecture allows future modifications—including different arrangements, orchestration, transitions and original compositions—to be implemented without modifying gameplay code.

---

## Future Improvements

Future milestones will extend the PostCombat Playlist with:

- Original music
- Transition segments
- Victory stingers
- Shrine-focused adaptive mixing
- Vertical remixing
- RTPC-driven intensity
