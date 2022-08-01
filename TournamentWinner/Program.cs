// Tournament Winner

// Brute Force is the best optimized solution
// Time: O(n) Space: O(k) where n is the number
//      of competitons and k is the number of teams.

int HOME_TEAM_WON = 1;

string TournamentWinner(List<List<string>> competitions, List<int> results)
{
    string currentBestTeam = string.Empty;
    
    // Create scores data structure that keep track of all the team scores
    Dictionary<string, int> scores = new Dictionary<string, int>();
    scores[currentBestTeam] = 0;

    // Loop through the entire competitions array
    for (int idx = 0; idx < competitions.Count; idx++)
    {
        // Use idx in the for loop for the result array index
        int result = results[idx];

        // Decompose the competition into the home and away teams
        List<string> competition = competitions[idx];      

        string homeTeam = competition[0];
        string awayTeam = competition[1];

        // Determine the winner based on the results array
        string winningTeam = (result == HOME_TEAM_WON) ? homeTeam : awayTeam;

        // Update the score of the winning team
        updateScores(winningTeam, 3, scores);

        // Check if we need to update the best team based on the
        // last winning team
        if (scores[winningTeam] > scores[currentBestTeam])
        {
            currentBestTeam = winningTeam;
        }
    }

    return currentBestTeam;
}

void updateScores(string team, int points, Dictionary<string, int> scores)
{
    // Check if the team is a key in our data structure
    // If not, then add the key
    if (!scores.ContainsKey(team))        
    {
        scores[team] = 0;
    }

    // Update the team score
    scores[team] = scores[team] + points;
}