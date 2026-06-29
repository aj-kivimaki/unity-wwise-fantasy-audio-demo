# Audio Bus Architecture & Mixing Foundation

## Objective

Establish a scalable audio routing architecture that separates gameplay audio into logical mix categories while maintaining a simple and maintainable bus hierarchy.

The implementation focuses on routing and organization rather than artistic mixing.

---

## Final Bus Hierarchy

```text
Main Audio Bus
├── Music
├── Ambience
├── SFX
│   └── Player
├── UI
├── Voice
└── AUX_Corridor
```

---

## Routing

Current routing:

| Category   | Destination Bus |
| ---------- | --------------- |
| Music      | Music           |
| Ambience   | Ambience        |
| Player SFX | Player          |
| UI         | UI              |
| Voice      | Voice           |

Player audio inherits the following routing:

Player_SFX

↓

Player

↓

SFX

↓

Main Audio Bus

This provides a dedicated control point for all player-generated sound effects while keeping the overall hierarchy compact.

---

## Design Decisions

### Dedicated Player Bus

A Player bus was introduced because all current gameplay sound effects originate from the player.

Future player-related sounds such as attacks, rolls or interactions can inherit this routing without additional restructuring.

---

### Music

A single Music bus is maintained.

Interactive Music Hierarchy objects are responsible for gameplay behaviour, while the Music bus represents the final mix category.

---

### Ambience

A single Ambience bus is maintained.

Individual environments remain gameplay objects rather than separate mix categories.

---

### UI and Voice

Although currently unused, dedicated UI and Voice buses remain part of the hierarchy.

These represent standard production mix categories and allow future expansion without requiring structural changes.

---

## Mixing Foundation

All bus levels currently remain at **0 dB**.

This intentionally separates:

- Asset balancing
- Category balancing
- Final mastering

Individual assets may be adjusted where necessary during implementation, while category-level balancing will occur once the complete audio experience has been implemented.

---

## Future Expansion

The current hierarchy supports future additions such as:

- Player combat sounds
- Environmental interactions
- UI audio
- Dialogue
- Bus-level processing
- Final gameplay balancing

No further structural changes are expected before Milestone 3.
