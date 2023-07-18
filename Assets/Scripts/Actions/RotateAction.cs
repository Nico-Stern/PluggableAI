using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RotateAction : Action
{
    public override void Act(StateController controller)
    {
        controller.transform.Rotate(Vector3.forward, controller.rotationSpeed);
    }
}
