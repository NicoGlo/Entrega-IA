using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "SeeAction", menuName = "ScriptableObjects/States/Action/SeeAction")]
public class SeeAction : Actions
{

    public override bool Check(GameObject owner)
    {
        RaycastHit[] info =
        Physics.SphereCastAll(owner.transform.position, 35, Vector3.up);

        foreach (RaycastHit col in info)
        {

            if (col.collider.gameObject.GetComponent<Bear>())
            {
                return true;
            }

        }
        return false;
    }
}



