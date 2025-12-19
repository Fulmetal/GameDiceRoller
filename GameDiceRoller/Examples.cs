using GameDiceRoller.Enums;

namespace GameDiceRoller;

internal class Examples
{
    /// <summary>
    /// Demonstrates the usage of the Die class and provides examples of
    /// various operations such as retrieving the maximum value of a specific
    /// die type, rolling a die, and accessing the last roll result.
    /// </summary>
    /// <remarks>
    /// This method includes the following operations:
    /// - Fetching the maximum value of a specified die type using GetDieMaxValue.
    /// - Instantiating the Die class with a defined die type.
    /// - Rolling the die to obtain a random value within the specified range.
    /// - Accessing the result of the last roll through the Result property.
    /// </remarks>
    private void DieExample()
    {
        //Get max value of a specific die
        var dieMaxValue = Die.GetDieMaxValue(DieType.D12);
        
        //instantiate die class with a D20 die
        var die = new Die(DieType.D20);

        //get the result of a die roll
        var d20Roll = die.Roll();

        //retrieve the result of the last roll
        var storedResult = die.Result;
    }

    /// <summary>
    /// Demonstrates the functionality of the Hand class, providing examples of
    /// operations such as instantiating hands with different dice configurations,
    /// rolling the dice, and accessing individual roll results.
    /// </summary>
    /// <remarks>
    /// This method includes the following operations:
    /// - Creating a hand with dice of different types using a list of dice.
    /// - Creating a hand with multiple dice of the same type using a die type and quantity.
    /// - Rolling all dice in a hand to obtain their total sum.
    /// - Accessing the roll results of specific dice in the hand.
    /// </remarks>
    private void HandExample()
    {
        //instantiate a hand with two different dice
        var handDifferent = new Hand([DieType.D8, DieType.D6]);

        //instantiate a hand with three dice of the same type
        var hand = new Hand(DieType.D10, 3);

        //roll all dice in the hand
        var handRollTotal = hand.Roll();

        //get the roll result of the first die
        var firstDieResult = hand.Dice.First().Result;

        //get the roll result of the second die
        var secondDieResult = hand.Dice[1].Result;
    }

}