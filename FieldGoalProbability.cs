public class FieldGoalCalculator
{
    public static int CalculateFieldGoalProbability(int kickPower, int kickAccuracy, int distance)
    {
        // Normalize the stats to be between 0 and 1
        double normalizedKickPower = kickPower / 100.0; // CHANGE to class attribute: athlete[i].kickPower
        double normalizedKickAccuracy = kickAccuracy / 100.0; // Also change

        // Calculate the base probability based on the distance
        double maxFieldGoalDistance = 70.0;  
        double baseProbability = 1 - (distance / maxFieldGoalDistance); // Not accurate
        
        // Adjust the probability based on the player's kick power and accuracy
        double adjustedProbability;
        if (distance <= 30)
        {
            adjustedProbability = 1;
        }
        else
        {
           adjustedProbability = baseProbability * normalizedKickPower * normalizedKickAccuracy;
        }
        
        // Convert the probability to a percentage and return it
        return (int)(adjustedProbability * 100);
    }
}


/* probability:
Kick power:
Kick accuracy:
Slant: -0.0235x + 1.65
