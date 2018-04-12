using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Transform transform;
    public float velocidad = 1f;
    public KeyCode derecha;
    public KeyCode izquierda;

    // Use this for initialization
    void Start () {
        //Colocar barra
        transform.position = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        //Movimiento barra
        if (Input.GetKey(derecha) && transform.position.x < 11f)
        {
            transform.Translate(new Vector3(velocidad, 0, 0));
        }
        if (Input.GetKey(izquierda) && transform.position.x > -11f)
        {
            transform.Translate(new Vector3(-velocidad, 0, 0));
        }
    }
}
