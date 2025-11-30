using GameDiceRoller.Enums;

namespace GameDiceRoller;

/// <summary>
/// Represents a hand of dice, allowing multiple dice to be rolled together
/// and their results to be summed.
/// </summary>
public class Hand
{
    public List<Die> Dice { get; }

    /// <summary>
    /// Instantiate a hand using a list of dice
    /// </summary>
    /// <param name="dice"></param>
    public Hand(DieType[] dice)
    {
        Dice = new List<Die>();
        
        foreach (var dieType in dice)
        {
            Dice.Add(new Die(dieType));
        }
    }

    /// <summary>
    /// Instantiate a hand using multiple dice of the same type
    /// </summary>
    /// <param name="dieType"></param>
    /// <param name="quantity"></param>
    public Hand(DieType dieType, int quantity)
    {
        Dice = new List<Die>();
        
        for (var i = 0; i < quantity; i++)
        {
            Dice.Add(new Die(dieType));
        }
    }

    /// <summary>
    /// Roll all dice in hand
    /// </summary>
    /// <returns></returns>
    public int Roll()
    {
        foreach(var die in Dice)
        {
            die.Roll();
        }
        return Dice.Sum(x => x.Result);
    }
}