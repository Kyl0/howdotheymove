using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private static float speed;
    private static float jumpForce;
    public LayerMask ground;

    // Start is called before the first frame update
    void Awake()
    {
        speed = 10;
        jumpForce = 9;
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);
        //Debug.Log(speed);
        Debug.Log(jumpForce);

        if (Input.GetButtonDown("Jump"))
        {
            if (bc.IsTouchingLayers(ground))
                Jump(Vector2.up);
        }

        Walk(dir);
    }

    private void Walk(Vector2 dir)
    {
        rb.velocity = (new Vector2(dir.x * speed, rb.velocity.y));
    }

    private void Jump(Vector2 dir)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += dir * jumpForce;
    }

    public float getSpeed()
    {
        return speed;
    }

    public void setSpeed(float newSpeed)
    {
        //Debug.Log(newSpeed);
        speed = newSpeed;
    }

    public float getJumpforce()
    {
        return jumpForce;
    }

    public void setJumpforce(float newJumpforce)
    {
        jumpForce = newJumpforce;
    }
}
