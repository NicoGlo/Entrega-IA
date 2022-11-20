using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{

    public State startingState;
    public State currentState;
    void Start()
    {
        currentState = startingState;
    }

    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        if (currentState == null)
        {
            return;
        }

        State nextState = currentState.Run(gameObject);

        if (nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(State next)
    {
        currentState = next;
    }
}
