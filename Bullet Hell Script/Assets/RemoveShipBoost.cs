using UnityEngine;

public class RemoveShipBoost : Observer
{
    public override void Notify(Subject subject, float deltaTime)
    {
        Player.ShipBoostValue -= Time.deltaTime;
    }
}
