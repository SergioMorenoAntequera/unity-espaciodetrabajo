using UnityEngine;

public class BallMovement : MonoBehaviour {

    private Vector3 posicionInicial = Vector3.zero;
    public float VelocidadInicial = 0f;
    public Rigidbody rigidbody;
    int direccionX;
    int direccionY;

    void Start () {

        //Darle una direccion aleatoria en el eje x, y
        direccionX = Random.Range(0, 2);
        if (direccionX == 0)
        {
            direccionX = -1;
        }
        direccionY = Random.Range(0, 2);
        if (direccionY == 0)
        {
            direccionY = -1;
        }
        rigidbody.velocity = new Vector3(VelocidadInicial*direccionX, VelocidadInicial*direccionY, 0);
    }
	
	void Update () {
        rigidbody.velocity += rigidbody.velocity*0.01f * Time.deltaTime;
        Debug.Log(rigidbody.velocity);
    }
}
