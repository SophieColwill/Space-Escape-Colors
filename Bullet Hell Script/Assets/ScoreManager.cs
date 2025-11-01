using UnityEngine;

//Scpre Manager is a singleton
public class ScoreManager : Singleton<ScoreManager>
{
    public float HighScore = 0;
    public float CurrentTime = 0;
    public int Wave = 1;

    [Header("EnemySpeeds")]
    public float BaseSpeed;
    public float SpeedPerWave;
    public float ModifierSpeed;
    public float EnemySpawnerSpeedStart;
    public float EnemySpawnerSpeedPerWave;
    public float EnemySpawnAreaX;

    void Update()
    {
        //Makes time pass for the current time variable
        CurrentTime += Time.deltaTime;

        //Checks what wave the game is on (to calculate stuff elsewhere) by dividing the current time by 5, and rounding down. It starts at wave 1.
        Wave = Mathf.FloorToInt((CurrentTime + 5) / 5);
    }

    public void MatchEnded()
    {
        //Plays when the player dies. If the previous match's score is higher than your current high score, set that score to the new high score.
        if (CurrentTime > HighScore)
        {
            HighScore = CurrentTime;
        }
        CurrentTime = 0;
        Player.ShipBoostValue = 8;
    }
}
