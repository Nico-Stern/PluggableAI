using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BackwardAction : Action
{
    public override void Act(StateController controller)
    {
        controller.rb.velocity = new Vector2(-controller.speed, 0);
    }
}
