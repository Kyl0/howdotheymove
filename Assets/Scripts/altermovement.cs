using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altermovement : movement
{
    private float changeSpeed;
    private float changeJump;
    private float nSpeed;
    private float nJump;

    public SpeedBarBehavior SpeedBar;

    void Start()
    {
        changeSpeed = getSpeed();
        changeJump = getJumpforce();
    }

    // Update is called once per frame
    void Update()
    {
        bool left = Input.GetKey("left");
        bool right = Input.GetKey("right");
        bool up = Input.GetKey("up");
        bool down = Input.GetKey("down");

        //Debug.Log(changeSpeed);
        if (left == true && changeSpeed >= 10 )
        {
            nSpeed = changeSpeed - 10 * Time.deltaTime;
            setSpeed(nSpeed);
            changeSpeed = nSpeed;
            SpeedBar.DisplaySpeed(getSpeed());
        }
        if(right == true && changeSpeed <= 60)
        {
            nSpeed = changeSpeed + 10 * Time.deltaTime;
            setSpeed(nSpeed);
            changeSpeed = nSpeed;
            SpeedBar.DisplaySpeed(getSpeed());
        }
        if(up == true && changeJump <= 25)
        {
            nJump = changeJump + 10 * Time.deltaTime;
            setJumpforce(nJump);
            changeJump = nJump;
        }
        if (down == true && changeJump >= 5)
        {
            nJump = changeJump - 10 * Time.deltaTime;
            setJumpforce(nJump);
            changeJump = nJump;
        }

    }
}
