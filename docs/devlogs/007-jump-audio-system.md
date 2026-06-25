# Devlog 007 – Jump Audio System

## Objective

Implement a dedicated jump audio event for the player character to expand the gameplay audio system beyond footsteps and establish a complete movement audio package.

---

## Implementation

A new Jump sound object was created in Wwise under a dedicated Player hierarchy.

### Wwise Hierarchy

Audio

- Default Work Unit
  - Player
    - Jump

Events

- Default Work Unit
  - Player
    - Play_Jump

The Play_Jump event was added to the Main SoundBank and generated successfully.

---

## Unity Integration

Jump detection was implemented using a grounded state transition check.

A new state variable was added:

```csharp
private bool _wasGrounded;
```

The system detects when the player transitions from grounded to airborne:

```csharp
if (_wasGrounded && !Grounded)
{
    AkSoundEngine.PostEvent("Play_Jump", gameObject);
}

_wasGrounded = Grounded;
```

This approach ensures the event triggers only once when leaving the ground and avoids repeated playback while airborne.

---

## Testing

Testing was performed in Unity Play Mode.

Validation included:

- Jump audio playback
- Event triggering consistency
- Wwise Profiler verification
- SoundBank loading verification

Results:

- Jump audio plays correctly
- Event triggers once per jump
- No duplicate playback detected
- No Unity errors
- No Wwise errors

---

## Profiler Verification

Profiler validation confirmed:

- Event Triggered → Play_Jump
- Action Triggered → Play
- Playback start notification
- Playback completion notification

Screenshots:

- 018-event-jump.png
- 019-profiler-jump.png

---

## Outcome

The movement audio system now supports:

- Footsteps
- Jump Audio

The implementation establishes the foundation for the upcoming Landing Audio System.
