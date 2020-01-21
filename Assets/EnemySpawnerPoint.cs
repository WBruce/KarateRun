using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnerPoint : MonoBehaviour {

    public static EnemySpawnerPoint Instance;

    //Spawn this object
    public GameObject spawnObject;

    public float maxTime = 5;
    public float minTime = 2;
    public float currentSpeed = 0.02f;


    public Color currentColor = Color.red;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Awake() {
        Instance = this;
    }

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }
        if (UIManager.Instance.GlobalScore == 10)
        {
            DifficultyUp();
        }

    }

    void DifficultyUp()
        {
            currentSpeed += 0.005f;
            currentColor = Color.yellow;
            foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
            {
                if(go.tag == "Enemy"){
                    go.GetComponent<EnemyControl>().DefineSpeed(currentSpeed);
                    Debug.Log("I am here in DifficultyUp");
                    Debug.Log(currentSpeed); 
                    go.GetComponent<Renderer>().material.SetColor("_Color", currentColor);  

                    //Destroy(go);
                }

            }
        }

    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0;
        GameObject tmp = Instantiate(spawnObject, transform.position, spawnObject.transform.rotation);
        tmp.GetComponent<EnemyControl>().DefineSpeed(currentSpeed);
        tmp.GetComponent<Renderer>().material.SetColor("_Color", currentColor);   
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

}
