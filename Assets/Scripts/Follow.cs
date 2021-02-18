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
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
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

    public Transform target;
    public Rigidbody2D rb;
    public float speed;
    public float minDistance;

    void Update()
    {
        Vector3 dir = (target.transform.position - rb.transform.position).normalized;
        if (Vector2.Distance(target.transform.position, rb.transform.position) > minDistance)
        {
            rb.MovePosition(rb.transform.position + dir * speed * Time.fixedDeltaTime);
        }
    }
}
