using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Idle", menuName = "ScriptableObjects/States/IdleState")]
public class IdleState : State
{
    public override State Run(GameObject owner)
    {
        owner.GetComponent<Animator>().Play("Idle");
        

        if (action[0].Check(owner))
        {
            return nextState[0];
        }
        return this;
    }
}




