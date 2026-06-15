# Project Setup and Environment Blockout

## Objective

Create the technical foundation for a Unity + Wwise game audio portfolio project focused on demonstrating:

* Music composition
* Interactive music implementation
* Technical audio implementation
* Sound design

The project is intended to generate material for four portfolio reels:

1. Composer Reel
2. Interactive Music Reel
3. Technical Audio Breakdown Reel
4. Cinematic Scoring Reel

---

## Initial Setup

### Unity Project

* Created a new Unity URP project.
* Created Git repository and GitHub remote.
* Established version control workflow.
* Created project folder structure.

### Folder Structure

* Audio
* Art
* Prefabs
* Scenes
* Scripts
* Settings
* ThirdParty

### Scene Setup

Created a dedicated PortfolioDemo scene for development.

---

## Third Person Controller

### Starter Assets

Imported Unity Starter Assets Third Person Controller package.

Installed dependencies:

* Input System
* Cinemachine
* URP dependencies

Verified:

* Character movement
* Camera control
* Jumping
* Third-person gameplay

Resolved camera setup issues and established a working playable scene.

---

## Environment Assets

Imported:

* KayKit Dungeon Remastered
* KayKit Skeletons

Assets were organized under the ThirdParty folder.

---

## Level Design

### Design Goal

Create a simple gameplay space that supports:

* Exploration music
* Music transitions
* Combat music
* Ambient audio
* Technical audio systems

The environment is intentionally minimal to keep development focused on audio implementation rather than game design.

### Layout

Spawn Area

↓

Exploration Corridor

↓

Gate / Transition Area

↓

Combat Arena

↓

Exit Corridor

↓

Shrine Area

### Environment Dressing

Added:

* Dungeon floor pieces
* Walls
* Gate structures
* Torches
* Pillars
* Decorative props

The level was organized into separate hierarchy groups:

* SpawnArea
* Corridor
* Gate
* CombatRoom
* Shrine

---

## Technical Lessons Learned

* Unity scene navigation
* Hierarchy organization
* Modular environment construction
* Git workflow for Unity projects
* Scene recovery using Git
* Camera setup and Cinemachine basics
* Starter Assets integration

---

## Result

A fully playable prototype environment has been completed and is ready for Wwise integration and audio system development.
