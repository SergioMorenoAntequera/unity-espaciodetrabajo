using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Transform transform;
    public Rigidbody rigidbody;
    public float velocidad = 0f;
    public float aceleracion = 0f;
    private Vector3 posicionInicial = new Vector3(19f, 0, 0);
    private Vector3 tamañoInicial = new Vector3(0.5f, 4, 1);

    /***********************POSICIONES(esto no haría falta)********************************/
    //Hay 3 putos objetos, y me da pereza hacer otro Script
    void Start () {
        if(name == "RightP")
        {
            //Jugador de la derecha
            transform.position = posicionInicial;
            transform.localScale = tamañoInicial;
        } 
       
        if(name == "LeftP")
        {
            //Jugador de la izquierda
            transform.position = -posicionInicial;
            transform.localScale = tamañoInicial;
        }
	}
	
	/***********************MOVIMIENTO********************************/
	void Update () {
        //Jugador de la derecha
        if (name == "RightP")
        {
            //Para arriba
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rigidbody.AddForce(0, velocidad * Time.deltaTime, 0);
                velocidad += aceleracion;
            } else
            {
                //Para abajo
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rigidbody.AddForce(0, -velocidad * Time.deltaTime, 0);
                    velocidad += aceleracion;

                }
                else
                {
                    //Parar la barra cuando se suelta
                    rigidbody.velocity = Vector3.zero;
                    velocidad = 700;
                }
            }
        }

        //Jugador de la izquierda
        if (name == "LeftP")
        {
            //Para arriba
            if (Input.GetKey(KeyCode.W))
            {
                rigidbody.AddForce(0, velocidad * Time.deltaTime, 0);
                velocidad += aceleracion;
            }
            else
            {
                //Para abajo
                if (Input.GetKey(KeyCode.S))
                {
                    rigidbody.AddForce(0, -velocidad * Time.deltaTime, 0);
                    velocidad += aceleracion;

                }
                else
                {
                    //Parar la barra cuando se suelta
                    rigidbody.velocity = Vector3.zero;
                    velocidad = 700;
                }
            }
        }
    }
}
