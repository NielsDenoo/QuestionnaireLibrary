namespace ScoreBoardLibrary
{
    public class Scoreboard
    {
        private List<PlayerScore> scoreList = new List<PlayerScore>();

        public Scoreboard() 
        { 
        
        }

        public void AddPlayer(string name, int score)
        {
            scoreList.Add(new PlayerScore(name, score));

        }

        public void SortScoreBoard() 
        {
            int sortOrder = -1;
            scoreList.Sort((a, b) => sortOrder * a.Score.CompareTo(b.Score));
        }

        public override string ToString()
        {
            string st = "";
            SortScoreBoard();
            foreach (PlayerScore score in scoreList)
            {
                st += $"{scoreList.IndexOf(score)+1}. " + score.ToString()
                    + "\n";
            }

            return st;
        }
    }
}