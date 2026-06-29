# Footstep Audio System

## Objective

Implement the first gameplay audio system using Wwise and Unity.

## Implementation

Created a randomized footstep playback system using Wwise.

### Wwise

* Created Footsteps container
* Created RC_Footsteps_Stone Random Container
* Imported 8 placeholder footstep variations
* Created Play_RC_Footsteps_Stone event
* Added event to Main SoundBank
* Generated SoundBanks

### Unity

* Disabled default Starter Assets footstep playback
* Connected animation-driven footstep events to Wwise
* Configured event posting from the player character
* Verified SoundBank loading and event playback

## Result

Footstep sounds are now triggered directly from animation timing and played through Wwise using randomized sample selection.

This establishes the project's first complete gameplay audio implementation pipeline:

Animation Event → Unity → Wwise Event → SoundBank → Audio Playback

## Key Takeaways

* Wwise event creation and management
* SoundBank workflow
* Unity and Wwise integration
* Animation-driven audio triggering
* Randomized sound variation techniques

## Status

Completed and verified in gameplay.
