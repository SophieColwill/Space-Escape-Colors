using UnityEngine;

public class TimerScript : Observer
{
    public override void Notify(Subject subject, float deltaTime)
    {
        ScoreManager.Instance.CurrentTime += deltaTime;
    }
}
