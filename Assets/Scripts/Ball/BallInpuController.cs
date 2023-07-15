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

    private void ChangeBallDirection()  //topun gidi� y�n�n� belirliyoruz HandleBallInput a g�re her t�klad���m�zda bu �al���yor ve sola gidiyorsak t�klay�nca rotay� sa�a(burada forward) yap�yor.
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
