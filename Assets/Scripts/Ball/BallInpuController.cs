using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInpuController : MonoBehaviour
{
    
    [HideInInspector]public Vector3 ballDirection;

    void Start()
    {
        ballDirection = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        HandleBallInput();
    }

    private void HandleBallInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection()  //topun gidiþ yönünü belirliyoruz HandleBallInput a göre her týkladýðýmýzda bu çalýþýyor ve sola gidiyorsak týklayýnca rotayý saða(burada forward) yapýyor.
    {
        if (ballDirection.x == -1)
        {
            ballDirection= Vector3.forward;
        }
        else
        {
            ballDirection= Vector3.left;
        }
    }
}
