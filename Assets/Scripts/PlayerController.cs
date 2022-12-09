using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float gravityForce = 50f;
    private CharacterController controller;
    public int score;
    public int MaxHeart;
    public int heal;
    public static PlayerController Instance { get; private set; }
    void Awake() { Instance = this; }
    void Start()
    {
        controller = GetComponent<CharacterController>();
        heal = MaxHeart;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z + transform.up * -gravityForce;
        movement *= Time.deltaTime * playerSpeed;
        movement.y /= playerSpeed;
        controller.Move(movement);
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
            //codigo para el cambio de la escena si le das a la tecla "Escape"//
        }
    }

    void Save()
    {
        JSONObject playerJson = new JSONObject();
        JSONArray position = new JSONArray();
        position.Add(transform.position.x);
        position.Add(transform.position.y);
        position.Add(transform.position.z);
        playerJson.Add("Position", position);
        JSONArray rotation = new JSONArray();
        position.Add(transform.rotation.x);
        position.Add(transform.rotation.y);
        position.Add(transform.rotation.z);
        playerJson.Add("Rotation", rotation);

        string path = Application.persistentDataPath + "/save.json";
        File.WriteAllText(path, playerJson.ToString());
    }

    void Load()
    {
        string path = Application.persistentDataPath + "/save.json";
        string jsonString = File.ReadAllText(path);
        JSONObject playerJson = (JSONObject)JSON.Parse(jsonString);
        Debug.Log(playerJson["Position"].AsArray[0]);
        transform.position = new Vector3(
            playerJson["Position"].AsArray[0],
            playerJson["Position"].AsArray[1],
            playerJson["Position"].AsArray[2]
            );
    }

    void OnDisable()
    {
        Save();
    }
}