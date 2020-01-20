using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager Instance; //Rendre tout ce fichier public

    public Text ourNewScore;          // Our reference to text component
 
    public GameObject debug_EnemySpeed; // gameObject in Hierarchy
    Text txt_debug_EnemySpeed;          // Our reference to text component

    public EnemyControl enemyControl;

    public int GlobalScore = 0;


    void Awake(){
            Instance = this;
    }

	// Use this for initialization
	void Start () {
		Debug.Log("Hello");
	}

    public void UpdateScore(int score)
    {
        GlobalScore += score;
        ourNewScore.text = "Enemy Defeated - " + GlobalScore.ToString();
    } 
	
	// Update is called once per frame
	void Update () {


        /*debug_EnemySpeed = GameObject.Find("Debug_EnemySpeed");
        txt_debug_EnemySpeed = debug_EnemySpeed.GetComponent<Text>();
        txt_debug_EnemySpeed.text = "Enemy Speed - " + enemyControl.enemySpeed.ToString();*/

    }


}
