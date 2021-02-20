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
    private float speed;
    private float jump;
    public float minDistance;

    void Update()
    {
        speed = mv.getSpeed() - 2;
        jump = mv.getJumpforce() - 3;

        Vector3 dir = (target.transform.position - rb.transform.position).normalized;
        if (Vector2.Distance(target.transform.position, rb.transform.position) > minDistance)
        {
            rb.MovePosition(rb.transform.position + dir * (speed + jump) / 2 * Time.fixedDeltaTime);
        }
    }
}
