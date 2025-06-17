# 🌌 Lunar - Augmented Reality Solar System

**Lunar** is an educational Augmented Reality (AR) application built with **Unity** and **Vuforia** that allows users to explore the solar system interactively. By scanning an image target, users can visualize the planets orbiting the sun, observe each planet's rotation, and interact with 3D models using touch or mouse input.

## 🚀 Features

- 🌞 Realistic simulation of the 8 planets orbiting the sun
- 🌍 Individual planet rotation on its own axis
- 🌑 Moon orbiting the Earth
- 🖐️ Interactive controls:
  - Rotate and scale planets using touch gestures (mobile)
  - Mouse interaction supported in Unity Editor
- 🔍 Educational tool to help users understand planetary motion and structure of the solar system

## 🛠️ Built With

- **Unity** (2021 or newer)
- **Vuforia Engine** for image target tracking
- **C#** scripting for custom orbit and interaction logic

## 📦 Project Structure

ImageTargetTataSurya/

└── solar system/

├── sun

├── Earth

│ └── Moon (with orbit)

├── mars

├── jup

├── sat

├── ura

├── nep

├── mer

└── ven

- All planets are orbiting the Sun using a custom `PlanetMotion.cs` script.
- The Moon is orbiting Earth using a `MoonOrbit.cs` script.

## 🎮 How to Use

### In Unity Editor:

1. Open the scene containing the AR setup.
2. Use mouse drag to rotate planets.
3. Use scroll wheel to zoom (scale).

### On Android Device:

1. Build the project to Android using Unity.
2. Scan the image target using your phone's camera.
3. Interact with the solar system using pinch and drag gestures.

## 📱 Controls

| Action        | Mobile (Touch)           | Unity Editor (Mouse)     |
| ------------- | ------------------------ | ------------------------ |
| Rotate planet | 1-finger drag            | Left-click + drag        |
| Scale planet  | 2-finger pinch           | Mouse scroll             |
| Orbit planets | Auto orbiting around Sun | Auto orbiting around Sun |

## 📚 Educational Purpose

Lunar is developed for educational purposes to provide an immersive learning experience about the solar system using AR. It helps users, especially students, visualize and understand:

- Planetary order and distances
- Orbital motion and rotation
- Moon’s revolution around the Earth

## ✨ Future Improvements

- Add information panels (tooltips) on each planet
- Add voice narration or audio guide
- Implement planet surface zoom-in and exploration
- Support multiple image targets for modular AR scenes

## 👨‍💻 Developer

Made with ❤️ by [Hidayat Hatta Irsyad](https://www.linkedin.com/in/hidayat-hatta-irsyad-36809a279/), [Muhammad Ikram Syafwan](https://www.linkedin.com/in/muhammad-ikram-syafwan-27610524a/), [Muhammad Muttakin](https://www.linkedin.com/in/muhammad-muttakin-908ab0269/), and [Najwa Rokhan Rusmana](https://www.linkedin.com/in/najwa-rokhan-rusmana-615790191/).

---
