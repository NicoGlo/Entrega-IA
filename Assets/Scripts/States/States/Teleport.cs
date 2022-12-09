using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Teleport", menuName = "ScriptableObjects/States/Teleport")]
public class Teleport : State

{
    public Vector3 origin;
    public float radius = 30;
    public int teleport;

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
            owner.GetComponent<NavMeshAgent>().SetDestination(player.transform.position = origin + Random.insideUnitSphere * radius);
        }

        if (!action[0].Check(owner))
        {
            return nextState[0];
        }
        return this;
    }
}




