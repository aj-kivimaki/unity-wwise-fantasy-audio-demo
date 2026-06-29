# Audio Mixing Philosophy

## Purpose

This document outlines the mixing philosophy used throughout the project and the responsibilities assigned to each audio category.

Rather than treating buses as simple routing objects, the project uses them to represent distinct gameplay and player experience responsibilities. This approach helps keep mixing decisions consistent and scalable as new content is added.

---

# Mixing Hierarchy

The project follows the following priority hierarchy:

```text
Voice
↓
Gameplay SFX
↓
UI
↓
Music
↓
Ambience
```

This hierarchy does not imply fixed volume levels. Instead, it defines which category should take priority when multiple sounds compete for the player's attention.

---

# Category Responsibilities

## Music

**Purpose**

Support emotion, pacing and dramatic tension.

Music reinforces the emotional state of gameplay without competing with important gameplay feedback.

Examples:

- Exploration
- Combat
- Post-Combat

---

## Ambience

**Purpose**

Create a believable sense of place.

Ambience communicates the environment rather than gameplay information and should naturally blend into the background while supporting immersion.

Examples:

- Dungeon ambience
- Arena ambience
- Shrine ambience

---

## Gameplay SFX

**Purpose**

Communicate player actions and gameplay feedback.

Sound effects provide immediate information about interactions and therefore receive higher priority than music or ambience.

Examples:

- Footsteps
- Jump
- Landing

Future additions:

- Weapon impacts
- Player attacks
- Object interactions

---

## UI

**Purpose**

Communicate interface interactions.

UI sounds should be short, recognizable and informative without distracting from gameplay.

Future examples include:

- Button clicks
- Menu transitions
- Notifications

---

## Voice

**Purpose**

Deliver dialogue and narrative information.

Although unused in the current project, a dedicated Voice bus is retained as part of the audio architecture to support future expansion and maintain a conventional production hierarchy.

---

# Bus Architecture Philosophy

Each bus represents a logical audio category rather than individual gameplay objects.

Current hierarchy:

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

This keeps routing simple while allowing the project to grow naturally as additional gameplay systems are introduced.

---

# Current Mixing Strategy

At this stage of development:

- All bus levels remain at **0 dB**.
- Individual assets and containers are balanced as needed.
- Category-level balancing is deferred until all major audio content has been implemented.

This avoids repeatedly adjusting bus levels while the project's audio content is still evolving.

---

# Future Work

Milestone 3 will build upon this foundation by introducing:

- Final category balancing
- Bus-level processing where appropriate
- Environment-specific DSP tuning
- Loudness refinement
- Final gameplay mix

The goal is to establish a clean, scalable routing structure first, then perform artistic mixing once the complete audio experience is in place.
