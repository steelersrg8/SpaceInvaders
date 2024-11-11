---

# Space Invaders 🎮

### Classic Arcade Game Recreation using Unity & C#

Welcome to **Space Invaders**, a classic arcade game clone developed using **Unity** and **C#**. This project replicates the nostalgic gameplay of the original Space Invaders with modern enhancements.

## 🚀 Project Overview

In this game, players control a spaceship that moves horizontally along the bottom of the screen. The objective is to shoot down waves of descending alien invaders before they reach the player's ship. As levels progress, the aliens become faster and more challenging, testing players' reflexes and skills.

## 🛠️ Tools & Technologies

- **Programming Language**: C#
- **Game Engine**: Unity
- **IDE**: Visual Studio / JetBrains Rider

## 📁 Project Structure

```
SpaceInvaders
├── Assets
│   ├── Scripts              # C# scripts controlling game logic
│   ├── Prefabs              # Prefabricated game objects (aliens, player ship, projectiles, etc.)
│   ├── Sprites              # 2D sprites for the game's visual assets
│   ├── Scenes               # Unity scenes (e.g., MainMenu, Level1)
│   ├── Audio                # Sound effects and background music
│   └── Fonts                # Custom fonts for UI text
├── README.md                # Project documentation
└── .gitignore               # Ignored files and folders
```

## 🎮 How to Play

1. **Move Left/Right**: Use the arrow keys or `A` and `D` keys to move your ship.
2. **Shoot**: Press the spacebar to shoot projectiles at the alien invaders.
3. **Objective**: Eliminate all aliens before they reach the bottom of the screen.
4. **Progress**: Advance through levels as you defeat waves of increasingly difficult enemies.

## 🛠️ Installation & Setup

To run the project locally:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/steelersrg8/SpaceInvaders.git
   ```
2. **Open the project in Unity**:
   - Ensure you have **Unity Hub** installed.
   - Open Unity and select the `SpaceInvaders` project.
3. **Build & Run**:
   - Press the `Play` button in Unity to start the game in the editor.
   - Alternatively, build an executable by going to `File > Build Settings`.

## 📝 Features

- **Player Controls**: Move your spaceship and shoot projectiles.
- **Enemy AI**: Aliens move side-to-side and descend as waves.
- **Scoring System**: Earn points for each alien destroyed.
- **Audio**: Retro sound effects and background music.
- **Game Over Screen**: Displays when aliens reach the bottom or when the player runs out of lives.
