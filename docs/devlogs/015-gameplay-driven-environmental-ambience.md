# Devlog 015 — Gameplay-Driven Environmental Ambience

## Overview

Implemented gameplay-driven environmental ambience using Unity triggers and a centralized AmbienceManager.

Previously, all environmental ambience layers automatically started when the scene loaded. This task transitions the system to gameplay-controlled ambience playback, allowing environmental sounds to react naturally to player progression through the level.

---

## Objective

Separate environmental ambience from scene initialization and instead control playback through gameplay events.

The implementation mirrors the architecture established for the interactive music system by introducing a dedicated AmbienceManager responsible for all ambience playback.

---

## Unity Implementation

Created a centralized AmbienceManager singleton responsible for controlling environmental ambience.

Implemented:

- Arena ambience playback
- Arena ambience stop
- Shrine ambience playback
- Playback state tracking
- Protection against duplicate playback requests

ArenaAmbience and ShrineAmbience no longer start automatically when the scene loads.

Gameplay triggers now communicate only gameplay events while AmbienceManager handles all communication with Wwise.

---

## Gameplay Flow

Scene Start

↓

Dungeon ambience starts

↓

Combat begins

↓

Arena ambience starts

↓

Combat ends

↓

Arena ambience stops

↓

Player approaches shrine

↓

Shrine ambience starts

↓

Attenuation increases perceived loudness naturally

---

## Architecture

Gameplay Trigger

↓

AmbienceManager

↓

Wwise Event

↓

AkAmbient GameObject

This mirrors the architecture already established for MusicManager, creating a consistent audio management structure throughout the project.

---

## Validation

Verified:

- Dungeon ambience still starts automatically.
- Arena ambience begins when combat starts.
- Arena ambience stops when combat ends.
- Shrine ambience begins when entering the shrine approach.
- Existing attenuation behaves correctly.
- No duplicate playback events occur.
- Existing music system remains unaffected.
- Wwise Profiler confirms correct event flow.

---

## Notes

Environmental ambience is now fully gameplay-driven while maintaining Wwise-controlled attenuation.

Future milestones will expand the ambience system with original environmental sound design, additional ambient emitters and further environmental audio polish.
