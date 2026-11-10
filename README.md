# Roll-A-Ball (Unity)

MM 806 Virtual Reality and Tele-Presence, Assignment 1, by Rachita Dewanjee.

A 3D Roll-A-Ball game built in Unity. The player rolls a ball around a walled arena and
collects all 16 golden pick-ups while a red enemy chases them around the obstacles.

## Gameplay
- **Move:** keyboard (the ball is physics driven)
- **Goal:** collect all 16 pick-ups; the score shows `0 / 16` and counts up
- **Win:** all 16 pick-ups collected
- **Lose:** the red enemy touches the ball first
- **Menus:** main menu, pause menu, win/lose screens

## What I added beyond the standard tutorial
- Custom arena: cobblestone ground, dark brick boundary walls, five angled wooden obstacles
- Enemy that chases the player and navigates around obstacles (NavMesh)
- Soccer-ball player material, golden pick-ups, resized red enemy
- URP/Lit materials with textures, tuned directional light and soft shadows
- Main menu, pause menu and complete win/lose flow

## Scripts (`Assets/Scripts`)
| Script | What it does |
|---|---|
| `PlayerController.cs` | Ball movement, pick-up collection, score, win/lose |
| `EnemyController.cs` | Enemy chases the player using NavMesh navigation |
| `CameraController.cs` | Camera follows the ball |
| `Rotator.cs` | Spins the pick-ups |
| `MainMenu.cs` | Main menu (play / quit) |
| `PauseMenu.cs` | Pause, resume, return to menu |

## Open the project
1. Install **Unity 6000.3.22f1** (Unity 6) with Unity Hub.
2. Unity Hub → **Add project from disk** → select this folder.
3. Open `Assets/Scenes/MainMenu.unity` and press Play.

Unity rebuilds the `Library` folder on first open, so the first load takes a few minutes.

## Built with
Unity 6000.3.22f1, Universal Render Pipeline (URP), TextMesh Pro, AI Navigation.
