public class FieldGoalCalculator
{
    public static int CalculateFieldGoalProbability(int kickPower, int kickAccuracy, int distance)
    {
        // Normalize the stats to be between 0 and 1
        double normalizedKickPower = kickPower / 100.0;
        double normalizedKickAccuracy = kickAccuracy / 100.0;

        // Calculate the base probability based on the distance
        double maxFieldGoalDistance = 60.0;  // Example maximum field goal distance
        double baseProbability = 1 - (distance / maxFieldGoalDistance);
        
        // Adjust the probability based on the player's kick power and accuracy
        double adjustedProbability = baseProbability * normalizedKickPower * normalizedKickAccuracy;
        
        // Convert the probability to a percentage and return it
        return (int)(adjustedProbability * 100);
    }
}
