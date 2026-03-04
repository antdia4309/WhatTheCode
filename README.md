# 🎮 What the CODE?

A dual-layer, age-adaptive coding education game built with **C# + Blazor**. Designed to teach programming logic to anyone — from a 6-year-old dragging blocks to a 40-year-old reading real syntax.

---

## 🧠 The Concept

Most coding education tools pick a lane — either too simple for adults or too intimidating for kids. **What the CODE?** bridges that gap with a progressive interface that evolves as the user's brain levels up.

| Junior Mode | Pro Mode |
|---|---|
| Large buttons, visual blocks | Full code editor, dark mode |
| Audio cues, mascot guidance | Syntax highlighting, debugging |
| Block-based logic | Real C# / text-based code |

---

## 🚀 Sessions (Build Roadmap)

| Session | Focus | Status |
|---|---|---|
| 1 | Core feedback loop — code → visual output | ✅ Complete |
| 2 | User identity — login, level progress, state saving | 🔲 Up next |
| 3 | Age-specific UX — Junior vs Pro layout toggle | 🔲 Planned |
| 4 | Gamification — badges, sandbox mode, polish | 🔲 Planned |

---

## 🏗️ Architecture

```
What-the-CODE/
├── Components/
│   ├── Pages/
│   │   └── Sandbox.razor       # Main game page
│   ├── Layout/
│   │   ├── MainLayout.razor    # App shell
│   │   └── NavMenu.razor       # Navigation
│   ├── GameGrid.razor          # Reusable grid component
│   ├── App.razor               # Entry point
│   └── _Imports.razor          # Global usings
├── Models/
│   ├── Character.cs            # Position, direction, movement
│   └── Grid.cs                 # Grid dimensions + visited tracking
├── Services/
│   └── CommandEngine.cs        # Translates commands → character actions
└── WhatTheCode.csproj
```

---

## ⚙️ Tech Stack

- **Language:** C# (.NET 10)
- **Framework:** Blazor Server
- **Architecture:** Object-Oriented Programming (OOP)
- **Naming Convention:** camelCase
- **Hosting:** GitHub Codespaces (dev) → Azure Static Web Apps (prod)

---

## 🎯 Session 1 Features

- 8x8 interactive grid
- Bot character with directional movement
- Commands: Move Forward, Turn Left, Turn Right, Reset
- Visited cell tracking (path history)
- **Code Bridge** — shows the real C# behind every block command
- Out-of-bounds detection with error feedback

---

## 🛠️ Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- GitHub Codespaces or local dev environment

### Run Locally

```bash
git clone https://github.com/your-username/What-the-CODE.git
cd What-the-CODE
dotnet run
```

Navigate to `http://localhost:5290` in your browser.

### Run in Codespaces

1. Open the repo on GitHub
2. Click **Code → Codespaces → Create codespace**
3. In the terminal: `dotnet run`
4. Click the forwarded port link when prompted

---

## 🔭 What's Scope (and What's Not)

### ✅ In Scope
- Progressive block-to-text interface
- Visual feedback sandbox
- Age-adaptive UI (Junior / Pro toggle)
- Gamification (badges, streaks, skill tree)
- Accessibility (text-to-speech, high contrast)

### 🚫 Out of Scope (for now)
- Real-time multiplayer co-coding
- AI-powered tutoring
- Native desktop apps
- Hardware integration (Arduino, LEGO Mindstorms)
- Global ranked leaderboards
- Multi-language voiceovers

---

## 🤝 Contributing

This project is in active early development. If you'd like to contribute, open an issue first to discuss what you'd like to change.

---

## 📄 License

MIT

---

> *"The best way to learn to code is to see your code do something."*