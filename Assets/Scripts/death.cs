﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    private GameMaster gm;
    //private GameObject orb;
    private Rigidbody2D mv;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        
        //orb = GameObject.FindGameObjectWithTag("Motus");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Destroy(orb);
            //Destroy(other.gameObject);
            //orb.SetActive(false);
            //other.gameObject.SetActive(false);
            //GameObject.GetCompon.position = gm.lastCheckPointPos;
            other.gameObject.transform.position = gm.lastCheckPointPos;
            mv = other.gameObject.GetComponent<Rigidbody2D>();
            mv.velocity = Vector3.zero;
        }
    }
}
