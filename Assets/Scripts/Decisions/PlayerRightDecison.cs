using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerRightDecison : Decision
{
    public override bool Decide(StateController controller)
    {
        return false;
    }
}
