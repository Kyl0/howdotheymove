using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalflag : MonoBehaviour
{
    private GameMaster gm;
    //private GameObject orb;
    private Rigidbody2D mv;
    public bool levelended = false;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();

        //orb = GameObject.FindGameObjectWithTag("Motus");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            levelhasended();
        }
    }
    public void levelhasended()
    {
        levelended = true;
    }
}
