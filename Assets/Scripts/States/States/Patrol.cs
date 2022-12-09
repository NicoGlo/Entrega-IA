using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Patrol", menuName = "ScriptableObjects/States/Patrol")]
public class Patrol : State
{

    public Vector3[] WayPoints;
    private int nextWayPoint;



    public override State Run(GameObject owner)
    {
        owner.GetComponent<Animator>().Play("Run");
        owner.GetComponent<NavMeshAgent>().SetDestination(WayPoints[nextWayPoint]);
        float distance = Vector3.Distance(owner.transform.position, WayPoints[nextWayPoint]);
        Debug.Log(distance);
        if (distance < 3.0f)
        {
            nextWayPoint = (nextWayPoint + 1) % WayPoints.Length;


        }
        return this;
    }
}







