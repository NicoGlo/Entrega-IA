using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "HearAction", menuName = "ScriptableObjects/States/Action/HearAction")]
public class HearAction : Actions
{

    public override bool Check(GameObject owner)
    {
        RaycastHit[] info =
        Physics.SphereCastAll(owner.transform.position, 35, Vector3.up);

        foreach (RaycastHit col in info)
        {
            if (col.collider.gameObject.GetComponent<PlayerController>())
            {
                return true;
            }

        }
        return false;
    }
}



