using UnityEngine;

public class BallMovement : MonoBehaviour {
    
	private Vector3 posicionInicial = Vector3.zero;
    public float velocidadInicial = 0f;
	public float aceleracion = 0.01f;
	public Rigidbody rigidbody;
	public Transform transform;
	int direccionX;
    int direccionY;

    public void Start () {

        transform.position = new Vector3 (0, 0, 0);
		rigidbody.velocity = (Vector3.zero);
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
        rigidbody.velocity = new Vector3(velocidadInicial*direccionX, velocidadInicial*direccionY, 0);
    }
	
    //Va aumentando la velocidad
	void Update () {
		rigidbody.velocity += rigidbody.velocity*aceleracion * Time.deltaTime;
    }

	//Para que cuando toque vuelva al principio
	public void OnCollisionEnter (Collision collisionInfo){
		if (collisionInfo.collider.name == ("Decoracion3-ParedDer")) {
            //var m = GameObject.FindGameObjectWithTag("puntosIzq").GetComponent<MarcadorIzq>();
            var m = GameObject.FindObjectOfType<MarcadorIzq>();
            m.add();
            Start();
        }
		if (collisionInfo.collider.name == ("Decoracion4-ParedIzq")) {
            //var m = GameObject.FindGameObjectWithTag("puntosDer").GetComponent<Marcador>();
            var m = GameObject.FindObjectOfType<Marcador>();
            m.add();
            Start();
        }
	}
}
