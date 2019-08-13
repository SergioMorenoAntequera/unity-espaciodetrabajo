using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        moveCamera();
    }

    void moveCamera()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
    }
}
