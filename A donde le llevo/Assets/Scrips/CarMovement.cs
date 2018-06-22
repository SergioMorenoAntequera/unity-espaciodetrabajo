using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

    public Transform transformCoche;
    public Transform ruedas;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        //Movimiento del coche en general
        transformCoche.position += new Vector3(0, 0, -1);

        //Ruedas girando
        ruedas.rotation = new Quaternion(1, 0, 0, 0);


    }
}
