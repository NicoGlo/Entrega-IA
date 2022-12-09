using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public abstract class State : ScriptableObject
{
    public static State Instance;
    public Actions[] action;
    public State[] nextState;
    public TMPro.TMP_Text text;
    public StateMachine stateMachine;

    public abstract State Run(GameObject owner);

    public void UpdateStateText()
    { 
        text.text = this.name;
    }



}


