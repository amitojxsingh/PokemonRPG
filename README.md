# PokemonRPG

A C# console-based Pokemon RPG battle simulator built with .NET 8.

## Project Structure

```
PokemonRPG/
├── PokemonRPG/              # Main console application
├── PokemonRPG.Models/       # Core data models (Monsters, Moves, Players)
├── PokemonRPG.Battlefield/  # Battle management logic
├── PokemonRPG.Repositories/ # Data repositories for monsters and moves
└── PokemonRPG.Services/     # Business logic services
```

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- VS Code (recommended) with C# Dev Kit extension

## Building the Project

```sh
dotnet build
```

## Running the Application

```sh
dotnet run --project PokemonRPG/PokemonRPG.csproj
```

Or from the PokemonRPG directory:

```sh
cd PokemonRPG
dotnet run
```

## Features

- Turn-based Pokemon battle system
- Multiple monster types (Fire, Water, Grass, Normal)
- Move system with PP (Power Points), accuracy, and damage
- Player party management (up to 6 monsters)
- COM (Computer) player support for AI battles

## Architecture

### Models
- **BattleMonster**: Base monster class with stats (HP, Attack, Defense, Speed)
- **BattleMove**: Move system with power, accuracy, and type effectiveness
- **BasePlayer**: Player abstraction supporting human and COM players

### Repositories
- **BattleMonsterRepository**: Pre-defined starter monsters (Bulbasaur, Charmander, Squirtle)
- **BattleMoveRepository**: Move database (Struggle, Tackle, Ember, etc.)

### Battle System
- **BattleManager**: Handles battle flow and turn resolution