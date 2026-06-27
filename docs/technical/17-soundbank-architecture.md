# SoundBank Architecture

## Objective

Review the current SoundBank implementation and validate that the project's runtime loading strategy matches its scope.

The goal is to establish an appropriate architecture rather than maximizing the number of runtime SoundBanks.

---

## Runtime SoundBanks

Current implementation:

- Init
- Main

Init contains initialization data required by Wwise.

Main contains all runtime audio used by the playable level.

---

## Loading Strategy

The project uses a single runtime SoundBank because:

- One playable scene
- One gameplay level
- All audio required immediately
- No streamed media
- No level transitions
- Low overall memory footprint

This minimizes loading complexity while remaining fully appropriate for the project's current requirements.

---

## Event Organization

Events are grouped by gameplay responsibility.

Events

- Ambience
- Music
- Player
  - Footsteps
  - Jump
  - Landing

This organization improves maintainability without affecting runtime behaviour.

---

## Packaging Review

Validated:

- Included Events
- Included Structures
- Media packaging
- Generated SoundBank
- Memory usage
- Unity runtime loading

No unnecessary assets or packaging issues were identified.

---

## Scalability

Future projects may benefit from additional runtime SoundBanks such as:

- Music
- PlayerSFX
- Ambience
- UI
- Dialogue

These would support:

- Scene loading
- Streaming
- DLC
- Reduced memory usage
- Modular content loading

The current project intentionally avoids this additional complexity because it provides no measurable runtime benefit.

---

## Result

The SoundBank architecture reflects the current project scope while providing a clear path for future expansion.

The implementation demonstrates conscious engineering decisions rather than unnecessary architectural complexity.
