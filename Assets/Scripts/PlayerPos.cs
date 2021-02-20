using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    private GameObject pl;
    //private GameObject orb;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        pl = GameObject.FindGameObjectWithTag("Player");
        //orb = GameObject.FindGameObjectWithTag("Motus");
        transform.position = gm.lastCheckPointPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pl.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //orb.SetActive(true);
            //pl.transform.position = gm.lastCheckPointPos;
        }
    }
}
