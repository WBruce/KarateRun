using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class EnemySpawnerPoint : MonoBehaviour {

    public static EnemySpawnerPoint Instance;

    //Spawn this object
    public GameObject spawnObject;

    public float maxTime = 5;
    public float minTime = 2;

    public float currentSpeed = 0.02f;

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
            Debug.Log(currentSpeed);
        }

    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0;
        GameObject tmp = Instantiate(spawnObject, transform.position, spawnObject.transform.rotation);
        tmp.GetComponent<EnemyControl>().DefineSpeed(currentSpeed);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

}
