using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "GoToBearState", menuName = "ScriptableObjects/States/GoToBearState")]
public class GoToBearState : State

{
    public override State Run(GameObject owner)
    {
        GameObject bear = null;

        RaycastHit[] info =
        Physics.SphereCastAll(owner.transform.position, 35, Vector3.up);

        foreach (RaycastHit col in info)
        {

            if (col.collider.gameObject.GetComponent<Bear>())
            {
                bear = col.collider.gameObject;
            }
        }

        if (bear)
        {
            owner.GetComponent<NavMeshAgent>().SetDestination(bear.transform.position);
            owner.GetComponent<Animator>().Play("Run");
        }

        if (!action[0].Check(owner))
        {
            return nextState[0];
        }
        return this;
    }
}


