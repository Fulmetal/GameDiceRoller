namespace GameDiceRoller;

/// <summary>
/// Provides methods for generating random numbers to be used in game-related functionality.
/// This static class supports generating random integers within specified ranges with optional use of a seed.
/// </summary>
internal static class RandomNumberGenerator
{
    /// <summary>
    /// Generates a random integer between min and max
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    internal static int GenerateInt(int min, int max)
    {
        return Random.Shared.Next(min, max + 1);
    }

    /// <summary>
    /// Generates a random integer between min and max using a seed
    /// </summary>
    /// <param name="seed"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    internal static int GenerateIntWithSeed(int seed, int min, int max)
    {
        var rand = new Random(seed);
        return rand.Next(min, max + 1);
    }
}