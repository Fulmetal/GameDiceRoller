# GameDiceRoller

A versatile dice rolling simulator designed for gamers, tabletop RPG enthusiasts, and game developers who need reliable random dice roll generation.

## Features

- **Multiple Dice Types**: Support for various dice formats including d4, d6, d8, d10, d12, and d20
- **Random Number Generation**: Utilizes .NET's robust random number generation for unpredictable outcomes
- **Flexible Usage**: Can be integrated into larger gaming applications or used as a standalone utility
- **Modern C# Implementation**: Built with C# 14.0 language features and targets .NET 10.0 framework
- **Object-Oriented Design**: Clean, maintainable code structure suitable for extension and modification

## Usage

### Basic Dice Rolling
The application provides simple methods to generate random dice rolls for different dice types.

### Integration
Can be easily integrated into:
- Tabletop RPG applications
- Board game simulators
- Game development tools
- Educational software for mathematics or programming

## Getting Started

### Die

Get max value of a specific die
```cs
var dieMaxValue = Die.GetDieMaxValue(DieType.D12);
```

instantiate die class with a D20 die
```cs
var die = new Die(DieType.D20);
```

get the result of a die roll
```cs
var d20Roll = die.Roll();
```

retrieve the result of the last roll
```cs
var storedResult = die.Result;
```

### Hand

instantiate a hand with two different dice
```cs
var handDifferent = new Hand([DieType.D8, DieType.D6]);
```

instantiate a hand with three dice of the same type
```cs
var hand = new Hand(DieType.D10, 3);
```

roll all dice in the hand
```cs
var handRollTotal = hand.Roll();
```

get the roll result of the first die
```cs
var firstDieResult = hand.Dice.First().Result;
```

get the roll result of the second die
```cs
var secondDieResult = hand.Dice[1].Result;
```
