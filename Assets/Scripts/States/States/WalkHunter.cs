using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "WalkHunter", menuName = "ScriptableObjects/States/WalkHunter")]
public class WalkHunter : State
{
    public Vector3 home;
    public override State Run(GameObject owner)
    {
        home = new Vector3(380.428131f, 1.61000001f, 330.29718f);
        owner.GetComponent<Animator>().Play("Walk");
        owner.GetComponent<NavMeshAgent>().SetDestination(home);

        if(Vector3.Distance(owner.transform.position, home) <= 3)
        {
            return nextState[0];
        }
        return this;
    }
}




