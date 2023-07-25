using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TimerDecision : Decision
{
    public float timerThreshold;
    
    public override bool Decide(StateController controller)
    {
        controller.rb.velocity = new Vector2(0,0);
        return controller.currentTimer >= timerThreshold;
    }
}
