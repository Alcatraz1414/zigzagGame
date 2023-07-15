using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{

    private GroundSpawnController groundSpawnController;
    private Rigidbody rb;
    [SerializeField] private float endYValue;
    private int groundDirection;

    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition()
    {
        if(transform.position.y <= endYValue)  //nesnenin y deðeri verilen y deðerinden küçük olunca çalýþacak
        {
            SetRigiBodyValues();  // düþeni sona koyacaðýmýz için gravitysini kapuýyoruz ve kinematicini açýyoruz
            SetGroundNewPosition();
        }
    }

    private void SetGroundNewPosition()  //yerleþtirilen küplerin son küpe göre yeniden yerleþtirilmesi
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x - 1f, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z + 1);
        }


        groundSpawnController.lastGroundObject = gameObject;
    }

    private void SetRigiBodyValues()  //
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
