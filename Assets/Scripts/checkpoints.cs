using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(CompareTag("Player"));
        if (other.gameObject.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }
    }
}
