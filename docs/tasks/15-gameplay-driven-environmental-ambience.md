# Gameplay-Driven Environmental Ambience

## Objective

Implement gameplay-controlled environmental ambience using Unity triggers and Wwise Events.

The objective is to separate gameplay logic from ambience playback while maintaining a centralized audio architecture.

---

## Unity

### AmbienceManager

Implemented a centralized AmbienceManager singleton.

Responsibilities:

- Start Arena ambience
- Stop Arena ambience
- Start Shrine ambience
- Stop Shrine ambience
- Prevent duplicate playback

Gameplay scripts no longer communicate directly with Wwise.

---

## Gameplay Triggers

CombatMusicTrigger

- Starts Arena ambience

CombatEndTrigger

- Stops Arena ambience

ShrineAmbienceTrigger

- Starts Shrine ambience

Each trigger has a single responsibility while AmbienceManager manages all ambience playback.

---

## Wwise

ArenaAmbience

- Automatic playback disabled
- Controlled through Play and Stop Events

ShrineAmbience

- Automatic playback disabled
- Controlled through Play and Stop Events

Dungeon ambience remains the persistent environmental ambience layer and continues to start automatically when the scene loads.

---

## Communication Flow

Gameplay

↓

Trigger

↓

AmbienceManager

↓

AkSoundEngine.PostEvent()

↓

Wwise Event

↓

AkAmbient

---

## Validation

Verified using:

- Unity gameplay
- Wwise Authoring
- Wwise Profiler

Confirmed:

- Correct gameplay-driven ambience flow
- Correct event order
- No duplicate playback
- Existing attenuation preserved
- Music system unaffected

---

## Design Decisions

Environmental ambience now follows the same architectural principles as the interactive music system.

Managers communicate with Wwise.

Gameplay communicates with Managers.

This separation improves maintainability while allowing future ambience systems to be integrated without modifying gameplay logic.

---

## Future Improvements

Milestone 3 will expand the ambience system with:

- Original environmental ambience
- Additional environmental emitters
- Ambient one-shots
- Environmental sound variation
- Final ambience balancing
