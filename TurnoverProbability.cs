public class TurnoverPredictor
{
    private const double AVERAGE_TURNOVERS_PER_GAME = 1.5;
    private const double PLAYS_PER_GAME = 120;

    public static double PredictTurnoverProbability(Team offense, Team defense)
    {
        // Calculate the offense's turnover rate per play
        double offenseTurnoverRate = offense.Turnovers / PLAYS_PER_GAME;

        // Calculate the defense's ability to cause turnovers per play
        double defenseTurnoverRate = defense.CausedTurnovers / PLAYS_PER_GAME;

        // Use a simple statistical model to predict the probability of a turnover
        double turnoverProbability = AVERAGE_TURNOVERS_PER_GAME / PLAYS_PER_GAME;
        turnoverProbability *= (offenseTurnoverRate + defenseTurnoverRate) / 2;

        return turnoverProbability;
    }
}

public class Team
{
    public double Turnovers { get; set; }
    public double CausedTurnovers { get; set; }
}
