using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "GoToState", menuName = "ScriptableObjects/States/GoToState")]
public class GoToState : State

{
    public override State Run(GameObject owner)
    {
        GameObject player = null;

        RaycastHit[] info =
        Physics.SphereCastAll(owner.transform.position, 35, Vector3.up);

        foreach (RaycastHit col in info)
        {

            if (col.collider.gameObject.GetComponent<PlayerController>())
            {
                player = col.collider.gameObject;
            }
        }

        if (player)
        {
            owner.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
            owner.GetComponent<Animator>().Play("Run");
        }

        if (!action[0].Check(owner))
        {
            return nextState[0];
        }
        return this;
    }
}




