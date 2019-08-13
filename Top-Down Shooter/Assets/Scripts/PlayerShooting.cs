using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject sword;

    // Update is called once per frame
    void Update()
    {
        //If we press the main button we instanciate a knifeso we are able to shoot
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(sword);
        }
    }
}
