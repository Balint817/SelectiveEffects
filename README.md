# SelectiveEffects
Mod that allows you to disable battle effects.

## Features
* Individual config options for several effects.
* Enable/disable toggle at the menu.

## Settings
The config file can be found at `${Your muse dash folder}/UserData/SelectiveEffects.cfg`
### Main
* `Enabled` stores the last status of the toggle. Enables/Disables the mod.
* `DisableAllEfects` uses a general method to disable all effects in battle. Takes precedence over the following options.
### Fever
* `DisableFever` disables fever's background and stars.
* `DisableBackground` disables the fever background (keeping the stars and the ending transition). **If only this fever option is enabled it behaves exactly like _BALLCOCK_ mod**.
* `DisableStars` disables the fever stars.
* `DisableTransition` disables the ending transition. **Looks better with `DisableBackground`**.
### Judgement
* `DisableJudgement` disables all judgements (including early/late). Takes precedence over other settings in this category.
* `MakeJudgementSmaller` makes judgements ~25% smaller.
* `DisablePurePerfects` disables pure perfects (perfects that aren't early/late).
* `DisablePerfects` disables the perfect judgement.
* `DisableGreats` disables the great judgement.
* `DisablePass` disables the pass judgement (jumping over gears).
### Hit
* `DisableHitDissapearAnimation` disables the enemies' animation when they have been hit and makes them disappear immediately.
* `DisableHitEffects` disables hit effects and particles.
* `DisableGirlHitFx` the same as `DisableHitEffects` but doesn't disable the out_fx of some enemies.
* `DisablePressFx` disables some particles when playing hold notes.
### MusicHearts
* `DisableMusicNotesFx` disables the particles and text that appear when you touch a music note.
* `DisableHeartsFx` disables the particles and text that appear when you touch a heart.
### Misc
* `DisableBossFx` disables some effects the boss has when deploying enemies.
* `DisableDustFx` disables the dust effect when the character falls to the ground.
* `DisableHurtFx` disables the text that appears when the character is hurt.
* `DisableElfinFx` disables elfin effects.

If used as a performance mod, it is prefered to use the `DisableAllEfects` option instead of the individual options (this doesn't apply to the Fever effects since they are handled in a different way).

## In-game screenshots
### Menu Toggle
![MenuToggle](Media/MenuToggle.jpg)