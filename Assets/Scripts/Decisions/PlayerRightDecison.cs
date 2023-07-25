using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerRightDecison : Decision
{
    public override bool Decide(StateController controller)
    {
        return (Physics2D.Raycast(controller.right.transform.position, controller.right.transform.TransformDirection(Vector2.right), controller.Sichtweite,controller.Player));
    }
}
