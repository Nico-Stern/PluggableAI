using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class State : ScriptableObject
{
    public Action[] actions;
    public Transition[] transitions;
    
    public void UpdateState(StateController controller)
    {
        DoActions(controller);
        CheckTransitions(controller);
    }
    
    void DoActions(StateController controller)
    {
        foreach (Action action in actions)
        {
            action.Act(controller);
        }
    }

    void CheckTransitions(StateController controller)
    {
        foreach (Transition transition in transitions)
        {
            bool decision = transition.decision.Decide(controller);
            State targetState = decision ? transition.trueState : transition.falseState;
            controller.TransitionToState(targetState);
        }
    }
}
