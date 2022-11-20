using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CoinsGenerate : MonoBehaviour
{
    public GameObject recipient;

    public List<GameObject> objSpawns = new List<GameObject>();
    int spawnSelected;


    void Awake()
    {
        //Set all the objs with the tag spawnLocation inside of the list

            generateNewObj(recipient);
            
    }

    public void generateNewObj(GameObject coin)
    {
        //Get a random number of the list which contains one obj
        spawnSelected = Random.Range(0, objSpawns.Count);
        //Instantiate the GameObject in the location of the random selected object
        Instantiate(coin, objSpawns[spawnSelected].transform.position, objSpawns[spawnSelected].transform.rotation);
        //Delete that possible location from the list
        objSpawns.RemoveAt(spawnSelected);
    }
}