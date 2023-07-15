using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{

    [SerializeField] private BallInpuController ballInputController;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GetBallDirection()
    {
        return ballInputController.ballDirection;
    }

}
