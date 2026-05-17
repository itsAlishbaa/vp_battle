public class GameStateService
{
    public int KnightHealth { get; set; } = 100;
    public int SkeletonHealth { get; set; } = 100;

    public string Status { get; set; } = "Battle Started";
    public bool IsPaused { get; set; } = false;

    public void AttackKnight()
    {
        if (IsPaused) return;

        KnightHealth -= 10;
        Status = "Skeleton attacked Knight!";
        CheckWin();
    }

    public void AttackSkeleton()
    {
        if (IsPaused) return;

        SkeletonHealth -= 15;
        Status = "Knight attacked Skeleton!";
        CheckWin();
    }

    public void Pause()
    {
        IsPaused = !IsPaused;
        Status = IsPaused ? "Game Paused" : "Game Resumed";
    }

    void CheckWin()
    {
        if (KnightHealth <= 0)
            Status = "Skeleton Wins! Knight Down";

        if (SkeletonHealth <= 0)
            Status = "Knight Wins! Skeleton Down";
    }

    public void Reset()
    {
        KnightHealth = 100;
        SkeletonHealth = 100;
        Status = "New Battle Started";
        IsPaused = false;
    }
}