using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // public float speed;
    // public float StoppingDistance;

    // private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mv = player.GetComponent<movement>();
        target = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    //  void Update()
    //  {
    //     if (Vector2.Distance(transform.position, target.position)> StoppingDistance)
    //      {
    // float move = Input.GetAxis("Horizontal");
    //          transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    //      }
    //  }

    private GameObject player;
    private movement mv;
    private Transform target;
    public Rigidbody2D rb;
    private float speed = 10;
    private float maxSpeed = 50;
    private float jump;
    private float initSpeed = 10;
    public float minDistance;
    public float maxDistance;

    void Update()
    {
        Vector3 dir = (target.transform.position - rb.transform.position).normalized;
        float d = Vector2.Distance(target.transform.position, rb.transform.position);
        
        if (d > minDistance && d <maxDistance)
        {
            rb.MovePosition(rb.transform.position + dir * speed * Time.fixedDeltaTime);
        } 
        else if (d > maxDistance && speed < maxSpeed)
        {
            speed++;
            rb.MovePosition(rb.transform.position + dir * speed * Time.fixedDeltaTime);
        }
        else
        {
            //rb.MovePosition(rb.transform.position + dir * speed * Time.fixedDeltaTime);
            speed = initSpeed;
        }
    }
}
