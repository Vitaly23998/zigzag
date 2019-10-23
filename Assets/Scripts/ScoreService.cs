public class ScoreService
{
    public static int Score { get; set; } = 0;

    public static void ChangeScore()
    {
        Score++;
    }
}
