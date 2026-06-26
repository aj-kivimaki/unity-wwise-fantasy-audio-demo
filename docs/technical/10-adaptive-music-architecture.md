# Adaptive Music Architecture

## Overview

This document describes the foundational architecture supporting the adaptive music system used in the Unity Wwise Fantasy Audio Demo.

The architecture separates gameplay logic from music playback using Wwise States and dedicated music events.

---

## Music Content Hierarchy

Property Container

- Music

Virtual Folders

- Exploration
- Combat
- Stingers

The Music Property Container is routed to the dedicated Music Audio Bus.

---

## Events

The following events provide the interface between Unity and Wwise:

- Play_Music
- Stop_Music

Unity controls music playback through events and gameplay state changes rather than directly selecting audio assets.

---

## Music State Group

State Group

- Music

States

- Exploration
- Combat

Music behavior will be driven by State changes during gameplay.

---

## Audio Routing

Music content is routed through the dedicated Music Audio Bus.

This allows independent control of:

- Music volume
- DSP processing
- Mixing
- Future dynamic balancing

without affecting ambience or gameplay sound effects.

---

## Design Philosophy

The adaptive music system follows a clear separation of responsibilities.

Unity is responsible for gameplay events.

Wwise is responsible for:

- Music playback
- State management
- Transition behavior
- Audio routing
- Future adaptive music logic

This architecture creates a scalable workflow suitable for future RTPC-driven music intensity and advanced adaptive music techniques.

---

## Next Steps

The next implementation phase introduces placeholder exploration and combat music together with gameplay-driven music transitions.
