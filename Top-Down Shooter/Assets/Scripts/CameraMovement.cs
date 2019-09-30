using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 playerPosition;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = playerTransform.position;

        if (playerPosition.x > -55 && playerPosition.x < -27 || playerPosition.x < 55 && playerPosition.x > 27)
        {
            transform.position = new Vector3(transform.position.x, playerPosition.y, -10);

        }
        else if (playerPosition.y > -55 && playerPosition.y < -27 || playerPosition.y < 55 && playerPosition.y > 27)
        {

        }
        else
        {
            Debug.Log("asd");
            transform.position = new Vector3(playerPosition.x, playerPosition.y, -10);
        }

        /*if(playerPosition.y < -15 || playerPosition.y > 15)
        {
            transform.position = new Vector3(playerPosition.y, transform.position.y, -10);
        }*/
    }
}
