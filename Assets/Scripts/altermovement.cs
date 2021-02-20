using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altermovement : movement
{
    private float changeSpeed;
    private float changeJump;
    private float nSpeed;
    private float nJump;
    private float maxspeed = 60f;
    private float minspeed = 10f;
    private float maxjump = 25f;
    private float minjump = 5f;
    public SpeedBarBehavior SpeedBar;
    public JumpBarBehavior JumpBar;

    void Start()
    {
        changeSpeed = getSpeed();
        changeJump = getJumpforce();
        SpeedBar.SetBarLimits(minspeed, maxspeed);
        JumpBar.SetBarLimits(minjump, maxjump);
    }

    // Update is called once per frame
    void Update()
    {
        bool left = Input.GetKey("left");
        bool right = Input.GetKey("right");
        bool up = Input.GetKey("up");
        bool down = Input.GetKey("down");

        SpeedBar.DisplaySpeed(getSpeed());
        JumpBar.DisplayJump(getJumpforce());
        //Debug.Log(changeSpeed);
        if (left == true && changeSpeed >= minspeed )
        {
            nSpeed = changeSpeed - 20 * Time.deltaTime;
            setSpeed(nSpeed);
            changeSpeed = nSpeed;
            //SpeedBar.DisplaySpeed(getSpeed());
        }
        if(right == true && changeSpeed <= maxspeed)
        {
            nSpeed = changeSpeed + 20 * Time.deltaTime;
            setSpeed(nSpeed);
            changeSpeed = nSpeed;
            //SpeedBar.DisplaySpeed(getSpeed());
        }
        if(up == true && changeJump <= maxjump)
        {
            nJump = changeJump + 10 * Time.deltaTime;
            setJumpforce(nJump);
            changeJump = nJump;
        }
        if (down == true && changeJump >= minjump)
        {
            nJump = changeJump - 10 * Time.deltaTime;
            setJumpforce(nJump);
            changeJump = nJump;
        }

    }
}
