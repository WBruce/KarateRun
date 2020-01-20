using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    public float enemySpeed;
    float globalScore = ScoreManager.GlobalScore;
    bool RankUpOnce = false;

	// Use this for initialization
	void Start () {
        enemySpeed = 0.02f;

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 tmp = transform.position + Vector3.left * enemySpeed;
                transform.position = tmp;
        if (ScoreManager.GlobalScore == 10 && RankUpOnce == false)
        {
            RankUpOnce = true;
            DifficultyUp();
        }

        Debug.Log(enemySpeed);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Attack")
        {
            Destroy(gameObject);
            ScoreManager.GlobalScore++;
        }
    }

    void DifficultyUp()
    {
            enemySpeed = enemySpeed + 0.005f;
    }
    }
