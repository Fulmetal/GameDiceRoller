using GameDiceRoller.Enums;

namespace GameDiceRoller;

/// <summary>
/// Represents a single die that can be rolled to produce a random integer
/// within a specified range or according to a predefined die type.
/// </summary>
public class Die
{
    private DieType DieType { get; }
    private int MinValue { get; set; }
    private int MaxValue { get; set; }
    public int Result { get; private set; } = -1;

    /// <summary>
    /// Represents a single die that can be rolled to produce a random integer
    /// within a specified range or according to a predefined die type.
    /// </summary>
    public Die(DieType dieType)
    {
        DieType = dieType;
        SetDieMinMax();
    }

    /// <summary>
    /// Represents a single die that can be rolled to produce a random integer
    /// within a specified range or based on a predefined die type.
    /// </summary>
    public Die(int minValue, int maxValue)
    {
        MinValue = minValue;
        MaxValue = maxValue;
    }

    /// <summary>
    /// Retrieves the maximum value for a specified die type.
    /// </summary>
    /// <param name="dieType">The type of die for which to determine the maximum value.</param>
    /// <return>The maximum integer value that the specified die can produce.</return>
    public static int GetDieMaxValue(DieType dieType)
    {
        return dieType switch
        {
            DieType.D20 => 20,
            DieType.D12 => 12,
            DieType.D10 => 10,
            DieType.D8 => 8,
            DieType.D6 => 6,
            DieType.D4 => 4,
            DieType.D100 => 100,
            DieType.CoinFlip => 2,
            _ => 0
        };
    }

    /// <summary>
    /// Configures the minimum and maximum possible values for the die
    /// based on its type. The minimum value is set to 1, and the maximum
    /// value is determined by the specified die type.
    /// </summary>
    private void SetDieMinMax()
    {
        MinValue = 1;
        MaxValue = GetDieMaxValue(DieType);
    }

    /// <summary>
    /// Rolls the die and generates a random integer within the die's defined range.
    /// Updates the result property and returns the value of the roll.
    /// </summary>
    /// <returns>The random integer produced by rolling the die.</returns>
    public int Roll()
    {
        Result = RandomNumberGenerator.GenerateInt(MinValue, MaxValue);
        return Result;
    }

}