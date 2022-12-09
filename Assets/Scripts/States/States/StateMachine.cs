using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateMachine : MonoBehaviour
{
    public static StateMachine Instance;
    public State startingState;
    public State currentState;
    public
    void Start()
    {
        currentState = startingState;
    }

    void Update()
    {
        this.name = "(S)" + currentState;
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
