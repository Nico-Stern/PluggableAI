using UnityEngine;

namespace Actions
{
    [CreateAssetMenu]
    public class TimerAction : Action
    {
        public override void Act(StateController controller)
        {
            controller.currentTimer += Time.deltaTime;
        }
    }
}