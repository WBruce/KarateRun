using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public GameObject ArmFront;
    public GameObject ArmBack;

    // Use this for initialization
    void Start() {
}

    // Update is called once per frame
    void Update() {
        FrontAttack();
        BackAttack();

    }


    void FrontAttack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Lancer une attaque
            ArmFront.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Cacher le bras
            ArmFront.SetActive(false);
        }
    }

    void BackAttack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Lancer une attaque
            ArmBack.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            //Cacher le bras
            ArmBack.SetActive(false);
        }
    }


    //Death of Player
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }

    }

}