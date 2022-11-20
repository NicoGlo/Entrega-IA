using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPhysics : MonoBehaviour
{
   private void OnTriggerEnter (Collider other)
   {
       PlayerController player = other.GetComponent<PlayerController>();
       if(player != null)
       {
           player.playerSpeed /= 1.5f;
       }
   }

   private void OnTriggerExit (Collider other)
   {
       PlayerController player = other.GetComponent<PlayerController>();
       if(player != null)
       {
           player.playerSpeed *= 1.5f;
       }
   }
}
