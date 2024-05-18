namespace algoexpert;

public class TournamentWinner
{
    public static string Run(List<List<string>> competitions, List<int> results)
    {
        string winner = string.Empty;
        int highestWinningPoint = 0;    // space 1
        int homeTeamWinning = 1;

        Dictionary<string, int> points = new Dictionary<string, int>();

        for (int i = 0; i < results.Count; i++)  // time n
        {
            string winningTeam = results[i] == homeTeamWinning ? competitions[i][0] : competitions[i][1];

            if (!points.TryAdd(winningTeam, 3))
            {
                points[winningTeam] += 3;
            }

            if (points[winningTeam] > highestWinningPoint)
            {
                highestWinningPoint = points[winningTeam];
                winner = winningTeam;
            }
        }

        return winner;
    }
}
