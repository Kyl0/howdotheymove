using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public static float speed;
    public static float jumpForce;
    private bool isGrounded;
    public Transform feetPos;
    //public float checkRadius;
    public float boxLength;
    public float boxHeight;
    public LayerMask ground;

    // Start is called before the first frame update
    void Awake()
    {
        speed = 10;
        jumpForce = 7;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);
        //isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, ground);
        Vector2 box = new Vector2(boxLength, boxLength);
        isGrounded = Physics2D.OverlapBox(feetPos.position, box, 90f, ground);
        //Debug.Log(speed);
        //Debug.Log(jumpForce);


        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
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
