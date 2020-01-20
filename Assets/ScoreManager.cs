using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject myScore; // gameObject in Hierarchy
    Text ourNewScore;          // Our reference to text component
    public GameObject debug_EnemySpeed; // gameObject in Hierarchy
    Text txt_debug_EnemySpeed;          // Our reference to text component

    public EnemyControl enemyControl;

    public static int GlobalScore = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Find gameObject with name "MyText"
        myScore = GameObject.Find("Score");
        // Get component Text from that gameObject
        ourNewScore = myScore.GetComponent<Text>();
        // Assign new string to "Text" field in that component
        ourNewScore.text = "Enemy Defeated - " + GlobalScore.ToString();


        debug_EnemySpeed = GameObject.Find("Debug_EnemySpeed");
        txt_debug_EnemySpeed = debug_EnemySpeed.GetComponent<Text>();
        txt_debug_EnemySpeed.text = "Enemy Speed - " + enemyControl.enemySpeed.ToString();

    }

}
