using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CollisionDecison : Decision
{
    public override bool Decide(StateController controller)
    {
        return controller.collisionThisFrame;
    }
}
