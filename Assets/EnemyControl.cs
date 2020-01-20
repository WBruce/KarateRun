using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    public float enemySpeed;

    bool RankUpOnce = false;

	// Use this for initialization
	void Start () {
        transform.Translate(enemySpeed, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
            RunningAround();
            Debug.Log(enemySpeed);
        
        }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Attack")
        {
            Destroy(gameObject);
            UIManager.Instance.UpdateScore(1);
        }
    }
    public void DefineSpeed(float speed){

        enemySpeed = speed;
    }

    void RunningAround()
    {
        transform.Translate(enemySpeed, 0, 0);

    }

    }
