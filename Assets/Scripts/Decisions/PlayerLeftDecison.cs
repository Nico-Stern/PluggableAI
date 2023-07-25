using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerLeftDecison : Decision
{
    public override bool Decide(StateController controller)
    {
        return (Physics2D.Raycast(controller.left.transform.position, controller.left.transform.TransformDirection(Vector2.left), controller.Sichtweite,controller.Player));
    }
}
