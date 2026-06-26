# Jump Audio System

## Overview

The Jump Audio System provides audio feedback whenever the player leaves the ground.

The implementation uses a grounded-state transition check rather than direct input detection, ensuring that audio playback reflects actual gameplay movement.

---

## System Architecture

### Wwise

Audio

- Default Work Unit
  - Player
    - Jump

Events

- Default Work Unit
  - Player
    - Play_Jump

SoundBank

- Main

---

## Unity Implementation

The system monitors grounded state changes.

### State Tracking

```csharp
private bool _wasGrounded;
```

### Jump Detection

```csharp
if (_wasGrounded && !Grounded)
{
    AkSoundEngine.PostEvent("Play_Jump", gameObject);
}

_wasGrounded = Grounded;
```

---

## Advantages

Compared to triggering audio directly from player input:

- Reflects actual movement state
- Prevents false triggers
- Supports future gameplay mechanics
- Creates a reusable pattern for landing detection

---

## Validation

The following conditions were verified:

- Audio plays during jump
- Playback occurs once per jump
- Event appears in Wwise Profiler
- No runtime errors
- SoundBank generation succeeds

---

## Future Improvements

Potential future enhancements include:

- Separate jump variations
- Randomized jump playback
- Surface-dependent jump sounds
- Differentiation between jump and falling transitions

These improvements are outside the scope of the current portfolio milestone.
