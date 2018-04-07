using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    //Fuerzas de movimiento
    public float forwardForce = 2000f;
    public float SidewaysForce = 500f;
    public float jumpingForce = 1f;


    void Start()
    {

    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //palante
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //derecha
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //izquierda
        }
        //Salto
        if (Input.GetKey("w"))
        { 
            rb.AddForce(0, jumpingForce, 0, ForceMode.Impulse);
        } 
    }

    void Update()
    {
        
    }
}
